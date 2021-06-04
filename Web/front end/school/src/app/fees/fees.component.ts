import { FeesServicesService } from './../Service/fees/fees-services.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-fees',
  templateUrl: './fees.component.html',
  styleUrls: ['./fees.component.scss']
})
export class FeesComponent implements OnInit {
fees$:any;
  constructor(private _fees:FeesServicesService) {
    this.fees$=_fees.getfees();
  }

  displayedColumns = ['Fees Group',
    'Fees Code',
    'Due Date',
    'Status',
    'Amount($)',
    'Payment ID',
    'Mode',
    'Date',
    'Discount($)',
    'Fine($)',
    'Paid($)',
    'Balance',
    'Payment'];


  index=['countery',
  'cases',
  'todayCases',
  'deaths',
  'todayDeaths',
  'recovered',
  'active',
  'critical',
  'casesPerOneMillion',
  'deathsPerOneMillion',
  'tests',
  'testsPerOneMillion'];

  // index=[
  //   'feesgroup',
  //   'feescode',
  //   'duedate',
  //   'status',
  //   'amount',
  //   'paymentid',
  //   'mode',
  //   'date',
  //   'discount',
  //   'fine',
  //   'paid',
  //   'balance',
  //   'payment'
  // ];


  ngOnInit(): void {

  }

}
