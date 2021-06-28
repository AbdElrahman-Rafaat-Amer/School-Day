import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-personal-info',
  templateUrl: './personal-info.component.html',
  styleUrls: ['./personal-info.component.css']
})
export class PersonalInfoComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  teacherInfo: any[] =["Amena","Amena@gmail.com","Female","01003168016","A+"]
}
