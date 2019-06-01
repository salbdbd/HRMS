
import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-country',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./country.component.scss']
})
export class CountryComponent  extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Country";
  ngOnInit() {
  }

}
