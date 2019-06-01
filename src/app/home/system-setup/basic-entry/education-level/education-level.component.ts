import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-education-level',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./education-level.component.scss']
})
export class EducationLevelComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Education Level";
  ngOnInit() {
    this.tempItems = [1, 2, 3]
  }

}
