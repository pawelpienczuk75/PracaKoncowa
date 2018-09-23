
//odbieranie danych
var h = function(data) {
    console.log("jestem tu");
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