import { ChatRoutingModule } from './chat/chat-routing.module';
import { StudentRoutingModule } from './student-routing.module';
import { StudentComponent } from './student.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from './dashboard.component';
import { LayoutComponent } from './layout.component';
import { ChatComponent } from './chat/chat.component';



@NgModule({
  declarations: [
    DashboardComponent,
    LayoutComponent,
    ChatComponent,
  ],
  imports: [
    CommonModule,
    StudentRoutingModule
  ]
})
export class StudentModule { }
