import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-extra-salary',
  templateUrl: './extra-salary.component.html',
  styleUrls: ['./extra-salary.component.scss']
})
export class ExtraSalaryComponent extends Pagination implements OnInit {

  constructor() { 
    super()
  }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
