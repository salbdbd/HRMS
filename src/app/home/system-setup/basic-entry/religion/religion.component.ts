import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-religion',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./religion.component.scss']
})
export class ReligionComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Religion";
  ngOnInit() {
  }

}
