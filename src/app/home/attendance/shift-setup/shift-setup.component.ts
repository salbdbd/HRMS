import { Title } from '@angular/platform-browser';
import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-shift-setup',
  templateUrl: './shift-setup.component.html',
  styleUrls: ['./shift-setup.component.scss']
})
export class ShiftSetupComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Shift Setup";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
