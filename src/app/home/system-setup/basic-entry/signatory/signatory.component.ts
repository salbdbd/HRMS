import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-signatory',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./signatory.component.scss']
})
export class SignatoryComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Signatory";
  ngOnInit() {
  }

}
