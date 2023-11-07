import { PortalHostDirective } from '@angular/cdk/portal';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  getDepartamento() {
    return this.http.get(`http://localhost:58683/admin-units`);
  }
}
