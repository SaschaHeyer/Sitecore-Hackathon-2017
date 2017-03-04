XA.component.f0rms = (function ($, document) {
	var api = {};
 	
	api.init = function(){					
		$(".submitButton").click(function(event ) {
			event.preventDefault();

			var list = [];
			var formContainer = $(this).closest('.form');
			formContainer.find("input").each(function(){
				var innerelement = {};
				var label = $(this).prev("label").text();
				var value = $(this).val();
				innerelement[label] = value;
				list.push(innerelement);
			});
			var parameter = JSON.stringify(list);

			var backendUrl = "/api/sitecore/FormContainer/Submit";
			$.ajax({
				url: backendUrl,
				data: {"parameter": parameter } ,
				method : "POST"
			}).done(function (data) {
				alert("Call Completed");
			});
		});
	};
	
	return api;
})(jQuery, document);

XA.register("f0rms", XA.component.f0rms);