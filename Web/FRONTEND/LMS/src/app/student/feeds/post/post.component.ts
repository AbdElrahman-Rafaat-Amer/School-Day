import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { posts } from '../posts';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.scss']
})
export class PostComponent implements OnInit{
  
  @Input() Post : posts;
  findText:boolean = false;
  findImage:boolean = false;
  
  constructor() {
  }

  ngOnInit(): void {
    console.log(this.Post.photos);
    if(this.Post != undefined){
      if(this.Post.text != ""){this.findText = true}
      if(this.Post.photos.length != 0){this.findImage = true}
    }
  }

}
