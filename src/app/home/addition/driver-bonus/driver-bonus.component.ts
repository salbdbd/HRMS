import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-driver-bonus',
  templateUrl: './driver-bonus.component.html',
  styleUrls: ['./driver-bonus.component.scss']
})
export class DriverBonusComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Driver Festival Bonus Info";
  ngOnInit() {
    this.items = [];
    this.update();
  }

}
