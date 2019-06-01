import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-property-category',
  templateUrl: './property-category.component.html',
  styleUrls: [
    './property-category.component.scss',
]
})
export class PropertyCategoryComponent implements OnInit {
  loadingIndicator = true;
  rows = [];
  temp = [];
  selected = [];
  constructor() { }

  ngOnInit() {
  }

}
