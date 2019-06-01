import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-designation',
  templateUrl:'../basic-entry.component.html',
  styleUrls: ['./designation.component.scss']
})
export class DesignationComponent  extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Designation";
  ngOnInit() {
  }

}
