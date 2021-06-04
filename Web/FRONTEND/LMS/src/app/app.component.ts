import { Role } from './_models/role';
import { Component } from '@angular/core';

import { AccountService } from './_services';
import { account } from './_models';

@Component({ selector: 'app', templateUrl: 'app.component.html' })
export class AppComponent {
    Role = Role;
    account: account;

    constructor(private accountService: AccountService) {
        this.accountService.account.subscribe(x => this.account = x);
    }

    logout() {
        this.accountService.logout();
    }
}