#pragma checksum "C:\Users\User\source\repos\PictureDatabase\PictureDatabase\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2cfe08bb4638c2295ef4c46cbd7daca16135567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2cfe08bb4638c2295ef4c46cbd7daca16135567", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37299be4461bc76a0eff10d41ee59873908e392", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\User\source\repos\PictureDatabase\PictureDatabase\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            BeginContext(50, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(55, 17, false);
#line 4 "C:\Users\User\source\repos\PictureDatabase\PictureDatabase\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(72, 2388, true);
            WriteLiteral(@"</h2>
<link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">


<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css"">
<p>Use this page to detail your site's privacy policy.</p>
<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.7.4/angular.min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.7.4/angular-animate.min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.7.4/angular-aria.min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.7.4/angular-messages.min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/angular_material/1.1.10/angular-material.min.js""></script>
<!-- Compiled and minified CSS -->



<script src=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js""></script>
<script type=""text/javascript"">

    var app = angular.module('myApp', ['ngMaterial']);//depend");
            WriteLiteral(@"ency
    app.controller('newone', function ($scope) {
        $scope.firstname = '';

    });


    var map = angular.module('appSvgIconSets', ['ngMaterial'])
        .controller('DemoCtrl', function ($scope) { })
        .config(function ($mdIconProvider) {
            $mdIconProvider
                .iconSet('social', 'img/icons/sets/social-icons.svg', 24)
                .defaultIconSet('img/icons/sets/core-icons.svg', 24);
        });
</script>

<!--<md-icon class=""material-icons"" style=""padding: 200px;font-size:200px ;width:50%"">account_circle</md-icon>-->




<div ng-controller=""newone"">
    <md-input-container style=""align-content:center"">
        <md-icon class=""material-icons""  style=""font-size:25px"">account_circle</md-icon>
        <label style=""font-size:20px"">Username</label>

        <input type=""text""   ng-model=""firstname"">


    </md-input-container>
</div>








<div ng-controller=""newone"">
    <md-input-container class=""md-icon-float"">

        
 ");
            WriteLiteral(@"       <md-icon class=""material-icons"" style=""font-size:20px"">security</md-icon>
        <label style=""font-size:25px"">Password</label>
        <input type=""password"" ng-model=""firstname"">

    </md-input-container>
</div>
<div ng-controller=""newone"">
    <md-button class=""md-accent md-raised"">SignIn</md-button>
</div>





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
