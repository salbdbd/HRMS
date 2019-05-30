import { Title } from '@angular/platform-browser';
import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-lwp-deduct',
  templateUrl: './lwp-deduct.component.html',
  styleUrls: ['./lwp-deduct.component.scss']
})
export class LwpDeductComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Employee LWP Deduct";
  ngOnInit() {
    this.items = [];
    this.update();
  }

}
