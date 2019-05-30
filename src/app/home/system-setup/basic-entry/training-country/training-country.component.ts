import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-training-country',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./training-country.component.scss']
})
export class TrainingCountryComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Training Country";
  ngOnInit() {
  }

}
