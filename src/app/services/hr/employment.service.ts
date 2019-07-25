import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class EmploymentService {

  constructor(private http:HttpClient) { }
  getEmployment(empCode:string,companyId){
    return this.http.get(environment.apiUrl+'/hr/employment/get/empCode/'+empCode+'/companyId/'+companyId);
  }
}
