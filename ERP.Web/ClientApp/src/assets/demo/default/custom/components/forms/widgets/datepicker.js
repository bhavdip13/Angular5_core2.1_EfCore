//== Class definition

var BootstrapDatetimepicker = function () {

    //== Private functions
    var demos = function () {

        // input group demo
        $('#m_datetimepicker_1, #m_datetimepicker_2, #m_datetimepicker_3, #m_datetimepicker_4, #m_datetimepicker_5').datetimepicker({
            format: "yyyy/mm/dd",
            todayHighlight: true,
            autoclose: true,
            startView: 2,
            minView: 2,
            forceParse: 0,
            pickerPosition: 'bottom-left'
        });
    }

    return {
        // public functions
        init: function () {
            demos();
        }
    };
}();

jQuery(document).ready(function () {
    BootstrapDatetimepicker.init();
});