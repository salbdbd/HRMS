import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-project',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./project.component.scss']
})
export class ProjectComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Project";
  ngOnInit() {
  }

}
