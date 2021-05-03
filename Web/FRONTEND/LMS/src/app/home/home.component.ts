import { account } from '@app/_models';
import { Component } from '@angular/core';

import { AccountService } from '@app/_services';

@Component({ templateUrl: 'home.component.html' })
export class HomeComponent {
    constructor(private accountService: AccountService) { }

    accountInfo = this.accountService.accountValue;
   
}