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

  constructor(private service:FeedsService, private formBuilder:FormBuilder) {}

  ngOnInit(): void {
    // this.service.getAllPosts().pipe(first()).subscribe(
    //   p => this.Posts = p
    // )

    this.form = new FormGroup({
      text: new FormControl(null),
      photo: new FormControl(null),
      accountid: new FormControl(0)
    });
  }

  onSubmit(data:any){
    const formData = new FormData();

    formData.append('Photo', this.form.get('photo').value);
    formData.append('Text', data.text);
    formData.append('AccountId', data.accountid);

    this.service.addPost(formData).subscribe(
      //res => console.log(res),
      //err => console.log(err)
    );
  }

  onSelectFile(fileInput : any){
    this.SelectedFile = <File>fileInput.target.files[0];
  }



















  onFileChanged(event:any) {
    const files = event.target.files[0];
    if (files.length == 0){
      console.log("This file not good")
      return;
    }
    console.log(files)

    // const mimeType = files[0].type;
    // if (mimeType.match(/image\/*/) == null) {
    //     this.message = "Only images are supported.";
    //     return;
    // }
    // this.form.get('photo').setValue(files);
    
    // const reader = new FileReader();
    // this.imagePath = files;
    // reader.readAsDataURL(files[0]);
    // reader.onload = (_event) => {
    //     this.url = reader.result;
    // }
  }



}
