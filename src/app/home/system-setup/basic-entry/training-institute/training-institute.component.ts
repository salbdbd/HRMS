import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-training-institute',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./training-institute.component.scss']
})
export class TrainingInstituteComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Training Institute";
  ngOnInit() {
    this.items = [];
  }

}
