#pragma checksum "C:\Users\User\source\repos\PictureDatabase\PictureDatabase\Views\Users\ForgetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c56df717f5339ec664951ad0b5bf6e5d9589e3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_ForgetPassword), @"mvc.1.0.view", @"/Views/Users/ForgetPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/ForgetPassword.cshtml", typeof(AspNetCore.Views_Users_ForgetPassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c56df717f5339ec664951ad0b5bf6e5d9589e3d", @"/Views/Users/ForgetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37299be4461bc76a0eff10d41ee59873908e392", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_ForgetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\User\source\repos\PictureDatabase\PictureDatabase\Views\Users\ForgetPassword.cshtml"
  
    ViewData["Title"] = "ForgetPassword";

#line default
#line hidden
            BeginContext(52, 887, true);
            WriteLiteral(@"
<h2>Click the button to get the password link</h2>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js""></script>





   Email: <br />
<input type=""text""  id=""Email""><br><br>
<input type=""button"" id=""Save"" value=""Click"" />

<script>
    var Pass = {


        Useremail: ''

    }
    $(document).ready(function () {
        $(""#Save"").click(function () {

            Pass.Useremail = $('#Email').val();






            $.ajax({
                url: '/Users/SendLink',
                type: 'POST',
                data: Pass,
                success: function (data, textStatus, xhr) {
                    console.log(data);
                },
                error: function (xhr, textStatus, errorThrown) {
                    console.log(xhr);
                }
            });
        });
    });

</script>");
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