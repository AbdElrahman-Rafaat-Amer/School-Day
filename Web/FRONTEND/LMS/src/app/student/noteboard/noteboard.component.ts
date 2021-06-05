import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-noteboard',
  templateUrl: './noteboard.component.html',
  styleUrls: ['./noteboard.component.css']
})
export class NoteboardComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  div: number[] = [];
  date=Date.now();


  createDivs(): void {
    this.div.unshift(this.div.length);
  }

}
