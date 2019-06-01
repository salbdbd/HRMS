import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-training-nature',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./training-nature.component.scss']
})
export class TrainingNatureComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Training Nature";
  ngOnInit() {
  }

}
