//Pobieranie listy sal//
document.addEventListener("DOMContentLoaded", function () {



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

    var setReservedTerm = function (table) {
        var tableDatacels = document.getElementsByClassName("t1");
        console.log("3");
        
        for (var i = 0; i < tableDatacels.length; i++) {
            var tem = tableDatacels[i].dataset.datatime;

           for (var j = 0; j < table.length; j++) {
               
                if (tem === table[j]) {
                    tableDatacels[i].classList.remove("tablebodystyle");
                    tableDatacels[i].classList.add("tableheadstyletermreserved");
                   // tableDatacels[i].classList.className("tablebodystyle", "tableheadstyletermreserved");
                    //  tableDatacels[i].classList.toggle('tablebodystyle');
                    // link.className = 'newClass1 newClass2';
                    //classList.add(className)
                }

            }
        }

       
    };

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

    //function sleep(milliseconds) {
    //    var start = new Date().getTime();
    //    for (var i = 0; i < 1e7; i++) {
    //        if ((new Date().getTime() - start) > milliseconds) {
    //            break;
    //        }
    //    }
    //}

    //sleep(100);

    var selectList = document.querySelector('#selectRoom');
    selectList.addEventListener("change", function () {
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
                    console.log("dane z oncange", data);

                    var newDateValue = [];
                    var termReserved = [];
                    var termReservedLenght = 0;
                    var parameterbegin = data.hourPeriod[0];
                    var parameterend = data.hourPeriod[1];
                    parameterbegin = parseInt(parameterbegin, 10);
                    parameterend = parseInt(parameterend, 10);

                    for (var j = 0; j < data.dataTable.length; j++) {

                        var newDateTemp = data.dataTable[j].split(" ");
                        newDateValue[j] = newDateTemp[0];

                        if (newDateTemp.length > 0) {

                            var temp = "";
                            for (var k = 1; k < newDateTemp.length; k++) {

                                temp = newDateTemp[0] + " " + newDateTemp[k];
                                termReserved[termReservedLenght] = temp;
                                termReservedLenght = termReservedLenght + 1;

                            }
                        }

                    }
                    addRow(parameterbegin, parameterend);
                    updateDate(newDateValue);
                    reloadDataInTable();
                    setReservedTerm(termReserved);
                    location.reload(); 

                },

                error: function (xhr, ajaxOptons, thorownError) {
                    console.log(xhr.status);
                }
            });
    });


});


