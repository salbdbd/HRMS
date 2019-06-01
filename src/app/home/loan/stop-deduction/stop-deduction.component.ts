import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-stop-deduction',
  templateUrl: './stop-deduction.component.html',
  styleUrls: ['./stop-deduction.component.scss']
})
export class StopDeductionComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Loan Deduction Stop Information";
  ngOnInit() {
    this.items = [];
    this.update();
  }

}
