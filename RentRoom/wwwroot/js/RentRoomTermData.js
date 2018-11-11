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

           // newRow.children[j].setAttribute("id", "0" + hour + j);
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
    console.log(tableDatacels);

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

        
//Rezerwowanie rerminow//
 var makeRoomReservation = document.getElementsByClassName("tablebodystyle");
            
 for (var i = 0; i < makeRoomReservation.length; i++) {
     makeRoomReservation[i].addEventListener("click",function (e) {
         var selectList = document.querySelector('#selectRoom');
         var selectedValue = selectList.value;
         var term = this.dataset.datatime;
         var temp = term.split(" ");
         if (confirm("Rezeracja sali " + selectedValue + " w dniu " + temp[0] + " godzina " + temp[1])) {

             $.ajax(
                 {
                     url: "/Rent/RentRoomReservationTerms/",
                     data: {
                         term: term,
                         Room: selectedValue
                     },
                     type: "POST",
                     dataType: "json",
                     success: function (data) {
                       //  window.location.replace("http://localhost/Rent/Index");
                       // window.location.;
                         setReservedTerm(data.reservTerms);
                     },

                     error: function(xhr, ajaxOptons, thorownError) {
                         console.log(xhr.status);
                     }

                 });
            // window.location.replace("/");
             e.stopImmediatePropagation();
         }

         e.stopImmediatePropagation();
     });
 }
 
 });  
    




