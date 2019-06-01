import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-payscale-grade',
  templateUrl: './payscale-grade.component.html',
  styleUrls: ['./payscale-grade.component.scss']
})
export class PayscaleGradeComponent extends Pagination implements OnInit {

  constructor() {
    super()
   }
  

  ngOnInit() {
    this.items=[];
    this.update
  }


}
