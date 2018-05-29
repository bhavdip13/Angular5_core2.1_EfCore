
export class CurrentUserDataModel {
    Id: number;
    Username: string;
    OrgId: number;
    Token: string;
    MenuList: MenuList[];
}
class MenuList {
    modulename: string;
    menuname: string;
    url: string;
    cssClassName: string;
}