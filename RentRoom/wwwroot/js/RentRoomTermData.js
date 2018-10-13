document.addEventListener("DOMContentLoaded", function () {



    //------------------------------------------------------------------------//
    // Generowanie tableli//
    var addRow = function (a,b) {
        console.log("add" + a);
        var rowToClone = document.querySelector('#prototype');
        var ttable = document.querySelector('#tableOfWeek');

        for (var i = a; i <= b; i++) {

            var newRow = rowToClone.cloneNode(true);
            var hour = i;

            if (hour < 9) {
                hour = "0" + hour;
            } 

            newRow.children[0].innerText = hour;

            for (var j = 1; j < 8; j++) {

                newRow.children[j].setAttribute("id", "0" + hour + j);
                newRow.children[j].setAttribute("class", "tablebodystyle");
                // newRow.children[j].dataset.dateTime = getdata.children[j].dataset.data + " " + hour;
            }

            ttable.appendChild(newRow);

        }
        rowToClone.setAttribute("hidden", "true");
    }

    //------------------------------------------------------------------//
    //funkcja przeładowująca dane związane z datą i czasem w komórkach tabeli//

    var reloadDataInTable = function () {
        var tableDatacels = document.getElementsByClassName("tablebodystyle");
        var headTableData = document.getElementsByClassName("headRow");
        var columTableData = document.getElementsByClassName("tableofcolumn");
        console.log("2");
        var numbrerOfCels = 0;
        for (var i = 1; i < columTableData.length; i++) {

            var hour = columTableData[i].innerText;

            for (var j = 0; j < headTableData.length; j++) {
                var date = headTableData[j].innerText;
                tableDatacels[numbrerOfCels].innerText = date + " " + hour;
                tableDatacels[numbrerOfCels].dataset.dataTime = date + " " + hour;
                numbrerOfCels = numbrerOfCels + 1;
            }

        }
    }
//--------------------------------------------------------------------------//
//Blokowanie zarezerwowanych terminów/

    var setReservedTerm = function (table) {
        var tableDatacels = document.getElementsByClassName("tablebodystyle");
        console.log("3");
        for (var i = 0; i < tableDatacels.length; i++) {

            var tem = tableDatacels[0].dataset.dataTime;
            console.log(tem);
            for (var j = 0; j < table.length; j++) {

                if (tableDatacels[i].dataset.dataTime === table[j]) {
                    tableDatacels[i].setAttribute("class", "tableheadstyletermreserved");
                }

            }
        }
    }

    //----------------------------------------------------------------------//
    //Aktualizacja daty w nagłówku//
    var tablelaPomocnicza = [
        "01.06.2018", "02.06.2018", "03.06.2018", "04.06.2018", "05.06.2018", "06.06.2018", "07.06.2018"
    ];

    var updateDate = function (table) {
        var setdata = document.querySelector('#data');
        console.log("1");
        for (var i = 0; i < 7; i++) {

            setdata.children[i + 1].dataset.data = table[i];
            setdata.children[i + 1].innerText = table[i];
        }

    }
    //updateDate(tablelaPomocnicza);
    addRow(12,19);
    //reloadDataInTable();
   


   

    //-------------------------------------------------------------------------//
    // Przewijanie tygodni w przod.

    var nextWeek = document.querySelector('#next');
    nextWeek.addEventListener("click", function () {




        console.log("kliknieto next");
    });

    //-------------------------------------------------------------------------//
    // Przewijanie tygodni w tył.

    var previousWeek = document.querySelector('#previous');
    previousWeek.addEventListener("click", function () {
        var firstDayOfWeek = document.querySelector('#firstDayOfWeek');
        var firstDayOfWeekValue = firstDayOfWeek.dataset.data.data;
        $.ajax(
            {
                url: "/Rent/RentRoomTermData/",
                data: { firstDayOfWeekValue },
                type: "POST",
                dataType: "json",
                // success: updateDate,
                success: function (data, xhr) {
                    console.log(data);
                    var newDateValue = [];
                    var termReserved = [];
                    var termReservedLenght = 0;

                    for (var j = 0; j < data.length; j++) {

                        var newDateTemp = data[j].split(" ");
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
                    updateDate(newDateValue);
                    reloadDataInTable();
                    console.log(termReservedLenght);
                    //  setReservedTerm(termReserved);

                },

                error: function (xhr, ajaxOptons, thorownError) {
                    console.log(xhr.status);
                }
            });
        reloadDataInTable();
        console.log("kliknieto next");
    });

    var getDateForRentTable = function() {
        var firstDayOfWeek = document.querySelector('#firstDayOfWeek');
        var firstDayOfWeekValue = firstDayOfWeek.dataset.data.data;
        $.ajax(
            {
                url: "/Rent/RentRoomTermData/",
                data: { firstDayOfWeekValue },
                type: "POST",
                dataType: "json",
                // success: updateDate,
                success: function(data, xhr) {
                    console.log(data.dataTable);
                    console.log(data.hourpreiod);
                    var newDateValue = [];
                    var termReserved = [];
                    var termReservedLenght = 0;
                    var parameterbegin = data.hourpreiod[0]; 
                    var parameterend = data.hourpreiod[1]; 
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
                    //console.log(termReservedLenght);
                    //  setReservedTerm(termReserved);

                },

                error: function(xhr, ajaxOptons, thorownError) {
                    console.log(xhr.status);
                }
            });

    }
    getDateForRentTable();
});