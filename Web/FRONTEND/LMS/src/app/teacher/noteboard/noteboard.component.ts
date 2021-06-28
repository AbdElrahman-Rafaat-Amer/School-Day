import { subject } from './subject';
import { AlertService } from './../../_services/alert.service';
import { first } from 'rxjs/operators';
import { NoteboardService } from './noteboard.service';
import { FormBuilder, Validators, FormGroup, FormControl } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { note } from './show-noteboard' 
import { CalendarDataManager } from '@fullcalendar/angular';
import { Observable } from 'rxjs/internal/Observable';
import { BehaviorSubject } from 'rxjs/internal/BehaviorSubject';

@Component({
  selector: 'app-noteboard',
  templateUrl: './noteboard.component.html',
  styleUrls: ['./noteboard.component.css']
})
export class NoteboardComponent implements OnInit {
  form:FormGroup
  listNotes:any[];
  listSubject:any[];
  loading = false;
  submitted = false;
  private behaviorSubject: BehaviorSubject<subject>;
  public subject: Observable<subject>;
  

  constructor(
        private formBuilder: FormBuilder,
        private service:NoteboardService,
        private alertService: AlertService
  ) {
        this.behaviorSubject = new BehaviorSubject<subject>(null);
        this.subject = this.behaviorSubject.asObservable();
   }

  ngOnInit(): void {
    
    this.loadListNotes();
    this.service.getListOfSubjects().pipe(first()).subscribe(
      subject => this.listSubject = subject
    )

    this.form = this.formBuilder.group({
      title: ['', [Validators.required]],
      text: ['', Validators.required],
      subjectid: [0,Validators.required]
    });
  }

  public get subjectValue():subject {
    return this.behaviorSubject.value;
}

  appearNote(Note:note){
    console.log(Note.subjectid);
    this.form.patchValue(Note);
  }

  getSubject(id:number){
    this.service.getSubject(id)
    .pipe(first())
    .subscribe(
      result => this.behaviorSubject.next(result) 
    )
  }

  newNote(){
    this.form.reset();
  }
  
  loadListNotes(){
    this.service.getListOfNotes().pipe(first()).subscribe(
      notes => this.listNotes = notes
    )
  }
  get f() { return this.form.controls; }

  deleteNote(id:number){
    this.service.deleteNote(id)
    .pipe(first())
    .subscribe(() => {
      this.alertService.success("Note deleted successfully", { keepAfterRouteChange: true });
      this.loadListNotes();
  });
    
  }
  onSubmit(){
    this.submitted = true;
    
    if (this.form.invalid) {
      return;
    }
    
    

    this.loading = true;
    this.service.createNewNote(this.form.value)
            .pipe(first())
            .subscribe({
                next: () => {
                  this.loadListNotes();
                  this.form.reset();
                },
                error: error => {
                    this.alertService.error(error);
                    this.loading = false;
                }
    });

  }

}
