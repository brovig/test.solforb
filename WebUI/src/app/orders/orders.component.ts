import { HttpClient, HttpParams } from '@angular/common/http';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';

import { Order } from './order';
import { OrderService } from './services/order.service';
import { ProviderService } from './services/provider.service';
import { Provider } from './provider';
import { OrderItem } from './orderItem';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.scss']
})
export class OrdersComponent implements OnInit {
  public displayedColumns: string[] = ['id', 'date', 'number', 'providerId', 'items'];
  public orders!: MatTableDataSource<Order>;
  public orderNumbersForFilter: string[] = [];
  public orderItemsForFilter: OrderItem[] = [];
  public orderItemNamesForFilter: string[] = [];
  public orderItemUnitsForFilter: string[] = [];
  public providers!: Provider[];
  public dateRangeForm!: FormGroup;
  public filtersForm!: FormGroup;
  
  constructor(private http: HttpClient,
    private orderService: OrderService,
    private providerService: ProviderService,
    private fb: FormBuilder) {
  }

  @ViewChild(MatPaginator) paginator!: MatPaginator;

  ngOnInit() {
    this.loadProviders();
    this.loadOrders();
    this.initializeDateRangeForm();
    this.initializeFilterForm();    
  }

  loadProviders() {
    this.providerService.getData().subscribe(result => {
      this.providers = result;
    });
  }

  loadOrders() {
    const pageEvent = new PageEvent();
    pageEvent.pageIndex = 0;
    pageEvent.pageSize = 10;

    const endDate = new Date();
    const startDate = new Date(endDate);
    startDate.setMonth(endDate.getMonth() - 1);
    const params = new HttpParams()
      .set("endDate", endDate.toISOString().split('.')[0] + 'Z')
      .set("startDate", startDate.toISOString().split('.')[0] + 'Z');

    this.getOrders(pageEvent, params);
  }

  getOrders(pageEvent: PageEvent | null, params: HttpParams) {
    this.orderService.getData(pageEvent, params).subscribe(result => {
      this.orders = new MatTableDataSource<Order>(result.body!);
      const paginationHeader = JSON.parse(result.headers.get('x-pagination')!);
      this.paginator.length = paginationHeader.TotalCount;
      this.paginator.pageIndex = paginationHeader.CurrentPage - 1;
      this.paginator.pageSize = paginationHeader.PageSize;

      result.body!.forEach((o) => {
        this.orderItemsForFilter.push(...o.items);
        this.orderItemUnitsForFilter = [...new Set(this.orderItemsForFilter.map(item => item.unit))];
        this.orderNumbersForFilter.push(o.number);
      });
    }, error => console.error(error));
  }

  filterOrders(pageEvent: PageEvent | null, params: HttpParams) {
    this.orderService.getData(pageEvent, params).subscribe(result => {
      this.orders = new MatTableDataSource<Order>(result.body!);
      const paginationHeader = JSON.parse(result.headers.get('x-pagination')!);
      this.paginator.length = paginationHeader.TotalCount;
      this.paginator.pageIndex = paginationHeader.CurrentPage - 1;
      this.paginator.pageSize = paginationHeader.PageSize;
    }, error => console.error(error));
  }

  initializeDateRangeForm() {
    const today = new Date();
    const monthAgo = new Date(today);
    monthAgo.setMonth(today.getMonth() - 1);

    this.dateRangeForm = new FormGroup({
      start: new FormControl<Date | null>(monthAgo),
      end: new FormControl<Date | null>(today),
    });
  }

  initializeFilterForm() {
    this.filtersForm = this.fb.group({
      orderNumbers: [''],
      orderItemNames: [''],
      orderItemUnits: [''],
      providerIds: [''],
      providerNames: ['']
    });
  }

  onSubmit() {
    const params = this.getParams();
    this.filterOrders(null, params);    
  }


  getProviderNameById(id: number): string {
    const prov = this.providers.find(p => {
      return p.id === id
    });

    return prov!.name;
  }

  getParams(): HttpParams {
    let params = new HttpParams();
    if (this.dateRangeForm.controls['start'].value) {
      params = params.set("startDate", this.dateRangeForm.controls['start'].value.toISOString().split('.')[0] + 'Z');
    }
    if (this.dateRangeForm.controls['end'].value) {
      params = params.set("endDate", this.dateRangeForm.controls['end'].value.toISOString().split('.')[0] + 'Z');
    }

    for (const field in this.filtersForm.controls) {
      if (this.filtersForm.controls[field].value != '') {
        const valuesArray = this.filtersForm.controls[field].value;
        valuesArray.forEach((val: string) => {
          params = params.append(field, val);
        });
      }
    }
    return params;
  }
}
