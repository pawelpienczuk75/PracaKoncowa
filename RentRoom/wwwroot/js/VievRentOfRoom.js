
document.addEventListener("DOMContentLoaded", function () {
    var listOfRooms = document.getElementsByClassName("listOfRooms");

  //  listOfRooms 
    var getListOfRoom = function () {
       

        $.ajax(
            {
                url: "/Rent/Index/",
                data: {},
                type: "Get",
                dataType: "json",
                // success: updateDate,
                success: function(data, xhr) {
                    console.log("jestem tu");

                    console.log(data);
                

                },
                error: function (xhr, ajaxOptons, thorownError) {
                    console.log(xhr.status);
                }
            });
    };
    getListOfRoom();
});
