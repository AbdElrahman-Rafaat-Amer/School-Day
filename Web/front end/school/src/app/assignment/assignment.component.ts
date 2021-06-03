import { AssignmentService } from './assignment.service';
import { Observable } from 'rxjs';
import { Assginment } from './assginment';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-assignment',
  templateUrl: './assignment.component.html',
  styleUrls: ['./assignment.component.scss']
})
export class AssignmentComponent implements OnInit {
public page=1;
public pageSize=10;
public Assginment:Array<Assginment>=[];


  searchValue!: string;
  // assginment$:any;
  // constructor( Assginment:AssignmentService) {
  //   this.assginment$=Assginment.getassignment();
  // }

  constructor( private _Assginment:AssignmentService) {
  }


  ngOnInit(): void {
    this._Assginment.getassignment()
      .subscribe(data => this.Assginment=data);
  }



  key= 'ContentTitle';
  reverse :boolean=false;
  sort(key: any){
    this.key=key;
    this.reverse=!this.reverse;
  }




}
