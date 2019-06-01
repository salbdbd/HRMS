import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-process-import',
  templateUrl: './process-import.component.html',
  styleUrls: ['./process-import.component.scss']
})
export class ProcessImportComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Process Employee Imported Salary";
  ngOnInit() {
    this.items = [];
    this.update();
  }

}
