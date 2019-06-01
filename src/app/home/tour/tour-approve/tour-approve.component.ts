import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-tour-approve',
  templateUrl: './tour-approve.component.html',
  styleUrls: ['./tour-approve.component.scss']
})
export class TourApproveComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Tour Approve"
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
