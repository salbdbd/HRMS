import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-misconduct',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./misconduct.component.scss']
})
export class MisconductComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Misconduct";
  ngOnInit() {
  }

}
