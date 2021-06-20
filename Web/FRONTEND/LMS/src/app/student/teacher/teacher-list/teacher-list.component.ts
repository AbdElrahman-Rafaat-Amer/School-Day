import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-teacher-list',
  templateUrl: './teacher-list.component.html',
  styleUrls: ['./teacher-list.component.css']
})
export class TeacherListComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  teachers:string[][] = [
    ["1","Abdelrahman"],
    ["2","Osama Abuzid"],
    ["3","Amena"],
    ["4","Mohamed Ahmed"],
    ["5","Kareem Mohye"],
  ];
}
