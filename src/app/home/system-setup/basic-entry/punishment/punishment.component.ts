import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-punishment',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./punishment.component.scss']
})
export class PunishmentComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Punishment";
  ngOnInit() {
  }

}
