import { Assginment } from './assginment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AssignmentService {

  constructor(private http:HttpClient) { }
  getassignment():Observable<Assginment[]>{
    return this.http.get<Assginment[]>('../assets/assignment.json');
  }

}
