import { EmpGenInfo } from './../../models/hr/emp-gen-info.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http:HttpClient) {}

  getGenInfo(empCode:string, compId:number):any{
    return this.http.get(environment.apiUrl+'/employee/genInfo/get/empCode/'+empCode+'/compId/'+compId);
  }
}
