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

    //constructor() {
    //}

    ngOnInit() {
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
                    field: "fullName",
                    title: "Full Name",
                    width: 150
                },

                {
                    field: "email",
                    title: "Email",
                    width: 150,
                    responsive: { visible: 'lg' }
                },
                {
                    field: "createdTime",
                    title: "Created Time",
                    width: 150,
                    sortable: 'desc',
                    responsive: { visible: 'lg' },
                    type: "date",
                    format: "MM/DD/YY"
                },
                {
                    field: "updatedTime",
                    title: "Updated Time",
                    width: 150,
                    responsive: { visible: 'lg' },
                    type: "date",
                    format: "MM/DD/YY"
                }]
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