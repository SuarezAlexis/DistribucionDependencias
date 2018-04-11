$(document).ready(function () {
    $("input[type='text']").each(function () {
        $(this).on("input paste", function () {
            if ($.trim( $(this).val() )) {
                $(this).siblings(".addToList").removeAttr("disabled");
            }
            else {
                $(this).siblings(".addToList").attr("disabled","disabled");
            }
        });
    });
});