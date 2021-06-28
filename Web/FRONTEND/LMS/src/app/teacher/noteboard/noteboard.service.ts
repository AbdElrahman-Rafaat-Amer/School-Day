import { CreateNoteBoard } from './create-noteboard';
import { note } from './show-noteboard';
import { subject } from './subject';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';


const baseURL = `${environment.apiUrl}/note`;

@Injectable({
  providedIn: 'root'
})
export class NoteboardService {

  constructor(private http:HttpClient) { 
  }

  getListOfNotes(){
    return this.http.get<note[]>(`${baseURL}/ListOfNotes`);
  }

  getListOfSubjects(){
    return this.http.get<subject[]>(`${baseURL}/GetSubjects`);
  }

  createNewNote(Note:CreateNoteBoard){
    return this.http.post<CreateNoteBoard>(`${baseURL}/CreateNote`,Note);
  }

  deleteNote(id:number){
    return this.http.delete(`${baseURL}/DeleteNote/${id}`);
  }

  getSubject(id:number){
    return this.http.get<any>(`${baseURL}/GetSubjectById/${id}`);
  }
}
