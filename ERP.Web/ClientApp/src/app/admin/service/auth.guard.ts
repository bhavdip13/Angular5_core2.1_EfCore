import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { AuthenticationService } from './authentication.service';

@Injectable()
export class AuthGuard implements CanActivate {

  constructor(private authentication: AuthenticationService, private router: Router) { }

  canActivate(next: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
    const token = this.authentication.getToken();
    //const accessToken = this.authentication.getAccessToken();

    if (!token) {
      console.error('User is not authenticated.');
      this.redirectToLoginPage();
      return false;
    } else if (this.authentication.isAuthenticated()) {
      return true;
    } else {
      this.authentication.refreshToken();
      return true;
    }
    //return true;
  }

  redirectToLoginPage() {
    this.router.navigate(['admin/authentication']);
  }
}
