import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-emp-salary-structure',
  templateUrl: './emp-salary-structure.component.html',
  styleUrls: ['./emp-salary-structure.component.scss']
})
export class EmpSalaryStructureComponent extends Pagination implements OnInit {

  constructor() { 
    super()
  }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
