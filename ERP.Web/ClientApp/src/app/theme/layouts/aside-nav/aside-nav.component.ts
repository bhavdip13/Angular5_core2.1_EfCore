import { Component, OnInit, ViewEncapsulation, AfterViewInit } from '@angular/core';
import { Helpers } from '../../../helpers';

import { CurrentUserDataModel } from '../../pages/models/currentuserdatamodel';

declare let mLayout: any;
@Component({
    selector: "app-aside-nav",
    templateUrl: "./aside-nav.component.html",
    encapsulation: ViewEncapsulation.None,
})
export class AsideNavComponent implements OnInit, AfterViewInit {
    _userMenuModuleList: any[];
    public _menuList: any[];
    public _moduleList: any[];

    constructor() {

    }
    ngOnInit() {
       // this.bindMenu();
    }
    ngAfterViewInit() {

        mLayout.initAside();

    }

    bindMenu() {

        let localData = JSON.parse(localStorage.getItem('currentUser'));

        this._moduleList = localData["moduleList"];
        this._menuList = localData["menuList"];

        let arrList = [];
        this._moduleList.forEach(item => {

            let moduleName = item.moduleName;

            let arr = this._menuList.filter(f => f.modulename.toLowerCase().indexOf(moduleName.toLowerCase()) > -1);

            arrList.push({ "modulename": item.moduleName, "modulecssclass": item.cssClassName, "menuname": item.menuName, "url": item.url, "menuList": arr });
        });
        this._userMenuModuleList = arrList;

        //let data = JSON.parse('[{"modulename":"User","menuname":"AddUser","url":"/user/add-user"},{"modulename":"User","menuname":"FetchUser","url":"/user/fetch-user"}]');
        //this._usermenu = data;

    }

}
