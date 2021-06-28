import { FeesComponent } from './fees/fees.component';
import { ActivityComponent } from './activity/activity.component';
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

const chatModule = () => import('./chat/chat.module').then(x => x.ChatModule);
const teacherModule = () => import('./teacher/teacher.module').then(x => x.TeacherModule);
const feedsModule = () => import('./feeds/feeds.module').then(x => x.FeedsModule);

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
      {path:'attendance', component:AttendanceComponent},
      {path:'teacher', loadChildren:teacherModule},
      {path:'feeds', loadChildren:feedsModule},
      {path:'activity',component:ActivityComponent},
      {path:'fees',component:FeesComponent}
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
