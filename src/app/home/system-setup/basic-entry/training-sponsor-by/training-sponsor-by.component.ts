import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-training-sponsor-by',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./training-sponsor-by.component.scss']
})
export class TrainingSponsorByComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Training Sponsor By";
  ngOnInit() {
    this.items = [];
  }

}
