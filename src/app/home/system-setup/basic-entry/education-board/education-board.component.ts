import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-education-board',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./education-board.component.scss']
})
export class EducationBoardComponent  extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Education Board";
  ngOnInit() {
  }

}
