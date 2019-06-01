import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-create-user',
  templateUrl: './create-user.component.html',
  styleUrls: ['./create-user.component.scss']
})
export class CreateUserComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Create User";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
