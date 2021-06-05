import { CalendarOptions } from '@fullcalendar/angular';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-attendance',
  templateUrl: './attendance.component.html',
  styleUrls: ['./attendance.component.css']
})
export class AttendanceComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  formattitle = (percent: number) : string => {
    return "26 Days";
  }

  formatsubtitle = (percent: number) : string => {
    return "Of 31 Days";
  }

  FormatAttendance = (percent: number) : string => {
    return "Attendance";
  }

  
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
