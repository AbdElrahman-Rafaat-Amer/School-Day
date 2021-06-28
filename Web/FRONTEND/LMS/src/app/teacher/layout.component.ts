import { AccountService } from '@app/_services';
import { Component, OnInit } from '@angular/core';
import { account } from '@app/_models';

@Component({
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent implements OnInit {

  ngOnInit(): void {
  }

  account: account;
  constructor(private accountService: AccountService) {
    this.accountService.account.subscribe(x => this.account = x);
  }

  logout() {
      this.accountService.logout();
  }

}
