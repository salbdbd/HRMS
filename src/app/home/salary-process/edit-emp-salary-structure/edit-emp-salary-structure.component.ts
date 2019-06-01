import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-edit-emp-salary-structure',
  templateUrl: './edit-emp-salary-structure.component.html',
  styleUrls: ['./edit-emp-salary-structure.component.scss']
})
export class EditEmpSalaryStructureComponent extends Pagination implements OnInit {

  constructor() { 
    super()
  }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
