import { AccountService } from './../../_services';
import { account } from './../../_models/account';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-student-header',
  templateUrl: './student-header.component.html',
  styleUrls: ['./student-header.component.css']
})
export class StudentHeaderComponent{
  account: account;
    constructor(private accountService: AccountService) { 
        this.accountService.account.subscribe(x => this.account = x);
    }
    logout() {
      this.accountService.logout();
    }
}
