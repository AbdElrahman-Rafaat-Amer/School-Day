import { Component,  Input } from '@angular/core';

@Component({
  selector: 'likes',
  templateUrl: './likes.component.html',
  styleUrls: ['./likes.component.scss']
})
export class LikesComponent {


  @Input('likeCount')likesCount!: number ;
  @Input('isActive')isActive:boolean=false;


    onClick(){
      this.likesCount +=(this.isActive) ? -1 : 1;
      this.isActive=!this.isActive;
    }

}
