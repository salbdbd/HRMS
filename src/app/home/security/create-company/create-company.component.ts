import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-create-company',
  templateUrl: './create-company.component.html',
  styleUrls: ['./create-company.component.scss']
})
export class CreateCompanyComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Create Company";
  previewMainLogo = "";
  mainLogo;
  showMainLogo:boolean=false;
  
  previewReportLogo = "";
  reportLogo;
  showReportLogo:boolean=false;
  ngOnInit() {
    this.items=[];
    this.update();
  }
  
onFileSelected(files:FileList){
  this.showImage(files);
  this.getFiles(files);
  this.showMainLogo=true;
}
showImage(files:FileList){
 var reader = new FileReader();
 reader.onload = (event:any)=>{
   this.previewMainLogo = event.target.result;
 }
 reader.readAsDataURL(files.item(0));
}
getFiles(files) {
 var reader = new FileReader();
 reader.onload = this._handleReaderLoaded.bind(this);
 reader.readAsBinaryString(files[0]);
}
_handleReaderLoaded(readerEvt) {
 var binaryString = readerEvt.target.result;
 this.mainLogo = btoa(binaryString);  // Converting binary string data.
 console.log(this.mainLogo);
}
clearImg(){
this.mainLogo= null;
this.showMainLogo = false;
}

onFileSelected2(files:FileList){
  this.showImage2(files);
  this.getFiles2(files);
  this.showReportLogo=true;
}
showImage2(files:FileList){
 var reader = new FileReader();
 reader.onload = (event:any)=>{
   this.previewReportLogo = event.target.result;
 }
 reader.readAsDataURL(files.item(0));
}
getFiles2(files) {
 var reader = new FileReader();
 reader.onload = this._handleReaderLoaded2.bind(this);
 reader.readAsBinaryString(files[0]);
}
_handleReaderLoaded2(readerEvt) {
 var binaryString = readerEvt.target.result;
 this.reportLogo = btoa(binaryString);  // Converting binary string data.
 console.log(this.reportLogo);
}
clearImg2(){
this.reportLogo= null;
this.showReportLogo = false;
}

}
