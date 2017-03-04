XA.component.f0rms = (function ($, document) {
    var api = {};

    api.init = function () {
        jQuery(".datepicker").datepicker();

        $(".submitButton").click(function (event) {
            event.preventDefault();

            var list = {};
            var formContainer = $(this).closest('.form');
            formContainer.find("input").each(function () {
                var label = $(this).prev("label").text();
                if (label === "") {
                    return;
                }

                var value;

                if ($(this).attr("type") === "submit") {
                    return;
                }
                if ($(this).attr("type") === "checkbox") {
                    if ($(this).checked) {
                        value = 1;
                    }
                    else {
                        value = 0;
                    }
                }
                else {
                    value = $(this).val();
                }

                list[label] = value;
            });
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