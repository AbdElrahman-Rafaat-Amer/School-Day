import { FeedsRoutingModule } from './feeds-routing.module';
import { LayoutComponent } from './layout.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PostComponent } from './post/post.component';



@NgModule({
  declarations: [
    LayoutComponent,
    PostComponent,
    
  ],
  imports: [
    CommonModule,
    FeedsRoutingModule
  ]
})
export class FeedsModule { }
