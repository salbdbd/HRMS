import { GratuityYearSetupComponent } from './../../settlement/gratuity-year-setup/gratuity-year-setup.component';
import { Component, OnInit } from '@angular/core';
import { EmpGenInfo } from '../../../models/hr/emp-gen-info.model';
import { EmployeeService } from '../../../services/hr/employee.service';
import { Employment } from '../../../models/hr/employment.model';
import { EmploymentService } from '../../../services/hr/employment.service';
import { NgbDateParserFormatter } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-vehicle-tax-assagin',
  templateUrl: './vehicle-tax-assagin.component.html',
  styleUrls: ['./vehicle-tax-assagin.component.scss']
})
export class VehicleTaxAssaginComponent implements OnInit {

  employmentInfo:Employment=new Employment();

  constructor(private employmentService:EmploymentService, private dateformat:NgbDateParserFormatter) { }
  ngOnInit() {
  }

  getEmployment(empCode:string){
    this.employmentService.getEmployment(empCode,1).subscribe((response:any)=>{
      if(response.status){
        this.employmentInfo  = response.result as Employment;
        this.employmentInfo.joinDateNgb=this.dateformat.parse(this.employmentInfo.joinDate);
      }
    })
  }

}
