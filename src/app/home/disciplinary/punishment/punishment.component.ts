import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-punishment',
  templateUrl: './punishment.component.html',
  styleUrls: ['./punishment.component.scss']
})
export class PunishmentComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Employee Punishment";
  ngOnInit() {
    this.items = [];
    this.update();
  }

}
