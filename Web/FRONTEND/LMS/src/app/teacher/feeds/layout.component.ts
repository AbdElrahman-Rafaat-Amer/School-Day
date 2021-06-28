import { AccountService } from '@app/_services';
import { FeedsVM } from './post/postmodel';
import { first } from 'rxjs/operators';
import { posts } from './posts';
import { FeedsService } from './feeds.service';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';

@Component({
  selector: 'app-feeds',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.scss']
})
export class LayoutComponent implements OnInit {
  form:FormGroup
  message!: string;
  imagePath: any;
  url!: string | ArrayBuffer | null;

  SelectedFile : File = null;
  Posts: posts[]
  Image : File

  constructor(
    private service:FeedsService,
    private accountService:AccountService
  ) {}

  ngOnInit(): void {
    this.service.getAllPosts().pipe(first()).subscribe(
      p => this.Posts = p
    )

    this.form = new FormGroup({
      text: new FormControl(null),
      photo: new FormControl(null),
      accountid: new FormControl(0)
    });
  }

  SendPost(){
    const formData = new FormData();

    formData.append('Photo', this.Image);
    formData.append('Text', this.form.controls.text.value);
    formData.append('AccountId', this.accountService.accountValue.id.toFixed());

    this.service.addPost(formData).subscribe(
      res => console.log(res),
      err => console.log(err)
    );
  }


  onSelectFile(event : any){
    const files = event.target.files;
    this.Image = event.target.files[0];
    if (files.length === 0)
        return;

    const mimeType = files[0].type;
    if (mimeType.match(/image\/*/) == null) {
        this.message = "Only images are supported.";
        return;
    }


    const reader = new FileReader();
    this.imagePath = files;
    reader.readAsDataURL(files[0]);
    reader.onload = (_event) => {
        this.url = reader.result;
    }
  }




  onFileChanged(event:any) {
    const files = event.target.files;
    if (files.length === 0)
        return;

    const mimeType = files[0].type;
    if (mimeType.match(/image\/*/) == null) {
        this.message = "Only images are supported.";
        return;
    }


    const reader = new FileReader();
    this.imagePath = files;
    reader.readAsDataURL(files[0]);
    reader.onload = (_event) => {
        this.url = reader.result;
    }
  }



}
