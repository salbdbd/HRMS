import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class BasicEntryService {

  constructor(private http:HttpClient) { }
  getBank(){
    return this.http.get(environment.apiUrl+'setup/basic/bank/get');
  }
  getDepartment(){
    return this.http.get(environment.apiUrl+'setup/basic/department/get');
  }
  getDepartmentGL(){
    return this.http.get(environment.apiUrl+'setup/basic/departmentgl/get');
  }
  getSection(){
    return this.http.get(environment.apiUrl+'setup/basic/section/get');
  }
  getLocation(){
    return this.http.get(environment.apiUrl+'setup/basic/Location/get');
  }
  getCountry(){
    return this.http.get(environment.apiUrl+'setup/basic/country/get');
  }
  getNationality(){
    return this.http.get(environment.apiUrl+'setup/basic/nationality/get');
  }
  getGender(){
    return this.http.get(environment.apiUrl+'setup/basic/gender/get');
  }
  getReligion(){
    return this.http.get(environment.apiUrl+'setup/basic/religion/get');
  }
  getBlood(){
    return this.http.get(environment.apiUrl+'setup/basic/blood/get');
  }
  getEducation(){
    return this.http.get(environment.apiUrl+'setup/basic/education/get');
  }
  getEduBoard(){
    return this.http.get(environment.apiUrl+'setup/basic/edu/board/get');
  }
  getInstitute(){
    return this.http.get(environment.apiUrl+'setup/basic/institute/get');
  }
  getResult(){
    return this.http.get(environment.apiUrl+'setup/basic/result/get');
  }
  getTrainingType(){
    return this.http.get(environment.apiUrl+'setup/basic/training/type/get');
  }
  getTrainingCountry(){
    return this.http.get(environment.apiUrl+'setup/basic/training/country/get');
  }
  getTrainingInstitute(){
    return this.http.get(environment.apiUrl+'setup/basic/training/institute/get');
  }
  getTrainingNature(){
    return this.http.get(environment.apiUrl+'setup/basic/training/nature/get');
  }
  getTrainingSponsorBy(){
    return this.http.get(environment.apiUrl+'setup/basic/training/sponsor/get');
  }
  getProject(){
    return this.http.get(environment.apiUrl+'setup/basic/project/get');
  }
  getOccupation(){
    return this.http.get(environment.apiUrl+'setup/basic/occupation/get');
  }
  getExperienceType(){
    return this.http.get(environment.apiUrl+'setup/basic/experience/type/get');
  }
  getPunishment(){
    return this.http.get(environment.apiUrl+'setup/basic/punishment/get');
  }
  getBranch(){
    return this.http.get(environment.apiUrl+'setup/basic/branch/get');
  }
  getUnit(){
    return this.http.get(environment.apiUrl+'setup/basic/unit/get');
  }
  getSignatory(){
    return this.http.get(environment.apiUrl+'setup/basic/signatory/get');
  }
  getMisconduct(){
    return this.http.get(environment.apiUrl+'setup/basic/misconduct/get');
  }
  getPrefix(){
    return this.http.get(environment.apiUrl+'setup/basic/prefix/get');
  }
  getSuffix(){
    return this.http.get(environment.apiUrl+'setup/basic/suffix/get');
  }
  getPublicationType(){
    return this.http.get(environment.apiUrl+'setup/basic/publication/type/get');
  }
}
