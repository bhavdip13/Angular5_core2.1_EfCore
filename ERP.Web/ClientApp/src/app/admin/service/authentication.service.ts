import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable()
export class AuthenticationService {

  token = {
    refresh_token: 'refreshtokencode',
    exp: new Date((new Date().getDate() + 1)),
    access_token: {
      username: 'user',
      roles: ['Admin', 'RegisteredUser', 'Super User']
    }
  };

  tokenKey = 'a5smm_utoken';

  constructor(private router: Router) { }

  login(username, password) {
    this.setToken(this.token);
    this.router.navigate(['admin']);
  }

  logout() {
    this.removeToken();
    this.router.navigate(['admin/authentication']);
  }

  getToken() {
    return JSON.parse(localStorage.getItem(this.tokenKey));
  }

  setToken(token) {
    localStorage.setItem(this.tokenKey, JSON.stringify(token));
  }

  getAccessToken() {
    return JSON.parse(localStorage.getItem(this.tokenKey))['access_token'];
  }

  isAuthenticated() {
    const token = localStorage.getItem(this.tokenKey);

    if (token) {
      return true;
    } else {
      return false;
    }
  }

  refreshToken() {
    this.token.exp = new Date((new Date().getDate() + 1));
    this.setToken(this.token);
  }

  removeToken() {
    localStorage.removeItem(this.tokenKey);
  }

}
