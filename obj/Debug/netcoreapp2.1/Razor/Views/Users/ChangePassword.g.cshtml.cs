#pragma checksum "C:\Users\User\source\repos\PictureDatabase\PictureDatabase\Views\Users\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6278bd67e1ab3217b9ce9653cce530903202ac0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_ChangePassword), @"mvc.1.0.view", @"/Views/Users/ChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/ChangePassword.cshtml", typeof(AspNetCore.Views_Users_ChangePassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6278bd67e1ab3217b9ce9653cce530903202ac0f", @"/Views/Users/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37299be4461bc76a0eff10d41ee59873908e392", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\User\source\repos\PictureDatabase\PictureDatabase\Views\Users\ChangePassword.cshtml"
  
    ViewData["Title"] = "ChangePassword";

#line default
#line hidden
            BeginContext(52, 1666, true);
            WriteLiteral(@"
<h2>ChangePassword</h2>


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js""></script>

OldPassword:<br />
<input type=""text"" data- id=""OldPassword"" ><br><br>
NewPassword:<br>
<input type=""password"" id=""NewPassword""  ><br><br>
RetypePassword:<br>
<input type=""password"" id=""RetypePassword""    >

<span id=""validate-status""> </span>
<br > <br >
<input type=""button"" id=""Save"" value=""Change"" />



<script>





    var Data = {

       NewPassword: '',
OldPassword: '',

    }
    $(document).ready(function () {
        $(""#RetypePassword"").keydown(validate);
    });


    function validate() {
        var password1 = $(""#NewPassword"").val();
        var password2 = $(""#RetypePassword"").val();



            if (password1 == password2) {
                $(""#validate-status"").text("""");
            }
            else {

                   $(""#validate-status"").text(""Password doesnot match"");
                }




        }





");
            WriteLiteral(@"



    $(document).ready(function () {
        $(""#Save"").click(function () {

            Data.OldPassword = $('#OldPassword').val();
            Data.NewPassword = $('#NewPassword').val();





            $.ajax({
                url: '/Users/ChangePassword',
                type: 'POST',
                data: Data,
                success: function (data, textStatus, xhr) {
                    console.log(data);
                },
                error: function (xhr, textStatus, errorThrown) {
                    console.log(xhr);
                }
            });
        });
    });

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
