// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var cpd = (function (cpd) {

    cpd.showLoading = function () {
        $("#popupLoading").data("kendoWindow").center().open();
        var kendoWindow = $('.k-window-content.k-content', $(this).next('div.k-widget.k-window'));
        if (kendoWindow == null || kendoWindow.length == 0) {
            return;
        }
        kendoWindow.data('kendoWindow').close();
    };
    cpd.hideLoading = function () {
        $("#popupLoading").data("kendoWindow").close();
    };

    //VALDATION
    cpd.validatorOptions = {
        rules: {
            val_required: function (input) {
                if (input.is("[data-val-required]") && input.is("[data-val='true']")) {
                    return (input.val().toString().trim() == "") ? false : true;
                }
                return true;
            },
            val_remote: function (input) {
                var remoteAttr = input.attr("data-val-remote-url");
                if (typeof remoteAttr === 'undefined' || remoteAttr === false) {
                    return true;
                }

                var isInvalid = true;
                var errorMessage = "Message";
                var data = {};

                data[input.attr("name")] = input.val();

                var additionalFieldsAttr = input.attr("data-val-remote-additionalfields");
                if (additionalFieldsAttr != 'undefined') {
                    var additionalFields = additionalFieldsAttr.split(",");
                    $.each(additionalFields,
                        function (index, arrayEl) {
                            data[arrayEl.substring(2)] = $("#" + arrayEl.substring(2)).val();
                        });
                }

                $.ajax({
                    url: remoteAttr,
                    mode: "abort",
                    port: "validate" + input.attr("name"),
                    dataType: "json",
                    type: input.attr("data-val-remote-type"),
                    data: data,
                    async: false,
                    success: function (response) {
                        if (response == true || response == false) {
                            isInvalid = response;
                        } else {
                            errorMessage = response;
                        }

                    }
                });

                if (errorMessage != "Message") {
                    //alert(errorMessage);
                    return errorMessage;
                }
                return !isInvalid;

            }
        },
        messages: {
            val_required: function (input) {
                return input.data("val-required");
            },
            val_remote: function (input) {
                return input.data("val-remote");
            }
        }
    }


    return cpd;
})(cpd || {});
$(function () {
    $("#popupLoading").kendoWindow({
        modal: true,
        visible: false,
        title: false,
        animation: false,
        autoFocus: true,
        resizable: false
    }).data("kendoWindow").center();

    $("#popupLoading").parents(".k-widget").css({ "background": "transparent", "border": "none" });


});
$(function ($) {
    $.fn.serializeObject = function () {

        var self = this,
            json = {},
            push_counters = {},
            patterns = {
                "validate": /^[a-zA-Z][a-zA-Z0-9_]*(?:\[(?:\d*|[a-zA-Z0-9_]+)\])*$/,
                "key": /[a-zA-Z0-9_]+|(?=\[\])/g,
                "push": /^$/,
                "fixed": /^\d+$/,
                "named": /^[a-zA-Z0-9_]+$/
            };


        this.build = function (base, key, value) {
            base[key] = value;
            return base;
        };

        this.push_counter = function (key) {
            if (push_counters[key] === undefined) {
                push_counters[key] = 0;
            }
            return push_counters[key]++;
        };

        $.each($(this).serializeArray(), function () {

            // Skip invalid keys
            if (!patterns.validate.test(this.name)) {
                return;
            }

            var k,
                keys = this.name.match(patterns.key),
                merge = this.value,
                reverse_key = this.name;

            while ((k = keys.pop()) !== undefined) {

                // Adjust reverse_key
                reverse_key = reverse_key.replace(new RegExp("\\[" + k + "\\]$"), '');

                // Push
                if (k.match(patterns.push)) {
                    merge = self.build([], self.push_counter(reverse_key), merge);
                }

                // Fixed
                else if (k.match(patterns.fixed)) {
                    merge = self.build([], k, merge);
                }

                // Named
                else if (k.match(patterns.named)) {
                    merge = self.build({}, k, merge);
                }
            }

            json = $.extend(true, json, merge);
        });

        return json;
    };
});