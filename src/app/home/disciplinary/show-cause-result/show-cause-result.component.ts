import { Title } from '@angular/platform-browser';
import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-show-cause-result',
  templateUrl: './show-cause-result.component.html',
  styleUrls: ['./show-cause-result.component.scss']
})
export class ShowCauseResultComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Show Cause Result";
  ngOnInit () {
    this.items=[];
    this.update();
  }

}
