
document.addEventListener("DOMContentLoaded", function() {

    var tableOnMove = document.getElementsByClassName("tablebodystyle");
    console.log(tableOnMove);

    for (var i = 0; i < tableOnMove.length; i++) {
        
        tableOnMove[i].addEventListener("mouseover", function () {
        this.setAttribute("class", "tablebodystylemoveon");
       
        });
    }

    for (var i = 0; i < tableOnMove.length; i++) {

        tableOnMove[i].addEventListener("mouseout", function () {
        this.setAttribute("class", "tablebodystyle");

        });
    }




//odbieranie danych
var h = function(data) {
  //  console.log("jestem tu");
    console.log(data);
};

$.ajax(
    {
        url: "/Default/DataSend/",
        data: {},
        type: "POST",
        dataType: "json",
        success: h,

      //  success: function (data, xhr) {
            
     //      console.log(data);
     //       zmienna = data[0].id;
          //  h(data.Id);
            
     //   },
        error: function (xhr, ajaxOptons, thorownError) {
            console.log(xhr.status);
        }
    });


$.ajax(
    {
        url: "/Default/DataGet/",
        data: {
           
                Id: 22
           
        },
        type: "POST",
        dataType: "json",
        success: function (data, xhr) {
         //   console.log(data);
        },
        error: function (xhr, ajaxOptons, thorownError) {
            console.log(xhr.status);
        }




        });

});