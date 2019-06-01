import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-publication-type',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./publication-type.component.scss']
})
export class PublicationTypeComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Publication Type";
  ngOnInit() {
  }

}
