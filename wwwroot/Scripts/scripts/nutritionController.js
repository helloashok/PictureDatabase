var app = angular.module('nutritionApp', ['ngAria', 'ngMaterial', 'md.data.table', 'angularMoment']);
app.controller('nutritionController',

    ['$mdDialog', '$scope', '$http', 'moment', function ($mdDialog, $scope, $http, moment) {
 //angular.module('nutritionApp', ['ngAria', 'ngMaterial', 'md.data.table', 'angularMoment']).controller('nutritionController',

 //   ['$mdDialog', '$scope', '$http', 'moment', function($mdDialog, $scope, $http, moment) {
        'use strict';













        $scope.notused = "hello";

        console.log("this is before click", $scope.notused);

        $scope.somename = false;
     
        var bookmark;
        $scope.somevalue = [];
        
        $scope.searchtext = 'a';
        $scope.search = {
            searchclicked: false
        }
        $scope.check = function () {
            $scope.search.searchclicked = true;
        }
        $scope.checkagain = function () {
            $scope.search.searchclicked = false;
        }

        // these variables are for pagination 

        $http.get("/Event/GetAllEvents")
            .then(function (response) {
                $scope.somevalue = response.data;



                angular.forEach($scope.somevalue, function (item) {

                    item.formattedEndDate = moment(item.endDate).format('Do MMM YYYY');

                    item.formattedStartDate = moment(item.startDate).format('Do MMM YYYY');
                });



                // this is the length value for pagination
                //    $scope.length = response.data.length;



                console.log($scope.somevalue);

            });

        $scope.options = {
            autoSelect: true,
            boundaryLinks: true,
            //largeEditDialog: true,
            pageSelector: true,
            rowSelection: true
        };

        //$scope.$watch('length', function () {
        //    alert(length);
        //});



        $scope.selected = [];

        $scope.selectedrow = function () {
            console.log($scope.selected);
        };

        //$scope.filter = {
        //    options: {
        //        debounce: 500
        //    }
        //     };


        $scope.query = {

            limit: '5',
            order: 'name',
            page: 1
        };







        $scope.getDesserts = function () {
            $scope.desserts = $scope.desserts = {
                "count": 9,
                "data": [
                    {
                        "name": "Frozen yogurt",
                        "type": "Ice cream",
                        "calories": { "value": 159.0 },
                        "fat": { "value": 6.0 },
                        "carbs": { "value": 24.0 },
                        "protein": { "value": 4.0 },
                        "sodium": { "value": 87.0 },
                        "calcium": { "value": 14.0 },
                        "iron": { "value": 1.0 },
                        "comment": "Not as good as the real thing."
                    }, {
                        "name": "Ice cream sandwich",
                        "type": "Ice cream",
                        "calories": { "value": 237.0 },
                        "fat": { "value": 9.0 },
                        "carbs": { "value": 37.0 },
                        "protein": { "value": 4.3 },
                        "sodium": { "value": 129.0 },
                        "calcium": { "value": 8.0 },
                        "iron": { "value": 1.0 }
                    }, {
                        "name": "Eclair",
                        "type": "Pastry",
                        "calories": { "value": 262.0 },
                        "fat": { "value": 16.0 },
                        "carbs": { "value": 24.0 },
                        "protein": { "value": 6.0 },
                        "sodium": { "value": 337.0 },
                        "calcium": { "value": 6.0 },
                        "iron": { "value": 7.0 }
                    }, {
                        "name": "Cupcake",
                        "type": "Pastry",
                        "calories": { "value": 305.0 },
                        "fat": { "value": 3.7 },
                        "carbs": { "value": 67.0 },
                        "protein": { "value": 4.3 },
                        "sodium": { "value": 413.0 },
                        "calcium": { "value": 3.0 },
                        "iron": { "value": 8.0 }
                    }, {
                        "name": "Jelly bean",
                        "type": "Candy",
                        "calories": { "value": 375.0 },
                        "fat": { "value": 0.0 },
                        "carbs": { "value": 94.0 },
                        "protein": { "value": 0.0 },
                        "sodium": { "value": 50.0 },
                        "calcium": { "value": 0.0 },
                        "iron": { "value": 0.0 }
                    }, {
                        "name": "Lollipop",
                        "type": "Candy",
                        "calories": { "value": 392.0 },
                        "fat": { "value": 0.2 },
                        "carbs": { "value": 98.0 },
                        "protein": { "value": 0.0 },
                        "sodium": { "value": 38.0 },
                        "calcium": { "value": 0.0 },
                        "iron": { "value": 2.0 }
                    }, {
                        "name": "Honeycomb",
                        "type": "Other",
                        "calories": { "value": 408.0 },
                        "fat": { "value": 3.2 },
                        "carbs": { "value": 87.0 },
                        "protein": { "value": 6.5 },
                        "sodium": { "value": 562.0 },
                        "calcium": { "value": 0.0 },
                        "iron": { "value": 45.0 }
                    }, {
                        "name": "Donut",
                        "type": "Pastry",
                        "calories": { "value": 452.0 },
                        "fat": { "value": 25.0 },
                        "carbs": { "value": 51.0 },
                        "protein": { "value": 4.9 },
                        "sodium": { "value": 326.0 },
                        "calcium": { "value": 2.0 },
                        "iron": { "value": 22.0 }
                    }, {
                        "name": "KitKat",
                        "type": "Candy",
                        "calories": { "value": 518.0 },
                        "fat": { "value": 26.0 },
                        "carbs": { "value": 65.0 },
                        "protein": { "value": 7.0 },
                        "sodium": { "value": 54.0 },
                        "calcium": { "value": 12.0 },
                        "iron": { "value": 6.0 }
                    }
                ]
            };
            //$scope.promise = $nutrition.desserts.get($scope.query, success).$promise;
        };

        $scope.removeFilter = function () {
            $scope.filter.show = false;
            $scope.query.filter = '';

            if ($scope.filter.form.$dirty) {
                $scope.filter.form.$setPristine();
            }
        };

        $scope.$watch('query.filter', function (newValue, oldValue) {
            if (!oldValue) {
                bookmark = $scope.query.page;
            }

            if (newValue !== oldValue) {
                $scope.query.page = 1;
            }

            if (!newValue) {
                $scope.query.page = bookmark;
            }
            $scope.getDesserts();
        });


        //  the code which i modified 

        $scope.status = '  ';
        $scope.customFullscreen = false;

        $scope.showAlert = function (ev) {
            // Appending dialog to document.body to cover sidenav in docs app
            // Modal dialogs should fully cover application
            // to prevent interaction outside of dialog
            $mdDialog.show(
                $mdDialog.alert()
                    .parent(angular.element(document.querySelector('#popupContainer')))
                    .clickOutsideToClose(true)
                    .title('This is an alert title')
                    .textContent('You can specify some description text in here.')
                    .ariaLabel('Alert Dialog Demo')
                    .ok('Got it!')
                    .targetEvent(ev)
            );
        };

        $scope.showConfirm = function (ev) {
            // Appending dialog to document.body to cover sidenav in docs app
            var confirm = $mdDialog.confirm()
                .title('Would you like to delete your debt?')
                .textContent('All of the banks have agreed to forgive you your debts.')
                .ariaLabel('Lucky day')
                .targetEvent(ev)
                .ok('Please do it!')
                .cancel('Sounds like a scam');

            $mdDialog.show(confirm).then(function () {
                $scope.status = 'You decided to get rid of your debt.';
            }, function () {
                $scope.status = 'You decided to keep your debt.';
            });
        };

        $scope.showPrompt = function (ev) {
            // Appending dialog to document.body to cover sidenav in docs app
            var confirm = $mdDialog.prompt()
                .title('What would you name your dog?')
                .textContent('Bowser is a common name.')
                .placeholder('Dog name')
                .ariaLabel('Dog name')
                .initialValue('Buddy')
                .targetEvent(ev)
                .required(true)
                .ok('Okay!')
                .cancel('I\'m a cat person');

            $mdDialog.show(confirm).then(function (result) {
                $scope.status = 'You decided to name your dog ' + result + '.';
            }, function () {
                $scope.status = 'You didn\'t name your dog.';
            });
        };

        $scope.showAdvanced = function () {
            $scope.dispfileinput = false;
            $mdDialog.show({
                locals: { check: $scope.dispfileinput },
                controller: AddDialogController,
                templateUrl: 'dialog1.tmpl.html',
                parent: angular.element(document.body),
                //  targetEvent: ev,
                clickOutsideToClose: true,
                fullscreen: $scope.customFullscreen // Only for -xs, -sm breakpoints.
            })
                .then(function (answer) {
                    $scope.status = 'You said the information was "' + answer + '".';
                }, function () {
                    $scope.status = 'You cancelled the dialog.';
                });
        };

        $scope.showTabDialog = function (event, index) {
            $mdDialog.show({
                locals: { event: event, index: index, events: $scope.somevalue, length: $scope.length },
                controller: DialogController,
                templateUrl: 'tabDialog.tmpl.html',
                parent: angular.element(document.body),

                clickOutsideToClose: true
            })
                .then(function (answer) {

                    $scope.status = 'You said the information was "' + answer + '".';
                }, function () {
                    $scope.status = 'You cancelled the dialog.';
                });
        };



        $scope.showEdit = function (event) {

            $mdDialog.show({
                locals: { event: event, check: $scope.dispfileinput },
                controller: editDialogController,
                templateUrl: 'dialog1.tmpl.html',
                parent: angular.element(document.body),
                //  targetEvent: ev,
                clickOutsideToClose: true,
                fullscreen: $scope.customFullscreen // Only for -xs, -sm breakpoints.
            })
                .then(function (answer) {
                    $scope.status = 'You said the information was "' + answer + '".';
                }, function () {
                    $scope.status = 'You cancelled the dialog.';
                });
        };


        function DialogController($scope, event, index, events, length) {
            console.log('events ' + events.data);
            //  $scope.somevalue = event;
          



            console.log('index ' + index);
            $scope.hide = function () {
                $mdDialog.hide();
            };

            $scope.cancel = function () {
                $mdDialog.cancel();
            };

            $scope.something = function () {
                //api call to delete);

                var eventdata = $.param({
                    someevent: event.eventId

                });
                var config = {
                    headers: {
                        'Content-Type': 'application/x-www-form-urlencoded;charset=utf-8'


                    }
                }

                //$http.post('/Event/Delete', eventdata, config).then(function (response) {



                // console.log($scope.abc);
                //  });



                events.splice(index, 1);


                $scope.hide();

            }

            $scope.answer = function (answer) {
                $mdDialog.hide(answer);
            };
        }
        function editDialogController($scope, event, check) {


            console.log("this is from edit", check);
            check = false;

            $scope.sendeventid = {
                Eventid: event.eventId
            };

            var data = $.param({
                event: event.eventId

            });
            var config = {
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded;charset=utf-8;'
                }
            }

            $http.post('/Event/GetBase64', data, config).then(function (response) {
                $scope.photo = response.data;
                $scope.selectedPhoto = event.eventPhoto;



                console.log($scope.abc);
            });














            $scope.user = {
                name: event.eventName,

            };
            $scope.StartDate = new Date(event.startDate);

            $scope.EndDate = new Date(event.endDate);



            console.log(event.eventPhoto);


            $scope.hide = function () {
                $mdDialog.hide();
            };

            $scope.cancel = function () {
                $mdDialog.cancel();
            };

            $scope.something = function () {
                //api call to delete);



                //     console.log(this.somevalue);
                // events.data.splice(index, 1);
                $scope.hide();

            }

            $scope.answer = function (answer) {
                $mdDialog.hide(answer);
            };
        }

        function AddDialogController($scope, check) {
           
            check = true;

      
            $scope.filechange = function () {
                console.log("hey i am into the change");
          
            };
            $scope.Callapi = function () {

                var ObjectEvent = {

                    EventName: '',
                    OrganizationId: ''
                    
                };
                function getBase64(file) {
                    return new Promise((resolve, reject) => {
                        const reader = new FileReader();
                        reader.readAsDataURL(file);
                        reader.onload = () => resolve(reader.result);
                        reader.onerror = error => reject(error);
                    });
                }
               
                   



                ObjectEvent.EventName = $('#EventName').val();
                
               
                
               
                $.ajax({
                    url: '/Event/Create',
                    type: 'POST',
                    data: ObjectEvent,
                    success: function (data, textStatus, xhr) {
                        console.log(data);
                    },
                    error: function (xhr, textStatus, errorThrown) {
                        console.log(xhr);
                    }
                });

            };

            $scope.choosefile = function () {
                var file = document.querySelector('input[type="file"]').files[0];
            }

            $scope.hide = function () {
                $mdDialog.hide();
            };

            $scope.cancel = function () {
                $mdDialog.cancel();
            };

            $scope.something = function () {
                //api call to delete

                //splice
            }

            $scope.answer = function (answer) {
                $mdDialog.hide(answer);
            };
        }
        $scope.logPagination = function (page, limit) {
            $scope.pageindex = page;
            console.log('page: ', page);
            console.log('limit: ', limit);
        }
        $scope.deleteItem = function () {
            //   this.Events.data.splice(index, 1);
            console.log(index);


        }




    



    //}]).directive('chooseFile', function () {
    //    return {
    //        link: function ($scope, elem, attrs) {

    //            $scope.photovalue = false;
    //            $scope.fileName = "Defaultphoto";  
    //            $scope.fileLogoName = "LogoPhoto";
    //            var button = elem.find('button');
    //            var input = angular.element(elem[0].querySelector('input#fileInput'));
    //            button.bind('click', function () {
    //                input[0].click();
    //            });
    //            input.bind('change', function (e) {
    //                $scope.$apply(function () {
    //                    var files = e.target.files;
                       
    //                  if (files[0]) {
    //                      $scope.fileName = files[0].name;
    //                      $scope.photovalue = true;
                           
    //                    } else {
    //                      $scope.fileName = "Defaultphoto";
    //                      $scope.photovalue = false;
    //                    }
    //                });
    //            });
              
               
              
    //        }
    //    };
    //});


    }])
app.directive('chooseFile', function () {
        return {
            link: function ($scope, elem, attrs) {

                $scope.photovalue = false;
                $scope.fileName = "EventImage";  
                $scope.fileLogoName = "LogoPhoto";
                var button = elem.find('button');
                var input = angular.element(elem[0].querySelector('input#fileInput'));
                button.bind('click', function () {
                    input[0].click();
                });
                input.bind('change', function (e) {
                    $scope.$apply(function () {
                        var files = e.target.files;

                      if (files[0]) {
                          $scope.fileName = files[0].name;
                          var file = files[0]
                          getBase64(file).then(
                              function (data) {
                                  var abc = data.getBase64
                                  console.log("data", data);
                              });
                        

                          
                          $scope.photovalue = true;

                        } else {
                          $scope.fileName = "EventImage";
                          $scope.photovalue = false;
                        }
                    });
                });


                function getBase64(file) {
                    return new Promise((resolve, reject) => {
                        const reader = new FileReader();
                        reader.readAsDataURL(file);
                        reader.onload = () => resolve(reader.result);
                        reader.onerror = error => reject(error);
                    });
                }
           }
       };
});


app.directive('chooseLogo', function () {
    return {
        link: function ($scope, elem, attrs) {

            $scope.photovalue = false;
           
            $scope.logoName = "LogoImage";
            var button = elem.find('button');
            var input = angular.element(elem[0].querySelector('input#LogoInput'));
            button.bind('click', function () {
                input[0].click();
            });
            input.bind('change', function (e) {
                $scope.$apply(function () {
                    var files = e.target.files;

                    if (files[0]) {
                        $scope.logoName = files[0].name;
                        $scope.photovalue = true;

                    } else {
                        $scope.logoName = "LogoImage";
                        $scope.photovalue = false;
                    }
                });
            });



        }
    };
});


     































/**
Copyright 2018 Google LLC. All Rights Reserved. 
Use of this source code is governed by an MIT-style license that can be found
in the LICENSE file at http://material.angularjs.org/HEAD/license.
**/