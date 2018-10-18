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


var renmoveClassTableheadstyletermreserved = function () {
    var tableDatacels = document.getElementsByClassName("t1");
    for (var i = 0; i < tableDatacels.length; i++) {
        var temp2 = tableDatacels[i].classList;

        for (var k = 0; k < temp2.length; k++) {

            if (temp2[k] === "tableheadstyletermreserved") {

                tableDatacels[i].classList.toggle("tableheadstyletermreserved");
                tableDatacels[i].classList.toggle("tablebodystyle");
            }

        }
    }
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

//Defincje zdarzen//





document.addEventListener("DOMSubtreeModified", function() {

    //Blokowanie zarezerwownych terminów//

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

        
//Rezerwowanie rerminow//
 var makeRoomReservation = document.getElementsByClassName("tablebodystyle");
            
 for (var i = 0; i < makeRoomReservation.length; i++) {
     makeRoomReservation[i].addEventListener("click",function (e) {
        var selectedValue1 = selectedListValue;
        var term = this.dataset.datatime;
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
                        
                        setReservedTerm(data.reservTerms);
                    },

                 error: function(xhr, ajaxOptons, thorownError) {
                        console.log(xhr.status);
                 }
                });
                e.stopImmediatePropagation();
     });
 }
 
 });  
    




