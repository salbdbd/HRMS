import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-gratuity-setup',
  templateUrl: './gratuity-setup.component.html',
  styleUrls: ['./gratuity-setup.component.scss']
})
export class GratuitySetupComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Gratuity Setup";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
