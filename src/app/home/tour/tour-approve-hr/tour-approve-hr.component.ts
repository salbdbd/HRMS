import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-tour-approve-hr',
  templateUrl: './tour-approve-hr.component.html',
  styleUrls: ['./tour-approve-hr.component.scss']
})
export class TourApproveHrComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Tour Approve by HR";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
