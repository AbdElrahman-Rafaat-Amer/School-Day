import { FeesComponent } from './fees/fees.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FullCalendarModule } from '@fullcalendar/angular';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { StudentRoutingModule } from './student-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ChatComponent } from './chat/chat.component';
import { SettingComponent } from './setting/setting.component';
import { InfoComponent } from './info/info.component';
import { QuetionsComponent } from './quetions/quetions.component';
import { BusComponent } from './bus/bus.component';
import { NoteboardComponent } from './noteboard/noteboard.component';
import { DownloadsComponent } from './downloads/downloads.component';
import { AttendanceComponent } from './attendance/attendance.component';
import { LayoutComponent } from './layout.component';
import { NgCircleProgressModule } from 'ng-circle-progress';
import { QrCodeModule } from 'ng-qrcode';

@NgModule({
  declarations: [
    LayoutComponent,
    DashboardComponent,
    ChatComponent,
    SettingComponent,
    InfoComponent,
    QuetionsComponent,
    BusComponent,
    NoteboardComponent,
    DownloadsComponent,
    AttendanceComponent,
    FeesComponent
    
  ],
  imports: [
    CommonModule,
    StudentRoutingModule,
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
export class StudentModule { }
