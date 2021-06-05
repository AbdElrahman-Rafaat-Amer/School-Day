import { AccountService } from './../_services/account.service';
import { Component, OnInit } from '@angular/core';
import { account } from '@app/_models';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent{

  account: account;
  constructor(private accountService: AccountService) {
    this.accountService.account.subscribe(x => this.account = x);
  }

  logout() {
      this.accountService.logout();
  }

}
