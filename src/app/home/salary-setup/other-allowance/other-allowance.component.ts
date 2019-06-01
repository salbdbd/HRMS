import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-other-allowance',
  templateUrl: './other-allowance.component.html',
  styleUrls: ['./other-allowance.component.scss']
})
export class OtherAllowanceComponent extends Pagination implements OnInit {

  constructor() { 
    super()
  }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
