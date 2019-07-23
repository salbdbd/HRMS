import { NgbDateCustomParserFormatter } from './../../../shared/dateformat';
import { EmpGenInfo } from './../../../models/hr/emp-gen-info.model';
import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../../services/hr/employee.service';

@Component({
  selector: 'app-emp-gen-info',
  templateUrl: './emp-gen-info.component.html',
  styleUrls: ['./emp-gen-info.component.scss']
})
export class EmpGenInfoComponent implements OnInit {

  title="";
  empCode:string;
  empName:string;
  empGenInfo:EmpGenInfo = new EmpGenInfo();
  constructor(private empService:EmployeeService, private dateFormat:NgbDateCustomParserFormatter) { }
  ngOnInit() {
  }

  getEmpGenInfo(empCode:string){
    let compId = 1;
    this.empService.getGenInfo(empCode, compId).subscribe((response:any)=>{
      if(response.status){
        this.empGenInfo = response.result as EmpGenInfo;
        this.empCode = this.empGenInfo.empCode;
        this.empName = this.empGenInfo.empName;
        this.empGenInfo.dobNgb = this.dateFormat.stringToNgbDate(this.empGenInfo.dob);
        this.empGenInfo.passportIssueDateNgb = this.dateFormat.stringToNgbDate(this.empGenInfo.passportIssueDate);
        this.empGenInfo.passportExpairedDateNgb = this.dateFormat.stringToNgbDate(this.empGenInfo.passportExpairedDate);
        this.empGenInfo.age = this.getAge(new Date(this.empGenInfo.dob));

      }
    });
  }

  getAge(birthDate:Date):string{
    let millSecond:number = Date.now() - +(new Date(this.empGenInfo.dob));
    console.log(millSecond)
    let aDay = 1000*60*60*24;
    let aMonth = aDay*30;
    let aYear = aMonth*12;
    
    let years = Math.floor(millSecond/aYear);
    let month = Math.floor((millSecond/aMonth)%(years*12));
    let days = Math.floor((millSecond/aDay)%(month*30));
    return years+' years, '+month+' month,'+days+' days';
  }

}

