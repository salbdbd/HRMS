import { Component, OnInit } from '@angular/core';
import { trigger, transition, useAnimation, animate, style } from '@angular/animations';
import { fadeInAnimation, bounceOutLeftAnimation, show, hide } from '../../../shared/animations';

@Component({
  selector: 'app-assign-page-access',
  templateUrl: './assign-page-access.component.html',
  styleUrls: ['./assign-page-access.component.scss'],
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
export class AssignPageAccessComponent implements OnInit {

  constructor() { }
  isCollapse:boolean;
  title="Assign Page Access";
  ngOnInit() {
    this.isCollapse=false;
  }
  toggle(){
    this.isCollapse = !this.isCollapse;
  }

}
