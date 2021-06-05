import { AttendanceComponent } from './attendance/attendance.component';
import { LayoutComponent } from './layout.component';
import { DownloadsComponent } from './downloads/downloads.component';

import { NoteboardComponent } from './noteboard/noteboard.component';
import { BusComponent } from './bus/bus.component';
import { InfoComponent } from './info/info.component';
import { QuetionsComponent } from './quetions/quetions.component';
import { SettingComponent } from './setting/setting.component';


import { DashboardComponent } from './dashboard/dashboard.component';
import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

const chatModule = () => import('./chat/chat.module').then(x => x.ChatModule);

const routes : Routes = [
  {
    path:'',component: LayoutComponent,
    children:[
      {path:'', component: DashboardComponent},
      {path:'chat', loadChildren: chatModule },
      {path:'setting', component:SettingComponent},
      {path:'quetions', component:QuetionsComponent},
      {path:'info', component:InfoComponent},
      {path:'bus', component:BusComponent},
      {path:'noteboard',component:NoteboardComponent},
      {path:'downloads', component:DownloadsComponent},
      {path:'attendance', component:AttendanceComponent}
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
