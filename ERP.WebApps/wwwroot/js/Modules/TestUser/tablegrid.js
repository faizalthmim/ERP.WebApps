var tablegrid = (function (tablegrid) {
//modal dialog object setting
    tablegrid.windowOptions = {
        modal: true,
        width: 650,
        maxHeight: $(window).height() * 9 / 10,
        visible: false,
        refresh: function () { this.center(); },
        animation: {
            open: { effects: "slideIn:down fadeIn", duration: 350 },
            close: { effects: "slideIn:up fadeIn", reverse: true, duration: 200 }
        }
    };
    tablegrid.gridDataTable = $('#dataTable').DataTable({
        paging: true,
        searching: true,
        processing: true,
        serverSide: true,
        retrieve: true,
        info: true,
        stateSave: false, //reset paging and sorting when page reload
        order: [[0, 'asc']],
        lengthMenu: [[5, 10, 20], [5, 10, 20]],
        drawCallback: function (settings) {
            $("#selectAll").prop("checked", false);
        },
        ajax: {
            url: tablegrid.loadDataTable,
            type: 'POST',
            contentType: "application/json",
            data: function (d) {

                return JSON.stringify(d);
            }
        },
        columns: [
            {
                data: null,
                orderable: false,
                width: "80px",
                render: function (data, type, row) {
                    return "" +
                        "<button type='button' class='btn btn-sm btn-success' onClick='tablegrid.editClick(event, \"" + row.USER_ID + "\")'><i class='fa-solid fa-pen-to-square'></i></button>" +
                        "<button type='button' class='ml-1 btn btn-sm btn-danger' onClick='tablegrid.deleteClick(event, \"" + row.USER_ID + "\")'><i class='fa-solid fa-trash-can'></i></button>";
                },
            },
            { data: "USER_ID" },
            { data: "USER_NAME" },
            { data: "PWD" },
         ]
        //"scrollX": true //if need horizontal scroll
    });
    tablegrid.addNewClick = function (e) {
        e.preventDefault();
        $(".k-window-title").html("Add");
        $("#addEditWindow")
            .data("kendoWindow")
            .refresh({
                url: tablegrid.Create,
            })
            .center()
            .open();
    };
    tablegrid.editClick = function (e, userid) {
        e.preventDefault();
        $(".k-window-title").html("Edit");
        $("#addEditWindow")
            .data("kendoWindow")
            .refresh({
                url: tablegrid.Edit,
                data: { id: userid }
            })
            .center()
            .open();
    };
    tablegrid.submitClick = function (e) {
        e.preventDefault();
        var $form = $("#formCreateEdit");
        var url = ($form.find("#USER_ID").val() == "") ? tablegrid.CreateApi : tablegrid.EditApi//"@Url.Action("Create")" : "@Url.Action("Edit")";

        cpd.showLoading();

        var validatable = $form.kendoValidator(cpd.validatorOptions).data("kendoValidator");

        if (!validatable.validate()) {
            cpd.hideLoading();
            return;
        }

        $.ajax({
            url: url,
            type: "POST",
            data: JSON.stringify($form.serializeObject()),
            contentType: "application/json",
            dataType: "json",
            success: function (result) {
                if (result.isSucceed) {
                    tablegrid.gridDataTable.ajax.reload();
                    tablegrid.closeWindow();
                    cpd.hideLoading();
                    swal("Success", "OK", {
                        icon: "success"
                    });
                }
                else {
                    cpd.hideLoading();
                    swal("Error", "Error", {
                        icon: "error"
                    });
                }
            }
        });
    };
    tablegrid.deleteClick = function (e, id) {
        e.preventDefault();

        swal({
            title: "Apa anda yakin akan menghapus data?",
            text: "Data yang sudah dihapus tidak bisa dipulihkan lagi.",
            icon: "warning",
            //buttons: true,
            buttons: ["Batal", "OK"],
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {
                    tablegrid.delete(id);
                }
            });
    };

    tablegrid.delete = function (id) {
        if (id != null) {

            cpd.showLoading();

            $.ajax({
                url: tablegrid.DeleteApi,//"@Url.Action("Delete")",
                type: "POST",
                contentType: "application/json",
                data: JSON.stringify({ USER_ID: id }),
                dataType: "json",
                success: function (result) {
                    if (result.isSucceed) {
                        tablegrid.gridDataTable.ajax.reload();
                        cpd.hideLoading();
                        swal("Dihapus", "Data berhasil dihapus", {
                            icon: "success"
                        });
                    }
                    else {
                        cpd.hideLoading();
                        swal("Error ", result.message, {
                            icon: "error"
                        });
                    }
                }
            });
        }
    };

    tablegrid.closeWindow = function (e) {
        $("#addEditWindow")
            .data("kendoWindow").close();
    }
    return tablegrid;
})(tablegrid || {});

$(function (e) {
    $("#addEditWindow").kendoWindow(tablegrid.windowOptions);
    $('#btnAddNew').on('click', tablegrid.addNewClick)
})