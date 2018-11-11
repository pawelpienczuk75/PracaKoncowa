
document.addEventListener("DOMContentLoaded", function () {
//Pobieranie listy sal//
var addOption = function(tableOfRoom) {
    var selectRoomOption = document.querySelector('#selectRoomOption');
    var selectList = document.querySelector('#selectRoom');
    for (var i = 0; i < tableOfRoom.length; i++) {
        var newOption = selectRoomOption.cloneNode(true);
        newOption.innerText = tableOfRoom[i];
        newOption.value = tableOfRoom[i];
        selectList.appendChild(newOption);
    }
    selectRoomOption.setAttribute("hidden", "true");
};

 //dodawanie rezerwacji//
var setReservedTerm = function (table) {
    var tableDatacels = document.getElementsByClassName("t1");
    for (var i = 0; i < tableDatacels.length; i++) {
       var tem = tableDatacels[i].dataset.datatime;
       for (var j = 0; j < table.length; j++) {
           if (tem === table[j]) {
                    tableDatacels[i].classList.remove("tablebodystyle");
                    tableDatacels[i].classList.add("tableheadstyletermreserved");
           }
       }
    }
};
//pobieanie danych dla listy wyboru//
$.ajax(
    {
         url: "/Rent/RentRoomTermSelectListData/",
         data: {},
         type: "POST",
         dataType: "json",
         success: addOption,
         error: function (xhr, ajaxOptons, thorownError) {
            console.log(xhr.status);
        }
    });
 //Wbor sali//
    var selectList = document.querySelector('#selectRoom');
    selectList.addEventListener("change" , function () {
        var selectedValue = selectList.value;
        var divTableOfWeek = document.querySelector('#showTableOfWeek');
        divTableOfWeek.classList.remove("hidden");
        $.ajax(
            {
                url: "/Rent/RentRoomTerm/",
                data: { Room: selectedValue},
                type: "POST",
                dataType: "json",
                success: function(data) {
                    var newDateValue = [];
                    var parameterbegin = data.hourPeriod[0];
                    var parameterend = data.hourPeriod[1];
                    parameterbegin = parseInt(parameterbegin, 10);
                    parameterend = parseInt(parameterend, 10);
                    for (var j = 0; j < data.dataTable.length; j++) {
                         var newDateTemp = data.dataTable[j].split(" ");
                         newDateValue[j] = newDateTemp[0];                      
                    }
                    addRow(parameterbegin, parameterend);
                    updateDate(newDateValue);
                    reloadDataInTable();
                    renmoveClassTableheadstyletermreserved();
                    setReservedTerm(data.reservTerms);
                },
                error: function (xhr, ajaxOptons, thorownError) {
                    console.log(xhr.status);
                }
            });
    });
//Przewijanie stron//
    var pagination = document.getElementsByClassName("page-item");
    pagination[pagination.length - 1].addEventListener("click",
        function () {
            var selectList = document.querySelector('#selectRoom');
            var selectedValue = selectList.value;
            var activeWeek = "";
            var temp = pagination[4].classList;
            for (var a = 0; a < temp.length; a++) {
                 if (temp[a] !== "disabled") {
                     for (var r = 1; r < pagination.length - 2; r++) {
                         var temp2 = pagination[r].classList;
                         for (var k = 0; k < temp2.length; k++) {
                              if (temp2[k] === "active") {                         
                                  pagination[r].classList.remove("active");
                                  pagination[r + 1].classList.add("active");
                                  activeWeek = pagination[r + 1].innerText;
                                  r = r + 1;
                              }
                          }
                         if (r === 4) {
                             pagination[5].classList.add("disabled");
                             pagination[4].classList.add("active");
                         }
                     }
                 }
            }
            pagination[0].classList.remove("disabled");
            $.ajax(
                {
                    url: "/Rent/RentRoomChangeWeek/",
                    data: {
                        selecedWeek: activeWeek,
                        selecedRoom: selectedValue
                    },
                    type: "POST",
                    dataType: "json",
                    success: function (data) {
                        var newDateValue = [];
                        var parameterbegin = data.hourPeriod[0];
                        var parameterend = data.hourPeriod[1];
                        parameterbegin = parseInt(parameterbegin, 10);
                        parameterend = parseInt(parameterend, 10);
                        for (var j = 0; j < data.dataTable.length; j++) {
                             var newDateTemp = data.dataTable[j].split(" ");
                             newDateValue[j] = newDateTemp[0];
                        }
                        renmoveClassTableheadstyletermreserved();
                        updateDate(newDateValue);
                        reloadDataInTable();
                        setReservedTerm(data.reservTerms);
                    },
                    error: function (xhr, ajaxOptons, thorownError) {
                        console.log(xhr.status);
                    }
                });
        });
    pagination[0].addEventListener("click",
        function () {
            var selectList = document.querySelector('#selectRoom');
            var selectedValue = selectList.value;
            var activeWeek = "";
            var temp = pagination[1].classList;
            for (var a = 0; a < temp.length; a++) {                
                 if (temp[a] !== "disabled") {
                     for (var j = pagination.length - 1; j > 1; j--) {
                        var temp2 = pagination[j].classList;
                        for (var kk = 0; kk < temp2.length; kk++) {
                            if (temp2[kk] === "active") {
                                 pagination[j].classList.remove("active");
                                 pagination[j - 1].classList.add("active");
                                 activeWeek = pagination[j - 1].innerText;
                                 j = j - 1;
                            }
                        }
                        if (j === 1) {
                            pagination[0].classList.add("disabled");
                        }
                     }
                 }
            }
            pagination[pagination.length - 1].classList.remove("disabled");
            $.ajax(
                {
                     url: "/Rent/RentRoomChangeWeek/",
                     data: {
                         selecedWeek: activeWeek,
                         selecedRoom: selectedValue
                     },
                     type: "POST",
                     dataType: "json",
                     success: function(data) {
                         var newDateValue = [];
                         var parameterbegin = data.hourPeriod[0];
                         var parameterend = data.hourPeriod[1];
                         parameterbegin = parseInt(parameterbegin, 10);
                         parameterend = parseInt(parameterend, 10);
                         for (var j = 0; j < data.dataTable.length; j++) {
                             var newDateTemp = data.dataTable[j].split(" ");
                             newDateValue[j] = newDateTemp[0];
                         }
                         renmoveClassTableheadstyletermreserved();
                         updateDate(newDateValue);
                         reloadDataInTable();
                         setReservedTerm(data.reservTerms);
                     }
                });
        });
    for (var i = 0; i < pagination.length; i++) {
        pagination[i].addEventListener("click", function() {
            var temp = this.innerText; 
        });
    }
});


