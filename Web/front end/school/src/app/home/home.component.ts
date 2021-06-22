import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  Tittle = ['Subject',
  'Exame',
  'Online Exame',
  'Attendance',
  'Notice',
  'Home Work',
  'Teachers',
  'Issued Book'
  ];


}
