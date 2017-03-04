XA.component.f0rms = (function ($, document) {
    var api = {};

    api.init = function () {
        jQuery(".datepicker").datepicker();

        var validationError = false;

        $(".submitButton").click(function (event) {
            // Prevent a postback
            event.preventDefault();

            var list = {};
            var formContainer = $(this).closest('.form');
            formContainer.find("input, textarea").each(function () {
                // Label Extraction
                var label = $(this).prev("label").text();
                if (label === "") {
                    return;
                }

                // Value Extraction
                var value;
                if ($(this).attr("type") === "checkbox") {
                    value = $(this).prop("checked");
                }
                else if ($(this).attr("type") === "submit") {
                    return;
                }
                else {
                    value = $(this).val();
                }

                // Validation
                if ($(this).prop('required') == 'undefined' && value === "") {
                    validationError = true;
                    // Set Styling
                    $(this).addClass("errorActive");
                    $(this).next().show();
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
                alert("Call Completed");
            });
        });
    };

    return api;
})(jQuery, document);

XA.register("f0rms", XA.component.f0rms);