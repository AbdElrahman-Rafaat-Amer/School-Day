import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home';
import { AuthGuard } from './_helpers';
import { Role } from './_models';

const accountModule = () => import('./account/account.module').then(x => x.AccountModule);
const adminModule = () => import('./admin/admin.module').then(x => x.AdminModule);
const profileModule = () => import('./profile/profile.module').then(x => x.ProfileModule);
const studentModule = () => import('./student/student.module').then(x => x.StudentModule);
const teacherModule = () => import('./teacher/teacher.module').then(x => x.TeacherModule);
//const chatModule = () => import('./chat/chat.module').then(x => x.ChatModule);

const routes: Routes = [
    { path: '', component: HomeComponent, canActivate: [AuthGuard] },
    { path: 'account', loadChildren: accountModule },
    { path: 'profile', loadChildren: profileModule, canActivate: [AuthGuard] },
    { path: 'admin', loadChildren: adminModule, canActivate: [AuthGuard], data: { roles: Role[Role.Admin] } },
    { path: 'student', loadChildren: studentModule, canActivate: [AuthGuard], data: { roles: Role[Role.Student] } },
    { path: 'teacher', loadChildren: teacherModule, canActivate: [AuthGuard], data: { roles: Role[Role.Teacher] } },
    { path: '**', redirectTo: '' }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
