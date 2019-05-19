import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';

@Component({
  selector: 'app-startup',
  templateUrl: './startup.component.html',
  styles: []
})
export class StartupComponent {

  public response: string;
  constructor(private http: HttpClient) { }

  call() {
    this.http.get(environment.apiUrl + '/users').subscribe(data => {
      this.response = data.toString();
    });
  }

}
