import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-suffix',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./suffix.component.scss']
})
export class SuffixComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Suffix";
  ngOnInit() {
  }

}
