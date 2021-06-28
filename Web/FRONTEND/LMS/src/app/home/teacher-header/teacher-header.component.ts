import { AccountService } from '@app/_services';
import { account } from '@app/_models';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-teacher-header',
  templateUrl: './teacher-header.component.html',
  styleUrls: ['./teacher-header.component.css']
})
export class TeacherHeaderComponent implements OnInit {

  account: account;
    constructor(private accountService: AccountService) { 
        this.accountService.account.subscribe(x => this.account = x);
    }
    logout() {
      this.accountService.logout();
    }

  ngOnInit(): void {
  }

}
