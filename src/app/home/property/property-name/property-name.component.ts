import { ToastrService } from 'ngx-toastr';
import { PropertyName } from './../../../models/property-name.model';
import { PropertyService } from './../../../services/property.service';
import { PropertyCategory } from './../../../models/property-category.model';
import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-property-name',
  templateUrl: './property-name.component.html',
  styleUrls: ['./property-name.component.scss']
})
export class PropertyNameComponent extends Pagination implements OnInit {
  categories: PropertyCategory[] = [];
  properties: PropertyName[] = [];
  property: PropertyName = new PropertyName();
  btnStatus="Save";
  deleteId :number;
  constructor(private propService: PropertyService,private toastrService:ToastrService, private modalService:NgbModal) {
    super();
   }

  ngOnInit() {
    
    this.getAllCatagories();
    this.getProperties();
    this.searchKeys =['assetName']
  }
  getAllCatagories() {
    this.propService.getAllCategory().subscribe((result: any) => {
      this.categories = result as PropertyCategory[];
    })
  }
  getProperties(){
    this.propService.getAllName().subscribe((result:any)=>{
    this.properties=result as PropertyName[];
    this.items=this.properties;
    this.update();
    })
  }
  save(){
   this.propService.saveName(this.property).subscribe((result:any)=>{
    if(result){
      this.toastrService.success("Successfully saved","Save");
      this.getProperties();
      this.reset();
    }
   })
  }
  
  getById(id:number){
    this.propService.getNameById(id).subscribe((result:any)=>{
     this.property=result as PropertyName;
     this.btnStatus="Update";
     console.log(this.property);
    })
  }
  propertyUpdate(){
    this.propService.updateName(this.property).subscribe((result:any)=>{
      if(result){
        this.toastrService.success("Successfully Updated","Update");
        this.btnStatus="Save";
        this.getProperties();
        this.reset();
      }
    })
  }
  delete(id:number,modal:any){
    this.modalService.open(modal);
    this.deleteId = id;
   }
   confirm(){
    this.propService.deleteName(this.deleteId).subscribe((result:any)=>{
      if(result){
       this.toastrService.warning("Successfully Delete");
       this.getProperties();
       this.modalService.dismissAll();
      }
     })
   }
   cancel(){
     this.modalService.dismissAll();
   }
   reset(){
     this.property.aCateoryId=0;
     this.property.assetName="";
     this.property.companyId=0;
     this.property.description="";
     this.property.id=0;
   }
}
