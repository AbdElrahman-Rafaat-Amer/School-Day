import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-assignment',
  templateUrl: './assignment.component.html',
  styleUrls: ['./assignment.component.css']
})
export class AssignmentComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  assignments:string[][] = [
    ["url_image","Math","green"],
    ["url_image","Physic","blue"],
    ["url_image","Programming","rose"],
    ["url_image","Database","red"],
    ["url_image","Design Pattern","yellow"]
  ];
}
