import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FeesServicesService {

  constructor(private http:HttpClient) { }

  getfees():Observable<any>{
    return this.http.get("https://disease.sh/v3/covid-19/countries");
  }


}
