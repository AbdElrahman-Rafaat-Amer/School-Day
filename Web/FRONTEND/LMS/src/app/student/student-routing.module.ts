import { LayoutComponent } from './../profile/layout.component';
import { DashboardComponent } from './dashboard.component';
import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

const chatModule = () => import('./chat/chat.module').then(x => x.ChatModule);

const routes : Routes = [
  {
    path:'',component: LayoutComponent,
    children:[
      {path:'', component: DashboardComponent},
      {path:'chat', loadChildren: chatModule }
    ]
  },{
    path: '**' , redirectTo: ''
  }
]

@NgModule({
  imports:[RouterModule.forChild(routes)],
  exports:[RouterModule]
})
export class StudentRoutingModule { }
