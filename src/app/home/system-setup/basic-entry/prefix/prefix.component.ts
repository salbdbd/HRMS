import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-prefix',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./prefix.component.scss']
})
export class PrefixComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Prefix";
  ngOnInit() {
  }

}
