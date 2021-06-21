
import { Component, OnInit } from '@angular/core';

interface SubjectName {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'app-downloads',
  templateUrl: './downloads.component.html',
  styleUrls: ['./downloads.component.scss']
})


export class DownloadsComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  subjectName: SubjectName[] = [
    {value: 'Math-0', viewValue: 'Math'},
    {value: 'Arabic-1', viewValue: 'Arabic'},
    {value: 'English-2', viewValue: 'English'}
  ];

}
