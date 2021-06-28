import { PDFAssignmentComponent } from './pdf-assignment/pdf-assignment.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { NoteboardComponent } from './noteboard/noteboard.component';
import { ChatComponent } from './../teacher/chat/chat.component';
import { TeacherRoutingModule } from './teacher-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutComponent } from './layout.component';
import { FullCalendarModule } from '@fullcalendar/angular';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { QrCodeModule } from 'ng-qrcode';
import { NgCircleProgressModule } from 'ng-circle-progress';



@NgModule({
  declarations: [
    LayoutComponent,
    DashboardComponent,
    ChatComponent,
    NoteboardComponent,
    PDFAssignmentComponent
  ],
  imports: [
    CommonModule,
    TeacherRoutingModule,
    CommonModule,
    FullCalendarModule,
    FormsModule,
    ReactiveFormsModule,
    QrCodeModule,
    
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
