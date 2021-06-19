import { Component, OnInit } from '@angular/core';

interface SubjectName {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'online-assignment',
  templateUrl: './online-assignment.component.html',
  styleUrls: ['./online-assignment.component.scss']
})
export class OnlineAssignmentComponent implements OnInit {
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
