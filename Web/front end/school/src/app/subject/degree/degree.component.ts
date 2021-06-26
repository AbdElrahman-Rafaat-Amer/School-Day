import { Component, OnInit } from '@angular/core';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';

@Component({
  selector: 'degree',
  templateUrl: './degree.component.html',
  styleUrls: ['./degree.component.scss']
})
export class DegreeComponent implements OnInit {

  mode : ProgressSpinnerMode = 'determinate';
  value = 100;


  constructor() { }
  ngOnInit(): void {
  }

}
