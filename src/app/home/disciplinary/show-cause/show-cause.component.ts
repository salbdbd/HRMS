import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-show-cause',
  templateUrl: './show-cause.component.html',
  styleUrls: ['./show-cause.component.scss']
})
export class ShowCauseComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Show Cause Info";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
