import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-bank-branch',
  templateUrl: './bank-branch.component.html',
  styleUrls: ['./bank-branch.component.scss']
})
export class BankBranchComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Bank Branch";
  ngOnInit() {
    this.items = [];
  }

}
