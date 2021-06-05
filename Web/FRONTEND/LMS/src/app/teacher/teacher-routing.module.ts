import { DashboardComponent } from './dashboard.component';
import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutComponent } from './layout.component';


const chatModule = () => import('./chat/chat.module').then(x=>x.ChatModule);

const routes : Routes = [
  {
    path: '', component: LayoutComponent,
    children: [
      {path: '', component: DashboardComponent},
      {
        path: 'chat',
        loadChildren: chatModule
      }
    ]
 }
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TeacherRoutingModule { }
