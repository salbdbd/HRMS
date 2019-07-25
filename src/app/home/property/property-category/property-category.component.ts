import { Pagination } from './../../../shared/paginate';
import { ToastrService } from 'ngx-toastr';
import { PropertyService } from './../../../services/property.service';
import { PropertyCategory } from '../../../models/Property/property-category.model';
import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-property-category',
  templateUrl: './property-category.component.html',
  styleUrls: [
    './property-category.component.scss',
  ]
})
export class PropertyCategoryComponent extends Pagination implements OnInit {

  btnStatus = "Save";
  propCategory: PropertyCategory = new PropertyCategory();
  allCategories: PropertyCategory[] = [];
  deleteId :number;
  constructor(private propertyService: PropertyService, private toasterService: ToastrService, private modalService:NgbModal) {
    super();
  }

  ngOnInit() {
    this.searchKeys = ['categoryName'];
    this.perPage = 10;
    this.getAll();
  }

  savePropCategory() {
    this.propertyService.saveCategory(this.propCategory).subscribe((response: any) => {
      if (response.status) {
        this.toasterService.success(response.result, "Saved!");
        this.getAll();
        this.reset();
      }
      else{
        this.toasterService.error(response.result,"Failed");
      }
    })
  }

  getAll() {
    this.propertyService.getAllCategory().subscribe((result: any) => {
      this.allCategories = result as PropertyCategory[];
      this.items = this.allCategories;
      this.update();
    })
  }
  getById(id: number) {
    this.propertyService.getCategoryById(id).subscribe((result: any) => {
      this.propCategory = result as PropertyCategory;
      this.btnStatus = "Update"
    })
  }

  updateCategory() {
    this.propertyService.updateCategory(this.propCategory).subscribe((response: any) => {
      if (response.status) {
        this.toasterService.success(response.result, "Update");
        this.getAll();
        this.reset();
        this.btnStatus = "Save"
      }
      else{
        this.toasterService.error(response.result,"Failed");
      }
    })
  }
  deleteCategory(id:number, modal:any){
    this.modalService.open(modal);
    this.deleteId = id;
  }
  confirm() {
    this.propertyService.deleteCategory(this.deleteId).subscribe((result: any) => {
      if (result) {
        this.toasterService.warning("Successfully Delete");
        let index = this.allCategories.findIndex(c => c.id == this.deleteId);
        this.allCategories.splice(index, 1);
        this.getAll();
        this.deleteId=0;
        this.modalService.dismissAll();
      }
    })
  }
  reset() {
    this.propCategory.categoryName = "";
    this.propCategory.description = "";
    this.propCategory.id = 0;
  }

  cancel(){
    this.modalService.dismissAll();
  }
  
}
