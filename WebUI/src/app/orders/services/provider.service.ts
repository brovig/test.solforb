import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';

import { Provider } from '../provider';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProviderService {

  constructor(protected http: HttpClient) { }

  getData() {
    const url = this.getUrl("api/providers");
    return this.http.get<Provider[]>(url);
  }

  get(providerId: string): Observable<Provider> {
    const url = this.getUrl("api/providers/" + providerId);
    return this.http.get<Provider>(url);
  }

  protected getUrl(url: string) {
    return environment.baseUrl + url;
  }
}
