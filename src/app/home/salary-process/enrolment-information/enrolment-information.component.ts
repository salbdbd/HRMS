import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-enrolment-information',
  templateUrl: './enrolment-information.component.html',
  styleUrls: ['./enrolment-information.component.scss']
})
export class EnrolmentInformationComponent extends Pagination implements OnInit {

  constructor() {
    super()
   }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
