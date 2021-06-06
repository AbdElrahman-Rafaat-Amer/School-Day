import { PersonalInfoComponent } from './personal-info/personal-info.component';
import { DegreesComponent } from './degrees/degrees.component';
import { TimetableComponent } from './timetable/timetable.component';
import { AssignmentComponent } from './assignment/assignment.component';
import { TeacherLayoutComponent } from './teacher-layout.component';
import { TeacherListComponent } from './teacher-list/teacher-list.component';
import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

const routes: Routes =[
  {path:'',component:TeacherLayoutComponent,
    children:[
      {path:'assignment', component:AssignmentComponent},
      {path:'timetable', component:TimetableComponent},
      {path:'degrees', component:DegreesComponent},
      {path:'info', component:PersonalInfoComponent}
    ]
  }
]

@NgModule({
  imports:[RouterModule.forChild(routes)],
  exports:[RouterModule]
})
export class TeacherRoutingModule { }
