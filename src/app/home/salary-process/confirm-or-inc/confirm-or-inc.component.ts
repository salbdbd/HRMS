import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-confirm-or-inc',
  templateUrl: './confirm-or-inc.component.html',
  styleUrls: ['./confirm-or-inc.component.scss']
})
export class ConfirmOrIncComponent extends Pagination implements OnInit {

  constructor() { 
    super()
  }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
