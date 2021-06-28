import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-teacher-list',
  templateUrl: './teacher-list.component.html',
  styleUrls: ['./teacher-list.component.css']
})
export class TeacherListComponent implements OnInit {

  src:string;
  constructor() { }

  ngOnInit(): void {
  }
  teachers:string[][] = [
    ["1","Amena","assets/img/Random-images-face/face5.jpg"],
    ["2","Haithm Elwahsh","assets/img/Random-images-face/face1.jpg"],
    ["3","Osama Abuzid","assets/img/Random-images-face/face2.jpg"],
    ["4","Ahmed Elashry","assets/img/Random-images-face/face3.jpg"],
    ["5","Reda Mohamed","assets/img/Random-images-face/face4.jpg"],
  ];
}
