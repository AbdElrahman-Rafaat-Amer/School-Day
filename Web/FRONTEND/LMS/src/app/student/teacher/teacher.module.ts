import { NgCircleProgressModule } from 'ng-circle-progress';
import { FullCalendarModule } from '@fullcalendar/angular';
import { TeacherListComponent } from './teacher-list/teacher-list.component';
import { TeacherRoutingModule } from './teacher-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TeacherLayoutComponent } from './teacher-layout.component';
import { AssignmentComponent } from './assignment/assignment.component';
import { TimetableComponent } from './timetable/timetable.component';
import { DegreesComponent } from './degrees/degrees.component';
import { PersonalInfoComponent } from './personal-info/personal-info.component';



@NgModule({
  declarations: [
    TeacherLayoutComponent,
    TeacherListComponent,
    AssignmentComponent,
    TimetableComponent,
    DegreesComponent,
    PersonalInfoComponent
  ],
  imports: [
    CommonModule,
    TeacherRoutingModule,
    FullCalendarModule,
    NgCircleProgressModule.forRoot({
      // set defaults here
      radius: 100,
      outerStrokeWidth: 16,
      innerStrokeWidth: 8,
      outerStrokeColor: "#78C000",
      innerStrokeColor: "#C7E596",
      animationDuration: 300,
    })
  ]
})
export class TeacherModule { }
