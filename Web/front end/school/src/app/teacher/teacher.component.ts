import { TeacherService } from './../Service/teacher/teacher.service';
import { Component, OnInit } from '@angular/core';
import { teacher } from '../classes/teacher';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-teacher',
  templateUrl: './teacher.component.html',
  styleUrls: ['./teacher.component.scss']
})
export class TeacherComponent{
  teachers$: any;
  teacher!: string | null;

  constructor(
    route:ActivatedRoute,
    _teacher:TeacherService
    )
    {

    this.teachers$=_teacher.getteacher();

    route.queryParamMap.subscribe(params =>{
      this.teacher =params.get('teacher');
    })
  }

}
