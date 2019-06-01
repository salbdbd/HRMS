import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-allowance-add-deduct',
  templateUrl: './allowance-add-deduct.component.html',
  styleUrls: ['./allowance-add-deduct.component.scss']
})
export class AllowanceAddDeductComponent extends Pagination implements OnInit {

  constructor() {
    super()
   }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
