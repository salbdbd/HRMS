import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-emp-leave-opening-balance',
  templateUrl: './emp-leave-opening-balance.component.html',
  styleUrls: ['./emp-leave-opening-balance.component.scss']
})
export class EmpLeaveOpeningBalanceComponent extends Pagination implements OnInit {

  constructor() {
    super()
   }

  ngOnInit() {
    this.items=[1,3];
    this.update
  }

}
