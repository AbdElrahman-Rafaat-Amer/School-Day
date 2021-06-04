import { Component, OnInit, NgModule } from '@angular/core';

@Component({
  selector: 'app-noteboared',
  templateUrl: './noteboared.component.html',
  styleUrls: ['./noteboared.component.scss']
})
export class NoteboaredComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  div: number[] = [];
  date=Date.now();


  createDivs(): void {
    this.div.unshift(this.div.length);
  }




}
