import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-experience-type',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./experience-type.component.scss']
})
export class ExperienceTypeComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Experience Type";
  ngOnInit() {
  }

}
