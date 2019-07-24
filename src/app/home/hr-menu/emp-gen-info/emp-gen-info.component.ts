import { BasicEntry } from './../../../models/system-setup/basic-entry.model';
import { NgbDateCustomParserFormatter } from './../../../shared/dateformat';
import { EmpGenInfo } from './../../../models/hr/emp-gen-info.model';
import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../../services/hr/employee.service';
import { EmpFamilyInfo } from '../../../models/hr/emp-family-info.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-emp-gen-info',
  templateUrl: './emp-gen-info.component.html',
  styleUrls: ['./emp-gen-info.component.scss']
})
export class EmpGenInfoComponent implements OnInit {

  title="";
  empCode:string;
  empName:string;
  allSuffix:BasicEntry[] = [];
  allGender:BasicEntry[] = [];
  allBloodGroup:BasicEntry[] = [];
  allReligion:BasicEntry[]=[];
  allNationality:BasicEntry[]=[];
  allOccupation:BasicEntry[]=[];

  empGenInfo:EmpGenInfo = new EmpGenInfo();
  empFamilyMember:EmpFamilyInfo = new EmpFamilyInfo();
  empFamilyInfo:EmpFamilyInfo[] = [];
  constructor(private empService:EmployeeService, private dateFormat:NgbDateCustomParserFormatter, private toastr:ToastrService) { }
  ngOnInit() {

  }

  getEmpGenInfo(empCode:string){
    if(empCode==null || empCode==''){
      this.toastr.error('Please! Enter Employee Id', 'Not found');
      return ;
    }
    let compId = 1; 
    let gradeVal = 4;
    this.empService.getGenInfo(gradeVal, compId,empCode).subscribe((response:any)=>{
      if(response.status){
        this.empGenInfo = response.result as EmpGenInfo;
        this.empCode = this.empGenInfo.empCode;
        this.empName = this.empGenInfo.empName;
        this.empGenInfo.dobNgb = this.dateFormat.stringToNgbDate(this.empGenInfo.dob);
        this.empGenInfo.passportIssueDateNgb = this.dateFormat.stringToNgbDate(this.empGenInfo.passportIssueDate);
        this.empGenInfo.passportExpairedDateNgb = this.dateFormat.stringToNgbDate(this.empGenInfo.passportExpairedDate);
        
        this.getEmpFamilyInfo(empCode);
      }
      else{
        this.toastr.error(response.result, 'Error!');
      }
    });
  }
  getEmpFamilyInfo(empCode:string){
    let compId = 1;
    this.empService.getFamilyInfo(compId, empCode).subscribe((response:any)=>{
      if(response.status){
        console.log(response)
        this.empFamilyInfo = response.result as EmpFamilyInfo[];
      }else{
        //this.toastr.error(response.result, 'Failed');
      }
    })
  }

  getFamilyMember(personId:number){
    this.empService.getFamilyMember(personId).subscribe((response:any)=>{
      if(response.status){
        this.empFamilyMember = response.result as EmpFamilyInfo;
        console.log(this.empFamilyMember)
      }else{
        this.empFamilyMember = new EmpFamilyInfo();
        this.toastr.error(response.result, 'Error!')
      }
    })
  }

}

