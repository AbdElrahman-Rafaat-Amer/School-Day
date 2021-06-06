import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-degrees',
  templateUrl: './degrees.component.html',
  styleUrls: ['./degrees.component.css']
})
export class DegreesComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
   percent = 40;
   updatePercent(percent : number){
     this.percent = percent;
   }
  degrees:any = [
    ["url_image","Math","green",74],
    ["url_image","Physic","blue",60],
    ["url_image","Programming","rose",29],
    ["url_image","Database","red",30],
    ["url_image","Design Pattern","yellow",85]
  ];

  FormatAttendance = (percent: number) : string => {
    return "Attendance";
  }

  getPercent = (percent: string) : string =>{
    return percent;
  }

}
