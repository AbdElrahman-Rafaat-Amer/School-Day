import { account, Role } from '@app/_models';
import { Component } from '@angular/core';

import { AccountService } from '@app/_services';

@Component({ templateUrl: 'home.component.html' })
export class HomeComponent {

    accountInfo = this.accountService.accountValue;
    isStudent: boolean = false;
    isTeacher: boolean = false;
    isAdmin: boolean = false;

    Rolex : string;
    constructor(private accountService: AccountService) { 
        this.Rolex = this.accountInfo.role.toString();
        this.isStudent = this.accountInfo.role.toString() == "Student";
        this.isTeacher = this.accountInfo.role.toString() == "Teacher";
        this.isAdmin   = this.accountInfo.role.toString() == "Admin";
    }

   
}