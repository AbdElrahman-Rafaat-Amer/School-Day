import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SubjectService {

  constructor(private http:HttpClient) { }

  getteacher():Observable<any>{
    return this.http.get('https://my-json-server.typicode.com/typicode/demo/posts')
  }
}
