//== Class definition

var DefaultDatatableDemo = function () {
    //== Private functions

    // basic demo
    var demo = function () {

        var datatable = $('.m_datatable').mDatatable({
            data: {
                type: 'remote',
                source: 'https://keenthemes.com/metronic/preview/inc/api/datatables/datasource/default.json',
                pageSize: 10,
                serverPaging: true,
                serverFiltering: true,
                serverSorting: true
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

            columns: [{
                field: "OrderID",
                title: "Name",
                sortable: 'asc',
                filterable: false,
                width: 150,
                template: '{{OrderID}} - {{ShipCountry}}'
            }, {
                field: "View",
                title: "View",
                sortable: false,
                width: 80,
                selector: { class: 'm-checkbox--solid m-checkbox--brand' }
            }, {
                field: "Add",
                title: "Add",
                sortable: false,
                width: 80,
                selector: { class: 'm-checkbox--solid m-checkbox--brand' }
            }, {
                field: "Edit",
                title: "Edit",
                sortable: false,
                width: 80,
                selector: { class: 'm-checkbox--solid m-checkbox--brand' }
            }, {
                field: "Delete",
                title: "Delete",
                sortable: false,
                width: 80,
                selector: { class: 'm-checkbox--solid m-checkbox--brand' }
            }, {
                field: "Print",
                title: "Print",
                sortable: false,
                width: 80,
                selector: { class: 'm-checkbox--solid m-checkbox--brand' }
            }, {
                field: "Copy",
                title: "Copy",
                sortable: false,
                width: 80,
                selector: { class: 'm-checkbox--solid m-checkbox--brand' }
            }, {
                field: "Active",
                title: "Active",
                sortable: false,
                width: 80,
                selector: { class: 'm-checkbox--solid m-checkbox--brand' }
            }, {
                field: "InActive",
                title: "InActive",
                sortable: false,
                width: 80,
                selector: { class: 'm-checkbox--solid m-checkbox--brand' }
            }, {
                field: "Actions",
                width: 110,
                title: "Actions",
                sortable: false,
                overflow: 'visible',
                template: function (row, index, datatable) {
                    var dropup = (datatable.getPageSize() - index) <= 4 ? 'dropup' : '';
                    return '\
						<div class="dropdown '+ dropup + '">\
							<a href="#" class="btn m-btn m-btn--hover-accent m-btn--icon m-btn--icon-only m-btn--pill" data-toggle="dropdown">\
                                <i class="la la-ellipsis-h"></i>\
                            </a>\
						  	<div class="dropdown-menu dropdown-menu-right">\
						    	<a class="dropdown-item" href="#"><i class="la la-edit"></i> Edit Details</a>\
						    	<a class="dropdown-item" href="#"><i class="la la-leaf"></i> Update Status</a>\
						    	<a class="dropdown-item" href="#"><i class="la la-print"></i> Generate Report</a>\
						  	</div>\
						</div>\
						<a href="#" class="m-portlet__nav-link btn m-btn m-btn--hover-accent m-btn--icon m-btn--icon-only m-btn--pill" title="Edit details">\
							<i class="la la-edit"></i>\
						</a>\
						<a href="#" class="m-portlet__nav-link btn m-btn m-btn--hover-danger m-btn--icon m-btn--icon-only m-btn--pill" title="Delete">\
							<i class="la la-trash"></i>\
						</a>\
					';
                }
            }]
        });
    };

    return {
        // public functions
        init: function () {
            demo();
        }
    };
}();

jQuery(document).ready(function () {
    DefaultDatatableDemo.init();
});