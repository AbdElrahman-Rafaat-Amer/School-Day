import { CalendarOptions } from '@fullcalendar/angular';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

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

  calendarOptions: CalendarOptions = {
    initialView: 'dayGridMonth',
    dateClick: this.handleDateClick.bind(this), // bind is important!
    events: [
      { title: 'First using FC', date: '2020-06-5' },
      { title: 'event 2', date: '2020-06-30' }
    ]
  };
  handleDateClick(arg) {
    alert('date click! ' + arg.dateStr)
  }

}
