import { Component, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'app-basic-entry',
  templateUrl: './basic-entry.component.html',
  styleUrls: [
    './basic-entry.component.scss',
  ]
})
export class BasicEntryComponent implements OnInit {

  title="Basic Entry";

  constructor() { }

  ngOnInit() {
  }



}
