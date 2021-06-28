import { PostComponent } from './post/post.component';
import { LayoutComponent } from './layout.component';
import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

const routes: Routes =[
  {path:'',component:LayoutComponent,
    children:[
      {path:'', component:PostComponent},
    ]
  }
]

@NgModule({
  imports:[RouterModule.forChild(routes)],
  exports:[RouterModule]
})
export class FeedsRoutingModule { }
