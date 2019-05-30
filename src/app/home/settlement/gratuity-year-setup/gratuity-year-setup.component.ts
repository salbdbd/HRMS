import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-gratuity-year-setup',
  templateUrl: './gratuity-year-setup.component.html',
  styleUrls: ['./gratuity-year-setup.component.scss']
})
export class GratuityYearSetupComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Gratuity Year Setup";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
