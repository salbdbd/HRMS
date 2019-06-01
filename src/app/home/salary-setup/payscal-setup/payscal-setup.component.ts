import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-payscal-setup',
  templateUrl: './payscal-setup.component.html',
  styleUrls: ['./payscal-setup.component.scss']
})
export class PayscalSetupComponent extends Pagination implements OnInit {

  constructor() { 
    super()
  }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
