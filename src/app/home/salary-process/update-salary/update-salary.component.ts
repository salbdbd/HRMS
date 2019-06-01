import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-update-salary',
  templateUrl: './update-salary.component.html',
  styleUrls: ['./update-salary.component.scss']
})
export class UpdateSalaryComponent extends Pagination implements OnInit {

  constructor() {
    super()
  }

  ngOnInit() {
    this.items = [];
    this.update
  }

}
