import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { NgModule, Component } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import{BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {NgbPaginationModule, NgbAlertModule, NgbModalModule} from '@ng-bootstrap/ng-bootstrap';
import { NgbCollapseModule } from '@ng-bootstrap/ng-bootstrap';
import{ HttpClientModule} from "@angular/common/http";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {ReactiveFormsModule,FormsModule} from '@angular/forms';
import { NavbarComponent } from './navbar/navbar.component';
import { UpperBarComponent } from './upper-bar/upper-bar.component';
import { BottomBarComponent } from './bottom-bar/bottom-bar.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HomeComponent } from './home/home.component';
import { InfoComponent } from './info/info.component';
import { QuestionsComponent } from './questions/questions.component';
import { SettingComponent } from './setting/setting.component';
import { StudentLoginComponent } from './student-login/student-login.component';
import { TeacherComponent } from './teacher/teacher.component';
import { BusComponent } from './bus/bus.component';
import { DownloadsComponent } from './downloads/downloads.component';
import { NoteboaredComponent } from './noteboared/noteboared.component';
import { FeedsComponent } from './feeds/feeds.component';
import { MatSliderModule } from '@angular/material/slider';
import {MatIconModule } from '@angular/material/icon';
import { MatToolbarModule}from '@angular/material/toolbar';
import { MatCardModule }from '@angular/material/card';
import { MatButtonModule }from '@angular/material/button';
import { MatProgressBarModule }from '@angular/material/progress-bar';
import {MatTabsModule} from '@angular/material/tabs';
import {MatFormFieldModule} from '@angular/material/form-field';
import { MatTableModule} from '@angular/material/table';
import { NavbarModule } from 'angular-bootstrap-md'
import {MatMenuModule} from '@angular/material/menu';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatSelectModule} from '@angular/material/select';
import { MatInputModule }from '@angular/material/input';
import { FooterComponent } from './footer/footer.component';
import { CalenderComponent } from './calender/calender.component';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { CommonModule } from '@angular/common';
import { FlatpickrModule } from 'angularx-flatpickr';
import { LikesComponent } from './likes/likes.component';
import { SubjectComponent } from './subject/subject.component';
import { teacher } from './classes/teacher';
import { TeacherTimetableComponent } from './teacher-timetable/teacher-timetable.component';
import { MatSortModule } from '@angular/material/sort';
import { MatPaginatorModule } from '@angular/material/paginator';
import { FeesComponent } from './fees/fees.component';
import { ActivityComponent } from './activity/activity.component';
import { UpcomingEventsComponent } from './upcoming-events/upcoming-events.component';
import { PostsComponent } from './feeds/posts/posts/posts.component';
import { AssignmentComponent } from './assignment/assignment.component';

import { SearchfilterPipe } from './pipes/searchfilter.pipe';
import { Ng2OrderModule } from 'ng2-order-pipe';
import {NgxPaginationModule } from 'ngx-pagination';
import { PDFAssignmentComponent } from './pdf-assignment/pdf-assignment.component';
import { ChaptersComponent } from './chapters/chapters.component';
import { OnlineQustionsComponent } from './online-qustions/online-qustions.component';
import { UpComingEventsComponent } from './up-coming-events/up-coming-events.component';
import { DegreeComponent } from './subject/degree/degree.component';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import { SubjectAssignmentComponent } from './subject/subject-assignment/subject-assignment.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    UpperBarComponent,
    BottomBarComponent,
    HomeComponent,
    InfoComponent,
    QuestionsComponent,
    SettingComponent,
    StudentLoginComponent,
    TeacherComponent,
    BusComponent,
    DownloadsComponent,
    NoteboaredComponent,
    FeedsComponent,
    FooterComponent,
    CalenderComponent,
    LikesComponent,
    SubjectComponent,
    TeacherTimetableComponent,
    FeesComponent,
    ActivityComponent,
    UpcomingEventsComponent,
    PostsComponent,
    AssignmentComponent,
    SearchfilterPipe,
    PDFAssignmentComponent,
    ChaptersComponent,
    OnlineQustionsComponent,
    UpComingEventsComponent,
    DegreeComponent,
    SubjectAssignmentComponent,
  ],
  imports: [
    NgxPaginationModule,
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NgbModule,
    NgbPaginationModule,
    NgbAlertModule,
    FontAwesomeModule,
    NgbCollapseModule,
    MatSliderModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatCardModule,
    MatProgressBarModule,
    ReactiveFormsModule,
    MatInputModule,
    MatTabsModule,
    MatFormFieldModule,
    MatTableModule,
    MatSortModule,
    MatMenuModule,
    NavbarModule,
    Ng2OrderModule,
    MatSelectModule,
    MatDatepickerModule,
    MatProgressSpinnerModule,

    RouterModule.forRoot([
      {path: '',component:HomeComponent},
      {path: 'teacher',component:TeacherComponent},
      {path: 'bus',component:BusComponent},
      {path: 'downloads',component:DownloadsComponent},
      {path: 'feeds',component:FeedsComponent},
      {path: 'noteboared',component:NoteboaredComponent},
      {path: 'fees',component:FeesComponent},
      {path: 'setting',component:SettingComponent},
      {path: 'info',component:InfoComponent},
      {path: 'quetions',component:QuestionsComponent},
      {path: 'studentlogin',component:StudentLoginComponent},
      {path:'activity',component:ActivityComponent},
      {path:'assignment',component:AssignmentComponent},
      {path:'subject',component:SubjectComponent},
      {path:'online',component:PDFAssignmentComponent},
      {path:'attendance',component:OnlineQustionsComponent},
    ]),
    BrowserAnimationsModule,
    CommonModule,
    FormsModule,

    NgbModalModule,
    FlatpickrModule.forRoot(),
    CalendarModule.forRoot({
      provide: DateAdapter,
      useFactory: adapterFactory,
    }),
    MatPaginatorModule,


  ],
  providers: [teacher],
  bootstrap: [AppComponent]
})
export class AppModule { }
