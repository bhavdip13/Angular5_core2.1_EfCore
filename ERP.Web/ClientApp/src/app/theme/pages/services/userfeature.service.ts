
import { Injectable, Inject } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';


@Injectable()
export class UserFeatureService {
    apiUrl: string = "";
    constructor(private http: Http, @Inject('BASE_URL') baseUrl: string) {
        debugger;
        this.apiUrl = baseUrl;
    }

    getAll() {
        return this.http.get(this.apiUrl + '/api/userfeature', this.jwt()).map((response: Response) => response.json());
    }

    getById(id: number) {
        return this.http.get(this.apiUrl + '/api/userfeature/' + id, this.jwt()).map((response: Response) => response.json());
    }

    create(userfeature) {
        return this.http.post(this.apiUrl + '/api/userfeature', userfeature, this.jwt());
    }

    update(userfeature) {
        return this.http.put(this.apiUrl + '/api/userfeature/' + userfeature.id, userfeature, this.jwt());
    }

    delete(id: number) {
        return this.http.delete(this.apiUrl + '/api/userfeature/' + id, this.jwt());
    }
    approve(userfeature) {
        return this.http.put(this.apiUrl + '/api/userfeature/' + userfeature.id, userfeature, this.jwt());
    }
    reject(userfeature) {
        return this.http.put(this.apiUrl + '/api/userfeature/' + userfeature.id, userfeature, this.jwt());
    }

    // private helper methods

    private jwt() {
        // create authorization header with jwt token
        let userObj: any = localStorage.getItem('currentUser');
        let currentUser = JSON.parse(userObj);
        if (currentUser && currentUser.token) {
            let headers = new Headers({ 'Authorization': 'Bearer ' + currentUser.token });
            return new RequestOptions({ headers: headers });
        }
    }
}