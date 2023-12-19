import { HttpClient, HttpParams, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';
import { PageEvent } from '@angular/material/paginator';

import { Order } from '../order';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  constructor(protected http: HttpClient) { }
  
  getData(
    event: PageEvent | null,
    params: HttpParams 
  ): Observable<HttpResponse<Order[]>> {
    const url = this.getUrl("api/orders");

    if (event) {
    params = params.set("pageNumber", (event.pageIndex + 1).toString())
                   .set("pageSize", event.pageSize.toString());
    }

    return this.http.get<Order[]>(url, { observe: 'response', params });
  }
  

  protected getUrl(url: string) {
    return environment.baseUrl + url;
  }
}
