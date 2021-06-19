import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-subject',
  templateUrl: './subject.component.html',
  styleUrls: ['./subject.component.scss']
})
export class SubjectComponent {

  constructor() { }
  subject !:string;

  index=
  [this.subject='c',
  this.subject='A',
  this.subject='B',
      ];


}
