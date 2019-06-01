import { Component, OnInit } from '@angular/core';
import { trigger, useAnimation, transition, animate } from '@angular/animations';
import { show, hide } from '../../../shared/animations';

@Component({
  selector: 'app-web-portal-page-access',
  templateUrl: './web-portal-page-access.component.html',
  styleUrls: ['./web-portal-page-access.component.scss'],
  animations:[
    trigger('listAnimation', [
      transition(':enter', [
        useAnimation(show, {
          params: {
            duration: '2000ms'
          }
        }),
        animate(200),
      ]),
      transition(':leave', [
        useAnimation(hide, {
          params: {
            duration: '2000ms'
          }
        }),
        animate(200)
      ])
    ])
  ]
})
export class WebPortalPageAccessComponent implements OnInit {

  constructor() { }
  title="Web Portal Page Access";
  isCollapse:boolean=false;
  ngOnInit() {
  }

  toggle(){
    this.isCollapse = !this.isCollapse;
  }

}
