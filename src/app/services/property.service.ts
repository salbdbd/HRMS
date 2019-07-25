import { PropertyName } from '../models/Property/property-name.model';
import { PropertyCategory } from '../models/Property/property-category.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.prod';
import { AssetAddition } from '../models/Property/asset-addition.model';

@Injectable({
  providedIn: 'root'
})
export class PropertyService {

  constructor(private http:HttpClient) { }
//property-Catagory

  saveCategory(propertyCat:PropertyCategory){
    return this.http.post(environment.apiUrl+'/property/category/save',propertyCat);
  }
  getAllCategory(){
    return this.http.get(environment.apiUrl+'/property/category/getall');
  }
  getCategoryById(id:number){
    return this.http.get(environment.apiUrl+'/property/category/getbyid/'+id);
  }
  updateCategory(propertyCat:PropertyCategory){
    return this.http.put(environment.apiUrl+'/property/category/update',propertyCat);
  }
  deleteCategory(id:number){
    return this.http.delete(environment.apiUrl+'/property/category/delete/'+id);
  }
//property_Name
 saveName(propertyName:PropertyName){
    return this.http.post(environment.apiUrl+'/property/name/save',propertyName);
 }
 getAllName(){
   return this.http.get(environment.apiUrl+'/property/name/getall');
 }
 getNameById(id:number){
  return this.http.get(environment.apiUrl+'/property/name/getbyid/'+id);
 }
 updateName(PropertyName:PropertyName){
  return this.http.put(environment.apiUrl+'/property/name/update',PropertyName);
 }
 deleteName(id:number){
   return this.http.delete(environment.apiUrl+'/property/name/delete/'+id);
 }
 //asset_Addition
 assetsave(assetaddition:AssetAddition){
 return this.http.post(environment.apiUrl+'/property/assetaddition/saveupdate',assetaddition);
 }
 getAllAsset(){
   return this.http.get(environment.apiUrl+'/property/assetaddition/getall');
 }
 getAssetById(id:number){
   return this.http.get(environment.apiUrl+'/property/assetaddition/getbyid/'+id);
 }
 deleteAsset(id:number){
  return this.http.delete(environment.apiUrl+'/property/assetaddition/delete/'+id);
 }
 getAllAssetByCategory(id:number){
  return this.http.get(environment.apiUrl+'/property/name/getbycategoryid/'+id);
 }
}
