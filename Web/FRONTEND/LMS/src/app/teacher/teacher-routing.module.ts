import { DownloadsComponent } from './../student/downloads/downloads.component';
import { PDFAssignmentComponent } from './pdf-assignment/pdf-assignment.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { NoteboardComponent } from './noteboard/noteboard.component';
import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutComponent } from './layout.component';


const chatModule = () => import('./chat/chat.module').then(x=>x.ChatModule);
const feedsModule = () => import('./feeds/feeds.module').then(x => x.FeedsModule);

const routes : Routes = [
  {
    path:'',component: LayoutComponent,
    children:[
      {path:'', component: DashboardComponent},
      {path:'chat', loadChildren: chatModule },
      {path:'noteboard',component:NoteboardComponent},
      {path:'feeds', loadChildren:feedsModule},
      {path:'assignment', component:PDFAssignmentComponent},
      {path:'downloads', component:DownloadsComponent}
    ]
  },{
    path: '**' , redirectTo: ''
  }
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TeacherRoutingModule { }
