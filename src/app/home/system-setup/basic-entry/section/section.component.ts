import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-section',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./section.component.scss']
})
export class SectionComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Section";
  ngOnInit() {
  }

}
