import { Component, OnInit, ViewChild } from '@angular/core';
import { Pagination } from '../../../shared/paginate';
import { DatatableComponent } from '@swimlane/ngx-datatable';
import { AppService } from '../../../app.service';

@Component({
  selector: 'app-weekend-setup',
  templateUrl: './weekend-setup.component.html',
  styleUrls: [
    './weekend-setup.component.scss',
    '../../../../../node_modules/@swimlane/ngx-datatable/release/index.css',
    '../../../../../node_modules/@swimlane/ngx-datatable/release/assets/icons.css',
    '../../../../vendor/libs/ngx-datatable/ngx-datatable.scss'
  ]
})
export class WeekendSetupComponent extends Pagination implements OnInit {

title="Weekend Setup";
  ngOnInit() {
    this.items=[1,2,3];
    this.update();
  }

  constructor(private appService: AppService) {
    super();
  }

}
