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
                var currentElement = $(this);

                var label = currentElement.prev().find("label").text();
                if (label === "") {
                    return;
                }

                var customValidationError = false;

                if (currentElement.attr("custom-type") === "email") {
                    var emailValue = currentElement.val();
                    customValidationError = !mailRegex.test(emailValue);
                }

                // Value Extraction
                var value;

                if (currentElement.attr("type") === "radio") {
                    // Radio List Check
                    var radioContainer = $("div[radio-container='" + $(this).attr("name") + "']");
                    var checkedElement = radioContainer.find(':checked');

                    if (checkedElement.val() === undefined && $(this).prop('required') === true) {
                        customValidationError = true;
                    }
                    else if (checkedElement.attr("id") === currentElement.attr("id")) {
                        value = currentElement.val();
                    } else {
                        return;
                    }

                    currentElement = radioContainer;
                }
                else if (currentElement.attr("type") === "checkbox") {
                    // Checkbox Check
                    value = currentElement.prop("checked");
                }
                else if (currentElement.attr("type") === "submit") {
                    // Submit Check
                    return;
                }
                else {
                    // Default handling
                    value = currentElement.val();
                }

                var requiredValidationError = currentElement.prop('required') === true && (value === "" || value === false);

                // Validation
                if (requiredValidationError || customValidationError) {
                    validationError = true;
                    // Set Styling
                    currentElement.addClass("errorActive");
                    currentElement.next().css("display", "block");
                } else {
                    // Set Styling
                    currentElement.removeClass("errorActive");
                    currentElement.next().css("display", "none");
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