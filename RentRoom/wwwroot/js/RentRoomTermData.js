// Generowanie tableli//
var addRow = function (a, b) {
    var rowToClone = document.querySelector('#prototype');
    var ttable = document.querySelector('#tableOfWeek');

    for (var i = a; i <= b; i++) {

        var newRow = rowToClone.cloneNode(true);
        var hour = i;

        if (hour < 9) {
            hour = "0" + hour;
        }

        newRow.children[0].innerText = hour;
        newRow.children[0].dataset.dataTime = hour;
        for (var j = 1; j < 8; j++) {

            newRow.children[j].setAttribute("id", "0" + hour + j);
            newRow.children[j].setAttribute("class", "tablebodystyle t1");
            // newRow.children[j].dataset.dateTime = getdata.children[j].dataset.data + " " + hour;
        }

        ttable.appendChild(newRow);

    }
    rowToClone.setAttribute("hidden", "true");
   
};



//------------------------------------------------------------------//
//funkcja przeładowująca dane związane z datą i czasem w komórkach tabeli/ /

var reloadDataInTable = function () {
   var tableDatacels = document.getElementsByClassName("t1");
    var headTableData = document.getElementsByClassName("headRow");
    var columTableData = document.getElementsByClassName("tableofcolumn");
    
    console.log("2");
    
    var numbrerOfCels = 0;
    for (var i = 1; i < columTableData.length; i++) {

        var hour = columTableData[i].dataset.dataTime;

        for (var j = 0; j < headTableData.length; j++) {

            var date = headTableData[j].dataset.data;

            tableDatacels[numbrerOfCels].innerText ="" + date + " " + hour;
            tableDatacels[numbrerOfCels].dataset.datatime = date + " " + hour;
            numbrerOfCels = numbrerOfCels + 1;

        }

    }
};

//Aktualizacja daty w nagłówku//

var updateDate = function (table) {
    var setdata = document.querySelector('#data');
    console.log("1");
    for (var i = 0; i < 7; i++) {

        setdata.children[i + 1].dataset.data = table[i];
        setdata.children[i + 1].innerText = table[i];
    }

};

//Blokowanie zarezerwowanych terminów/

//var setReservedTerm = function (table) {
//    var tableDatacels = document.getElementsByClassName("tablebodystyle");
//    console.log("3");
//    console.log(tableDatacels);
//    for (var i = 0; i < tableDatacels.length; i++) {

//        var tem = tableDatacels[0].dataset.datatime;
//        console.log(tem);
//        for (var j = 0; j < table.length; j++) {

//            if (tableDatacels[i].dataset.dataTime === table[j]) {
//                tableDatacels[i].classList.remove("tablebodystyle");
//                tableDatacels[i].classList.add("tableheadstyletermreserved");
//                tableDatacels[i].classList.toggle('tablebodystyle');
//                // link.className = 'newClass1 newClass2';
//                //classList.add(className)
//            }

//        }
//    }
//};






//var getDateForRentTable = function () {
//    var firstDayOfWeek = document.querySelector('#firstDayOfWeek');
//    // var firstDayOfWeekValue = firstDayOfWeek.dataset.data.data;
//    $.ajax(
//        {
//            url: "/Rent/RentRoomTerm/",
//            data: {},
//            type: "POST",
//            dataType: "json",
//            success: function (data, xhr) {
//                console.log("dane z kontrolera" ,data);
                //var newDateValue = [];
                //var termReserved = [];
                //var termReservedLenght = 0;
                //var parameterbegin = data.hourPeriod[0];
                //var parameterend = data.hourPeriod[1];
                //parameterbegin = parseInt(parameterbegin, 10);
                //parameterend = parseInt(parameterend, 10);

                //for (var j = 0; j < data.dataTable.length; j++) {

                //    var newDateTemp = data.dataTable[j].split(" ");
                //    newDateValue[j] = newDateTemp[0];

                //    if (newDateTemp.length > 0) {

                //        var temp = "";
                //        for (var k = 1; k < newDateTemp.length; k++) {

                //            temp = newDateTemp[0] + " " + newDateTemp[k];
                //            termReserved[termReservedLenght] = temp;
                //            termReservedLenght = termReservedLenght + 1;

                //        }
                //    }

                //}
                //addRow(parameterbegin, parameterend);
                //updateDate(newDateValue);
                //reloadDataInTable();
                //setReservedTerm(termReserved);

//            },

//            error: function (xhr, ajaxOptons, thorownError) {
//                console.log(xhr.status);
//            }
//        });

//};


//----------------------------------------------------------------------//


//getDateForRentTable();

//Defincje zdarzen//



document.addEventListener("DOMContentLoaded", function () {
   




////--------------------------------------------------------------------------//


//    //-------------------------------------------------------------------------//
//    // Przewijanie tygodni w przod.

//    var nextWeek = document.querySelector('#next');
//    nextWeek.addEventListener("click", function () {


//        console.log("kliknieto next");
//    });

//    //-------------------------------------------------------------------------//
//    // Przewijanie tygodni w tył.

//    var previousWeek = document.querySelector('#previous');
//    previousWeek.addEventListener("click", function () {
//        var firstDayOfWeek = document.querySelector('#firstDayOfWeek');
//        var firstDayOfWeekValue = firstDayOfWeek.dataset.data.data;
//        $.ajax(
//            {
//                url: "/Rent/RentRoomTermData/",
//                data: { firstDayOfWeekValue },
//                type: "POST",
//                dataType: "json",
//                // success: updateDate,
//                success: function (data, xhr) {
//                    console.log(data);
//                    var newDateValue = [];
//                    var termReserved = [];
//                    var termReservedLenght = 0;

//                    for (var j = 0; j < data.length; j++) {

//                        var newDateTemp = data[j].split(" ");
//                        newDateValue[j] = newDateTemp[0];

//                        if (newDateTemp.length > 0) {

//                            var temp = "";
//                            for (var k = 1; k < newDateTemp.length; k++) {

//                                temp = newDateTemp[0] + " " + newDateTemp[k];
//                                termReserved[termReservedLenght] = temp;
//                                termReservedLenght = termReservedLenght + 1;

//                            }
//                        }

//                    }
//                    updateDate(newDateValue);
//                    reloadDataInTable();
//                    console.log(termReservedLenght);
//                    //  setReservedTerm(termReserved);

//                },

//                error: function (xhr, ajaxOptons, thorownError) {
//                    console.log(xhr.status);
//                }
//            });
//        reloadDataInTable();
//        console.log("kliknieto next");
//    });

    //var getDateForRentTable2 = function() {
    //    var firstDayOfWeek = document.querySelector('#firstDayOfWeek');
    //    var firstDayOfWeekValue = firstDayOfWeek.dataset.data.data;
    //    $.ajax(
    //        {
    //            url: "/Rent/RentRoomTermData/",
    //            data: { firstDayOfWeekValue },
    //            type: "POST",
    //            dataType: "json",
    //            // success: updateDate,
    //            success: function(data, xhr) {
    //                console.log(data.dataTable);
    //                console.log(data.hourpreiod);
    //                var newDateValue = [];
    //                var termReserved = [];
    //                var termReservedLenght = 0;
    //                var parameterbegin = data.hourpreiod[0];
    //                var parameterend = data.hourpreiod[1];
    //                parameterbegin = parseInt(parameterbegin, 10);
    //                parameterend = parseInt(parameterend, 10);

    //                for (var j = 0; j < data.dataTable.length; j++) {

    //                    var newDateTemp = data.dataTable[j].split(" ");
    //                    newDateValue[j] = newDateTemp[0];

    //                    if (newDateTemp.length > 0) {

    //                        var temp = "";
    //                        for (var k = 1; k < newDateTemp.length; k++) {

    //                            temp = newDateTemp[0] + " " + newDateTemp[k];
    //                            termReserved[termReservedLenght] = temp;
    //                            termReservedLenght = termReservedLenght + 1;

    //                        }
    //                    }

    //                }
    //                addRow(parameterbegin, parameterend);
    //                updateDate(newDateValue);
    //                reloadDataInTable();
    //                //console.log(termReservedLenght);
    //                //  setReservedTerm(termReserved);

    //            },

    //            error: function(xhr, ajaxOptons, thorownError) {
    //                console.log(xhr.status);
    //            }
    //        });

    //};


});


document.addEventListener("DOMSubtreeModified",
    function() {

        var setReservedTerm = function(table) {
            var tableDatacels = document.getElementsByClassName("tablebodystyle");
            console.log("3");

            console.log(table);
            for (var i = 0; i < tableDatacels.length; i++) {

                var tem = tableDatacels[i].dataset.datatime;
                console.log(tem);
                for (var j = 0; j < table.length; j++) {

                    if (tem === table[j]) {
                        console.log("jestem tu");
                        tableDatacels[i].classList.remove("tablebodystyle");
                        tableDatacels[i].classList.add("tableheadstyletermreserved");
                        //  tableDatacels[i].classList.className("tablebodystyle", "tableheadstyletermreserved");
                        //  tableDatacels[i].classList.toggle('tablebodystyle');
                        // link.className = 'newClass1 newClass2';
                        //classList.add(className)
                    }

                }
            }

        };

         var selectedListValue = function() {
                var selectList = document.querySelector('#selectRoom');
                console.log("jestem tu");
                console.log("clik selectList", selectList);
                var selectedValue = selectList.value;
                console.log("clik sselectedValue", selectedValue);

                return selectedValue;
          };

        

        var makeRoomReservation = document.getElementsByClassName("tablebodystyle");
            
            for (var i = 0; i < makeRoomReservation.length; i++) {

                makeRoomReservation[i].addEventListener("click",
                    function(e) {
                       var selectedValue1 = selectedListValue;

                        
                        var term = this.dataset.datatime;

                        //console.log("clik selectList", selectList1);
                       
                        $.ajax(
                            {
                                url: "/Rent/RentRoomReservationTerms/",
                                data: {
                                    term: term,
                                    Room: selectedValue1
                                },
                                type: "POST",
                                dataType: "json",
                                success: function (data) {
                                    console.log("dodano");

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
                                    console.log("rezeracja", termReserved);
                                    setReservedTerm(termReserved);

                                },

                                error: function(xhr, ajaxOptons, thorownError) {
                                    console.log(xhr.status);
                                }
                            });
                        e.stopImmediatePropagation();
                    });
            }

       
    });  
    




