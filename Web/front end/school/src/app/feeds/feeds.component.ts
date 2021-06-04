import { Component } from '@angular/core';
import { HttpClient, HttpEvent } from '@angular/common/http';
import { FormGroup, FormControl, Validators} from '@angular/forms';


@Component({
  selector: 'app-feeds',
  templateUrl: './feeds.component.html',
  styleUrls: ['./feeds.component.scss']
})
export class FeedsComponent {

  message!: string;
  imagePath: any;
  url!: string | ArrayBuffer | null;

constructor(private http: HttpClient) { }



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
