import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-setup',
  templateUrl: './setup.component.html',
  styleUrls: ['./setup.component.scss']
})
export class SetupComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Shift Allowance Setup";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
