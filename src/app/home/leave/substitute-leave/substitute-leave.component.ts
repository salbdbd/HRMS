import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-substitute-leave',
  templateUrl: './substitute-leave.component.html',
  styleUrls: ['./substitute-leave.component.scss']
})
export class SubstituteLeaveComponent extends Pagination implements OnInit {

  constructor() {
    super()
   }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
