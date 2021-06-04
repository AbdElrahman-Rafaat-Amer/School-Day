import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'bottom-bar',
  templateUrl: './bottom-bar.component.html',
  styleUrls: ['./bottom-bar.component.scss']
})
export class BottomBarComponent implements OnInit {

showMe:boolean=true;
  constructor() { }

  ngOnInit(): void {
  }


}
