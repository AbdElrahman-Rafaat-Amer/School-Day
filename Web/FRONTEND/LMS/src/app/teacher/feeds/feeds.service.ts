import { FeedsVM } from './post/postmodel';
import { Observable } from 'rxjs';
import { posts, createPost } from './posts';
import { HttpClient, HttpEvent, HttpParams, HttpRequest } from '@angular/common/http';
import { environment } from './../../../environments/environment.prod';
import { Injectable } from '@angular/core';

const baseURL = `${environment.apiUrl}/feeds`;

@Injectable({
  providedIn: 'root'
})
export class FeedsService {

  constructor(private http:HttpClient) { }

  getAllPosts(){
    return this.http.get<posts[]>(`${baseURL}/GetAllPosts`);
  }

  addPost(formData : FormData){
    return this.http.post<any>(`${baseURL}/AddPost`,formData);
  }
}
