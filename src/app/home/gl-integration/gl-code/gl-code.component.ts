import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-gl-code',
  templateUrl: './gl-code.component.html',
  styleUrls: ['./gl-code.component.scss']
})
export class GlCodeComponent extends Pagination implements OnInit {

  constructor() { 
    super()
  }

  ngOnInit() {
    this.items=[];
    this.update
  }
}
