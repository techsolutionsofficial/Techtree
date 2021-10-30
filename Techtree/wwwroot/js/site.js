
$(function () {
    $('.myTable').DataTable();

    function AddSubtractMonths(date, numMonths) {
        var month = date.getMonth();

        var milliSeconds = new Date(date).setMonth(month + numMonths);

        return new Date(milliSeconds);
    };

    function WireUpDatePicker() {

        const addMonths = 2;
        var currDate = new Date();

        $('.datepicker').datepicker(
            {
                dateFormat: 'dd-mm-yy',
                minDate: currDate,
                maxDate: AddSubtractMonths(currDate, addMonths)
            }
        );
    }

    WireUpDatePicker();

});
