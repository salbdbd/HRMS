import { NgbModal, NgbDateStruct, NgbDate } from '@ng-bootstrap/ng-bootstrap';
import { Component, OnInit } from '@angular/core';
import { AssetAddition } from '../../../models/Property/asset-addition.model';
import { PropertyCategory } from '../../../models/Property/property-category.model';
import { PropertyName } from '../../../models/Property/property-name.model';
import { PropertyService } from '../../../services/property.service';
import { ToastrService } from 'ngx-toastr';
import { Pagination } from '../../../shared/paginate';
import { DatePipe } from '@angular/common';
import { toDate } from '@angular/common/src/i18n/format_date';

@Component({
  selector: 'app-asset-addition',
  templateUrl: './asset-addition.component.html',
  styleUrls: ['./asset-addition.component.scss']
})
export class AssetAdditionComponent  extends Pagination implements OnInit {
  assetaddition:AssetAddition[]=[];
  categories: PropertyCategory[] = [];
  assetname: PropertyName[];
  asset:AssetAddition=new AssetAddition();
  deleteId:number;
  btnStatus:string="Save";
  constructor( private propService:PropertyService,private toasterservice:ToastrService,private modalService:NgbModal ) { 
    super();
  }

  ngOnInit() {
    this.GetAllAsset();
    this.GetCatagory();
  }
  Save(){
    this.asset.purchesate = this.dateToString(this.asset.purchesDateNg);
    this.asset.warrentydate = this.dateToString(this.asset.warrentyDateNg);
    this.propService.assetsave(this.asset).subscribe((result:any)=>{
      if(result){
       this.toasterservice.success("Successfully Save","Save");
       this.Reset();
      }
    })
  }
  Update(){
    this.propService.assetsave(this.asset).subscribe((result:any)=>{
      if(result){
       this.toasterservice.success("Successfully Update","Update");
       this.Reset();
       this.btnStatus="Save";
      }
    })
  }
  GetAllAsset(){
   this.propService.getAllAsset().subscribe((result:any)=>{
    
   this.items=result as AssetAddition[]; //for pagination
   this.update(); //for pagination
   console.log(this.items)
   })
  }
  GetAssetByCategory(id:number){
    console.log(id);
  this.propService.getAllAssetByCategory(id).subscribe((result:any)=>{
    this.assetname=result as PropertyName[];
    console.log( this.assetname);
  })
  }
  GetAssetById(id:number){
  this.propService.getAssetById(id).subscribe((result:any)=>{
    this.asset=result as AssetAddition;
    this.asset.purchesDateNg = this.stringToNgbDate(this.asset.purchesate);
    this.asset.warrentyDateNg = this.stringToNgbDate(this.asset.warrentydate);
    console.log(this.asset)
    this.btnStatus="Update";
  })
  }
  AssetDelete(id:number,modal:any){
  this.modalService.open(modal);
  this.deleteId=id;
  }
  Confirm(){
    this.propService.deleteAsset(this.deleteId).subscribe((result:any)=>{
      if(result){
        this.toasterservice.warning("Successfully Delete");
        this.GetAllAsset();
        this.modalService.dismissAll();
      }
    })
  }
  Cancel(){
   this.modalService.dismissAll();
  }
  GetCatagory(){
    this.propService.getAllCategory().subscribe((result:any)=>{
      this.categories=result as PropertyCategory[];
    })
  }
  GetProperty(){
    this.propService.getAllName().subscribe((result:any)=>{
      this.assetname=result as PropertyName[];
    })
  }
  Reset(){
    //this.asset = new AssetAddition();
    this.asset.id=0;
    this.asset.assetCatagoryId=0;
    this.asset.assetID=0;
    this.asset.model="";
    this.asset.serial="";
    this.asset.purchesPrice=0;
    this.asset.confiruration="";
    this.asset.warrentyType="";
    this.asset.purchesate="";
    this.asset.warrentydate="";
    this.asset.note="";
    this.asset.isActive=0;
    this.asset.companyId=0;
    this.btnStatus="Save";
  }

  dateToString(ngbDate:NgbDateStruct):string{
    return ngbDate.year+'/'+ngbDate.month+'/'+ngbDate.day;
  }
  stringToNgbDate(date:string):NgbDateStruct{
    let myDate = new Date(date);
    let ngbDate:NgbDateStruct = {
      year: myDate.getFullYear(),
      month: myDate.getMonth()+1,
      day: myDate.getDate()
    };
    return ngbDate;
  }

}
