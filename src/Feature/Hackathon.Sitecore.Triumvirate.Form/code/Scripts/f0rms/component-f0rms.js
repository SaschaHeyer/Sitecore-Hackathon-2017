XA.component.f0rms = (function ($, document) {
    var api = {};

    api.init = function () {
        var mailRegex =
            /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$/;

        $(".datepicker").datepicker();

        $(".submitButton").click(function (event) {
            // Prevent a postback
            event.preventDefault();

            // Inititally set validation error to false
            var validationError = false;

            var list = {};
            var formContainer = $(this).closest('.form');

            formContainer.find("input, textarea").each(function () {
                // Label Extraction
                var label = $(this).prev().find("label").text();
                if (label === "") {
                    return;
                }

                var customValidationError = false;
                
                if ($(this).attr("custom-type") === "email") {
                    var emailValue = $(this).val();
                    customValidationError = !mailRegex.test(emailValue);
                }

                // Value Extraction
                var value;
                if ($(this).attr("type") === "radio") {
                    var checkedElement = $(this).parents(".radioList").find(':checked');
                    if (checkedElement.attr("id") === $(this).attr("id")) {
                        value = $(this).val();
                    }
                }
                if ($(this).attr("type") === "checkbox") {
                    value = $(this).prop("checked");
                }
                else if ($(this).attr("type") === "submit") {
                    return;
                }
                else {
                    value = $(this).val();
                }

                var requiredValidationError = $(this).prop('required') === true && (value === "" || value === false);

                // Validation
                if (requiredValidationError || customValidationError) {
                    validationError = true;
                    // Set Styling
                    $(this).addClass("errorActive");
                    $(this).next().css("display", "block");
                } else {
                    // Set Styling
                    $(this).removeClass("errorActive");
                    $(this).next().css("display", "none");
                }

                // Set up of json string
                list[label] = value;
            });

            // Return and dont execute if a error happended
            if (validationError) {
                return;
            }

            var parameter = JSON.stringify(list);
            var id = $("#Id").val();
            var contextSiteId = $("#ContextSite").val();

            var backendUrl = "/api/sitecore/FormContainer/Submit";
            $.ajax({
                url: backendUrl,
                data: {
                    "parameter": parameter,
                    "Id": id,
                    "ContextSite": contextSiteId
                },
                method: "POST"
            }).done(function (data) {
                if (data === true) {
                    formContainer.find(".sendsuccess").css("display", "block");
                    formContainer.find(".senderror").css("display", "none");
                } else {
                    formContainer.find(".senderror").css("display", "block");
                    formContainer.find(".sendsuccess").css("display", "none");
                }
            });
        });
    };

    return api;
})(jQuery, document);

XA.register("f0rms", XA.component.f0rms);