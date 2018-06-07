import { Component, OnInit, ViewEncapsulation, AfterViewInit, Inject } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { NgForm, FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { FetchUserComponent } from '../fetchuser/fetchUser.component';
import { Helpers } from '../../../../../helpers';
import { ScriptLoaderService } from '../../../../../_services/script-loader.service';
import { UserService } from '../../../services/user.service';
import { User } from '../../../models/index';

@Component({
  selector: 'addUser',
  templateUrl: './addUser.component.html',
  encapsulation: ViewEncapsulation.None,
})
export class AddUserComponent implements OnInit, AfterViewInit {
  userForm: FormGroup;
  title: string = "Create";
  id: number;
  errorMessage: any;
  user: User;

  constructor(
    private _script: ScriptLoaderService,
    private _avRoute: ActivatedRoute,
    private _router: Router,
    private _userService: UserService,
    private _fb: FormBuilder) {
    if (this._avRoute.snapshot.params["id"]) {
      this.id = this._avRoute.snapshot.params["id"];
    }
  }
  onFileChange(event) {
    let reader = new FileReader();
    if (event.target.files && event.target.files.length > 0) {
      let file = event.target.files[0];
      reader.readAsDataURL(file);
      debugger;
      this.userForm.get('profilePicBinary').setValue(reader.result.split(',')[1]);
      this.userForm.get('mimeType').setValue(file.type);


    }
  }

  GetUserByID(userid: number) {
    this._userService.getUserById(userid)
      .subscribe(user => {
        console.log("GetUserByID", user);
        this.user = user;
      });
  }

  getUsers() {
    this._userService.getUsers()
      .subscribe(data => {
        console.log("GetAllUser", data);
      })
  }
  ngOnInit() {

    this.initializeForm();
    if (this.id > 0) {

      this.title = "Edit";
      this._userService.getUserById(this.id).subscribe(result => {
        console.log(result);
        this.user = result;
        debugger;
        this.userForm.setValue({

          id: this.id,
          email: this.user.email,
          emailConfirmed: this.user.emailConfirmed,
          password: this.user.password,
          phoneNumber: this.user.phoneNumber,
          userName: this.user.userName,
          active: this.user.active,
          fullName: this.user.fullName,
          profilePicBinary: this.user.profilePicBinary,
          mimeType: this.user.mimeType,
        });
      });
    }


  }


  ngAfterViewInit() {
    this._script.loadScripts('addUser',
      ['assets/demo/default/custom/components/forms/validation/form-controls.js']);

  }

  save() {


    if (this.title == "Create") {

      this._userService.saveUser(this.userForm.value)
        .subscribe((data) => {
          this.userForm.reset();
          this._router.navigate(['user/fetch-user']);
        }, error => console.log(error))
    }
    else if (this.title == "Edit") {

      this._userService.saveUser(this.userForm.value)
        .subscribe((data) => {
          this.userForm.reset();
          this._router.navigate(['user/fetch-user']);
        }, error => console.log(error))
    }
  }
  cancel() {
    this._router.navigate(['/fetch-user']);
  }

  private initializeForm() {

    this.userForm = this._fb.group({
      id: [0],
      email: ['', [Validators.required]],
      emailConfirmed: [false],
      password: ['', [Validators.required]],
      phoneNumber: ['', [Validators.required]],
      userName: ['', [Validators.required]],
      active: [false],
      fullName: ['', [Validators.required]],
      profilePicBinary: null,
      mimeType: [''],

    });


  }

}
