import { AuthService } from './../../services/auth.service';
import { Component, ViewEncapsulation, } from '@angular/core';
import { AppService } from '../../app.service';
import { ToastrService } from 'ngx-toastr';



@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['../../../vendor/styles/pages/authentication.scss',
    '../../../vendor/libs/ngx-sweetalert2/ngx-sweetalert2.scss',
    '../../../vendor/libs/angular2-ladda/angular2-ladda.scss'],
})
export class LoginComponent {

  submitted = false;
  isLoading = false;

  credentials = {
    email: '',
    password: '',
    rememberMe: false
  };

  isLoginError = false;

  constructor(private appService: AppService, private authService: AuthService, private toastr: ToastrService) {

    this.appService.pageTitle = 'Login';
  }

  loginFormInvalid() {
    if (this.credentials.email.length === 0) {
      return true;
    }

    if (this.credentials.password.length === 0) {
      return true;
    }
    return false;
  }

  login() {

    this.submitted = true;
    // if (this.loginFormInvalid()) {
    //   return;
    // }

    this.isLoading = true;
    localStorage.setItem('remember', this.credentials.rememberMe ? 'true' : 'false');
    if (this.credentials.rememberMe) {
      localStorage.setItem('token', 'token');
      localStorage.setItem('name', 'Developer');
      localStorage.setItem('password', '1234');
      localStorage.setItem('locked', 'false');
    } else {
      sessionStorage.setItem('token', 'token');
      sessionStorage.setItem('name', 'Developer');
      sessionStorage.setItem('password', '1234');
      sessionStorage.setItem('locked', 'false');
    }
    this.appService.redirect('/');
    return;

    this.authService.login(this.credentials).subscribe((data: any) => {
      if (data.access_token) {
        if (this.credentials.rememberMe) {
                  localStorage.setItem('token', data.access_token);
          localStorage.setItem('name', data.fullName);
          localStorage.setItem('password', this.credentials.password);
          localStorage.setItem('locked', 'false');
        } else {
                  sessionStorage.setItem('token', data.access_token);
          sessionStorage.setItem('name', data.fullName);
          sessionStorage.setItem('password', this.credentials.password);
          sessionStorage.setItem('locked', 'false');
        }
        this.appService.redirect('/');
      }
    }, () => {
      this.isLoading = false;
      this.toastr.error('Invalid credentials');
    });
  }
}
