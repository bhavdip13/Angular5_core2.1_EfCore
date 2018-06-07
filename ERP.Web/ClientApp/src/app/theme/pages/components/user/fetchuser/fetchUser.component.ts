import { Component, Inject, ViewEncapsulation } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { Router, ActivatedRoute } from '@angular/router';
import { UserService } from '../../../services/user.service'
import { DefaultDataModel } from '../../../models/defaultdatamodel';
import { ToastyService } from 'ng2-toasty';
import { User } from '../../../models/index';

declare var $: any;

@Component({
    selector: 'fetchuser',
    templateUrl: './fetchuser.component.html',
    encapsulation: ViewEncapsulation.None
})
export class FetchUserComponent {
    
    public userList: UserData[];
    DefaultDataList: DefaultDataModel[];
    public tableWidget: any;

    index: number;
    user: User;

    
    ngOnInit() {
    }
  filter = false;

  onFilterChange(eve: any) {
    debugger;
    alert('hi cool');
    this.filter = !this.filter;
  }

    constructor(public http: Http,
        private _router: Router,
        private _userService: UserService,
        private toastyService: ToastyService) {
        this.getUsers();
    }

    getUsers() {

        this._userService.getUsers()
            .subscribe(data => {
                this.userList = data;
                this.DefaultDatatableDemo(data);
                console.log("DATA2", this.userList);
            })
    }
  
    DefaultDatatableDemo(data): void {

        var options = {
            data: {
                type: 'local',
                source: data,
                pageSize: 10
            },
            layout: {
                theme: 'default',
                class: '',
                scroll: true,
                height: 350,
                footer: false
            },

            sortable: true,

            filterable: false,

            pagination: true,

            search: {
                input: $('#generalSearch')
            },

            // toolbar
            toolbar: {
                // toolbar items
                items: {
                    // pagination
                    pagination: {
                        pageSizeSelect: [5, 10, 20, 30, 50, 100/*, -1*/] // display dropdown to select pagination size. -1 is used for "ALl" option
                    }
                }
            },

            columns: [
                {
                    field: 'UserId',
                    title: '#',
                    width: 40,
                    selector: { class: 'm-checkbox--solid m-checkbox--brand' },
                },
                {
                    field: 'id',
                    title: '',
                    width: 1,
                    display: "none"
                },
              {
                width: 170,
                field: 'profilepicbinary',
                title: 'User',
                template: function (data) {
                 
                  if (data.profilePicBinary != null) {
                    data.profilePicBinary = 'data:image/jpg;base64,' + data.profilePicBinary;
                    return '<div class="m-card-user m-card-user--sm">\
								<div class="m-card-user__pic">\
									<img src='+ data.profilePicBinary+' class="m--img-rounded m--marginless" alt="user photo">\
								</div>\
								<div class="m-card-user__details">\
									<span class="m-card-user__name">' + data.fullName + '</span>\
									<a class="m-card-user__email m-link">' +
                      data.phoneNumber + '</a>\
								</div>\
							</div>';
                  } else {
                   
                    var stateNo = Math.floor(Math.random() * (0 - 7 + 1)) + 7;
                    var states = [
                      'success',
                      'brand',
                      'danger',
                      'accent',
                      'warning',
                      'metal',
                      'primary',
                      'info'];
                    var state = states[stateNo];
                    return  '<div class="m-card-user m-card-user--sm">\
								<div class="m-card-user__pic">\
										<div class="m-card-user__no-photo m--bg-fill-' + state +
                      '"><span>' + data.userName.substring(0, 1) + '</span></div>\
								</div>\
								<div class="m-card-user__details">\
									<span class="m-card-user__name">' + data.fullName + '</span>\
									<a  class="m-card-user__email m-link">' +
                      data.phoneNumber + '</a>\
								</div>\
							</div>';
                  }

                 
                },
              },
                {
                  field: "userName",
                    title: "UserName",
                    width: 80
                },

                {
                    field: "email",
                    title: "Email",
                    width: 150,
                  responsive: { visible: 'lg' },
                     template: function (data) {
                       return '<a class="m-link" href="mailto:' + data.email +
                      '">' +
                      data.email + '</a>';
                  },
                },
                {
                  field: "createdOnUtc",
                    title: "Created Date",
                    width: 150,
                    sortable: 'desc',
                    type: 'date',
                    format: 'MM/DD/YYYY',
                },
                
              //{
              //  field: 'emailConfirmed',
              //  title: 'Is Mail Verify',
              //  // callback function support for column rendering
              //  template: function (data) {
                  
              //    if (data.emailConfirmed == true) {
              //      return '<span class="m-badge  m-badge--success m-badge--wide"> Yes </span>';
              //    }
              //    else {
              //      return '<span class="m-badge  m-badge--danger m-badge--wide"> No </span>';
              //    }
                 
              //  },
              //},
              {
                field: 'emailConfirmed',
                title: 'Is Mail Verify',
                // callback function support for column rendering
                template: function (data) {

                  if (data.emailConfirmed == true) {
                   
                    return '<span class="m-switch m-switch--icon-check"><label><input type="checkbox" checked formControlName = "emailconfirmed" id="emailconfirmed"><span></span></label></span>'
                  }
                  else {
                    return '<span class="m-switch m-switch--icon-check"><label><input type="checkbox"  formControlName = "emailconfirmed" id="emailconfirmed"><span></span></label></span>'

                  }

                },
              },
              {
                field: 'active',
                title: 'Is Active',
                // callback function support for column rendering
                template: function (data) {

                  if (data.active == true) {
                    return '<span class="m-switch m-switch--icon-check"><label><input type="checkbox" checked formControlName = "active" id="active" (chnage)="onFilterChange()"><span></span></label></span>'

                  }
                  else {
                    return '<span class="m-switch m-switch--icon-check"><label><input type="checkbox"  formControlName = "active"  id="active" (change)="onFilterChange($event)"><span></span></label></span>'

                  }

                },
              },]
        };

        $('.m_datatable').mDatatable('destroy');
        var datatable = $('.m_datatable').mDatatable(options);

        //get checked record and get value by column name
        $('#m_datatable_edit_get').on('click', () => {

            // select active rows
            datatable.rows('.m-datatable__row--active');

            // check selected nodes
            if (datatable.nodes().length > 0) {
                // get column by field name and get the column nodes
                var value = datatable.columns('id').nodes().text();
                this.index = value;
                this._router.navigate(['/user/add-user', value]);
                //$('#datatable_value').html(value);
            }
        });

        $('#m_datatable_delete_get').on('click', () => {

            // select active rows
            datatable.rows('.m-datatable__row--active');

            // check selected nodes
            if (datatable.nodes().length > 0) {
                // get column by field name and get the column nodes
                var value = datatable.columns('id').nodes().text();
                this.index = value;
                this.OnDeleteById(value)

            }
        });

    

    }

    public OnDeleteById(index: number) {

        this._userService.deleteUser(index)
            .subscribe(responce => {
                this.getUsers();
            }, error => console.log(error))
    }
}
interface UserData {
    UserName: string;
    Password: string;
    EmployeeId: string;
    Language: string;
    Email: string;
}
