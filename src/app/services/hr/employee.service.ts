import { EmpGenInfo } from './../../models/hr/emp-gen-info.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http:HttpClient) {}

  saveOrUpdateEmpGenInfo(empGenInfo:EmpGenInfo){
    return this.http.post(environment.apiUrl+'/employee/genInfo/save', empGenInfo);
  }
  getGenInfo(gradeVal:number, compId:number, empCode:string):any{
    return this.http.get(environment.apiUrl+'/employee/genInfo/get/gradeVal/'+gradeVal+'/compId/'+compId+'/empCode/'+empCode);
  }
  getFamilyInfo(companyId:number, empCode:string){
    return this.http.get(environment.apiUrl+'/employee/familyInfo/get/compId/'+companyId+'/empCode/'+empCode);
  }
  getFamilyMember(personId:number){
    return this.http.get(environment.apiUrl+'/employee/familyMember/get/personId/'+personId);
  }
}
