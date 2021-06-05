import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'posts',
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.scss']
})
export class PostsComponent  {
  tweet={
    body:'...',
    likesCount:5,
    isLiked:false
  }

}
