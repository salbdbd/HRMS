import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-training-type',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./training-type.component.scss']
})
export class TrainingTypeComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title=" Training Type";
  ngOnInit() {
  }

}
