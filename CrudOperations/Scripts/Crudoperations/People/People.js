angular.module("Kendo", ["kendo.directives"])
    .controller("MyCtrl", function ($scope) {
        $scope.mainGridOptions = {
            //dataSource: {
            //    type: "GET",
            //    transport: {
            //        read: "http://localhost:56427/odata/PeopleOdata",
            //        dataType: 'jsonp'
            //    }
            //},
            dataSource: [
                {
                    "PersonID": 1, "Name": "Nantha", "PhoneNumber": "9989899009", "Email": "nantha@gmail.com"
                }, {
                    "PersonID": 2, "Name": "Bala", "PhoneNumber": "7869875463", "Email": "bala@gmail.com"
                }, {
                    "PersonID": 3, "Name": "Sky", "PhoneNumber": "7654879643", "Email": "sky@gmail.com"
                }, {
                    "PersonID": 4, "Name": "June", "PhoneNumber": "89757896479", "Email": "june@gmail.com"
                }
            ],
            columns: [{
                field: PersonGridConstants.Name,
                title: "Name",
                headerAttributes: { "ng-non-bindable": true },
                width: "120px"
            }, {
                field: "PhoneNumber",
                title: "Phone Number",
                width: "120px"
            }, {
                field: "Email",
                width: "120px"
                //}, {
                //    width: "120px",
                //        command: {
                //            name: "details",
                //            click: function (e) {
                //                // prevent page scroll position change
                //                e.preventDefault();
                //                // e.target is the DOM element representing the button
                //                var tr = $(e.target).closest("tr"); // get the current table row (tr)
                //                // get the data bound to the current table row
                //                var data = this.dataItem(tr);
                //                console.log("Details for: " + data.Name);
                //                showDetails(data.Name);
                //            }
                //        },
                //    title: "Actions "
            }, {
                width: "120px",
                title: "Actions ",
                template: function (dataItem) {
                    return "<a href='http://localhost:60349/People/Edit/1'>Edit </a> <a href='http://localhost:60349/People/Details/1' > Details </a><a href='http://localhost:60349/People/Delete/1' > Delete </a>";
                }
            }]
        };
        function showDetails(selected) {
            alert(selected)
        };
    });