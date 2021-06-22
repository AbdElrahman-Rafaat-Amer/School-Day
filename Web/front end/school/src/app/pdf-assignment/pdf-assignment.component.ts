import { Component, OnInit } from '@angular/core';

interface SubjectName {
  value: string;
  viewValue: string;
}


@Component({
  selector: 'app-pdf-assignment',
  templateUrl: './pdf-assignment.component.html',
  styleUrls: ['./pdf-assignment.component.scss']
})


export class PDFAssignmentComponent implements OnInit {
  Namevalue = '';
  Startvalue = '';
  Endvalue = '';

  constructor() { }
  ngOnInit(): void {
  }
  subjectName : SubjectName[] = [
    {value: 'Math-0', viewValue: 'Math'},
    {value: 'Arabic-1', viewValue: 'Arabic'},
    {value: 'English-2', viewValue: 'English'}
  ];

}
