#pragma checksum "C:\Users\User\source\repos\PictureDatabase\PictureDatabase\Views\Users\ShowImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd6a4759f035f93ad6a1e91517518bda752418e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_ShowImages), @"mvc.1.0.view", @"/Views/Users/ShowImages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/ShowImages.cshtml", typeof(AspNetCore.Views_Users_ShowImages))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\User\source\repos\PictureDatabase\PictureDatabase\Views\_ViewImports.cshtml"
using PictureDatabase;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\PictureDatabase\PictureDatabase\Views\_ViewImports.cshtml"
using PictureDatabase.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd6a4759f035f93ad6a1e91517518bda752418e", @"/Views/Users/ShowImages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37299be4461bc76a0eff10d41ee59873908e392", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_ShowImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sidemenu-picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/backgrounds/soch_college.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\User\source\repos\PictureDatabase\PictureDatabase\Views\Users\ShowImages.cshtml"
  
    ViewData["Title"] = "ShowImages";

#line default
#line hidden
            BeginContext(48, 318, true);
            WriteLiteral(@"


<style>
    .carddemoBasicUsage .card-media {
        background-color: #999999;
    }
</style>


<div id=""sidebar"" class=""sidenav"">

    <div style=""background-color:#EC8B5E;height: 150px;text-align:center"">

        <md-icon class=""sidebar-cancel"" onclick=""closeNav()"">cancel</md-icon>


        ");
            EndContext();
            BeginContext(366, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28414da9b76e45cd97a022ccc0da29d8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(446, 5058, true);
            WriteLiteral(@"


        <h2 style=""color: white"">PictureContest</h2>


    </div>

</div>

<div class=""main-body"" ng-app=""cardDemo1"" ng-controller=""somectrl"">
    <div class=""md-toolbar-tools search-bar"">
        <md-input-container flex>
            <label for=""search"" style=""margin-bottom:0px"">Search</label>

            <input id=""search-input"" type=""text"" ng-model=""test"" />
        </md-input-container>

        <md-button class=""md-icon-button"" ng-click=""checkagain()"">
            <md-icon>close</md-icon>
        </md-button>
    </div>



    <md-content class=""md-padding"" layout-xs=""column"" layout=""column"">
        <div id=""abc"" flex-xs flex-gt-xs=""50"" layout=""column"">

            <md-card id=""bcd"" class="""" data-ng-repeat=""datas in somevalue|filter:test"" ng-click=""somefunction()"">
                <md-card-title>
                    <md-card-title-text>
                        <span class=""md-headline"">Username:{{datas.userName}}</span>
                        <span class=""md-subhead");
            WriteLiteral(@""">Large</span>
                    </md-card-title-text>
                    <md-card-title-media>
                        <div class=""show-images-imageview"">
                            <img style=""width:179px"" src={{}} />
                        </div>
                    </md-card-title-media>
                </md-card-title>

            </md-card>

        </div>

    </md-content>

</div>
<script src=""https://code.jquery.com/jquery-1.10.2.js""></script>





<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.5.8/angular.min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.5.8/angular-animate.min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.5.8/angular-aria.min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.5.8/angular-messages.min.js""></script>


<script>
    angular.module('cardDemo1', ['ngMaterial'])

        .controller('somectrl', ['$scope', '$http', function ($scope, $");
            WriteLiteral(@"http) {
            $scope.limit = 3;
            $scope.pageindex = 0;
            $http.get(""/Users/UsersList?pageindex="" + $scope.pageindex)
                .then(function (response) {

                    $scope.somevalue = response.data;






                    // this is the length value for pagination
                    //    $scope.length = response.data.length;



                    console.log($scope.somevalue);

                });
        
            $scope.testdata = {

                data: [{
                    count: ""Ramesh"",
                    imagepath: ""/assets/testwatermark/cc301755-93f3-474d-892e-d98bbad1c1d2.jpeg""
                },
                {
                    count: ""Suresh"",
                    imagepath: ""/assets/testwatermark/landscape2.png""
                },

                {
                    count: ""Mahesh"",

                    imagepath: ""/assets/testwatermark/landscape4watermark.png""
                },
                ");
            WriteLiteral(@"{
                    count: ""Mahesh"",

                    imagepath: ""/assets/testwatermark/landscape4watermark.png""
                },
                {
                    count: ""Mahesh"",

                    imagepath: ""/assets/testwatermark/landscape4watermark.png""
                },

                ]
            };


            $(window).scroll(function () {
             

                if ((window.innerHeight + window.scrollY) >= document.body.scrollHeight) {
                    $scope.pageindex = $scope.pageindex + 1;
                    console.log(""this is the value of count"", $scope.pageindex);
                    $http.get(""/Users/UsersList?pageindex=""+$scope.pageindex)
                        .then(function (response) {
                           
                      //      $scope.somevalue =  response.data
                           
                            console.log(""this is fter pushing"", $scope.somevalue);
                            Array.prototype.p");
            WriteLiteral(@"ush.apply($scope.somevalue, response.data);


                          


                            // this is the length value for pagination
                            //    $scope.length = response.data.length;



                            console.log($scope.somevalue);

                        });
                }


            });


        }])
                                //.config(function ($mdThemingProvider) {
                                //    $mdThemingProvider.theme('dark-grey').backgroundPalette('grey').dark();
                                //    $mdThemingProvider.theme('dark-orange').backgroundPalette('orange').dark();
                                //    $mdThemingProvider.theme('dark-purple').backgroundPalette('deep-purple').dark();
                                //    $mdThemingProvider.theme('dark-blue').backgroundPalette('blue').dark();
                                //});
</script>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591