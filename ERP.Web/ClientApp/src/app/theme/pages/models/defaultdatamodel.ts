export class DefaultDataModel {
    //meta: Meta;
    //data: Array<Data>;
    RecordID: number;
    OrderID: string;
    ShipCountry: string;
    ShipCity: string
    ShipName: string;
    ShipAddress: string;
}

class Meta {
    page: number;
    pages: number;
    perpage: number;
    total: number;
    sort: string;
    field: string;
}
class Data {
    RecordID: number;
    OrderID: string;
    ShipCountry: string;
    ShipCity: string
    ShipName: string;
    ShipAddress: string;
}