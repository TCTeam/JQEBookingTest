$(this).ready(function (e) {

    $("#textStartDate").datepicker({
        dateFormat: 'yy-mm-dd',
        defaultDate: "+1w",
        numberOfMonths: 2,
        monthNames: ['1月', '2月', '3月', '4月', '5月', '6月', '7月', '8月', '9月', '10月', '11月', '12月'],
        onClose: function (selectedDate) {
            $("#textEndDate").datepicker("option", "minDate", selectedDate);
        }
    });
    $("#textEndDate").datepicker({
        dateFormat: 'yy-mm-dd',
        defaultDate: "+1w",
        numberOfMonths: 2,
        onClose: function (selectedDate) {
            $("#textStartDate").datepicker("option", "maxDate", selectedDate);
        }
    });
});