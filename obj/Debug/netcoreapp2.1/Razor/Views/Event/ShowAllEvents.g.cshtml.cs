#pragma checksum "C:\Users\User\source\repos\PictureDatabase\PictureDatabase\Views\Event\ShowAllEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "848b225a5616c47cc3a4daf759ec92b4857cabf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_ShowAllEvents), @"mvc.1.0.view", @"/Views/Event/ShowAllEvents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/ShowAllEvents.cshtml", typeof(AspNetCore.Views_Event_ShowAllEvents))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"848b225a5616c47cc3a4daf759ec92b4857cabf5", @"/Views/Event/ShowAllEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37299be4461bc76a0eff10d41ee59873908e392", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_ShowAllEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/dist/dialog-box-inputs.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/angular/angular-material.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/scripts/md-data-table.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/dist/app.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/dist/Dialogbox.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/scripts/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/scripts/nutritionController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/scripts/md-data-table.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/scripts/addItemController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(2, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5fc4557ee8874cb397b4a7149eb09e47", async() => {
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
            BeginContext(71, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\User\source\repos\PictureDatabase\PictureDatabase\Views\Event\ShowAllEvents.cshtml"
  
    ViewData["Title"] = "ShowAllEvents";

#line default
#line hidden
            BeginContext(124, 26, true);
            WriteLiteral("<title>Nutrition</title>\r\n");
            EndContext();
            BeginContext(150, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71c0e0fa19a04c5986b8211a2a644129", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(225, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(229, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e81353360dff4ccbb0111038439fe977", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(297, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(299, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6219573b2e86441ab9df99094aff511d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(354, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(434, 92, true);
            WriteLiteral("\r\n<link href=\"https://fonts.googleapis.com/icon?family=Material+Icons\" rel=\"stylesheet\">\r\n\r\n");
            EndContext();
            BeginContext(526, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5dabc873ecd341fabf7808e7c5ef66e4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(587, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(591, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3493b26e36c2478fbd7e84d501b11ea3", async() => {
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
            BeginContext(660, 192, true);
            WriteLiteral("\r\n<div ng-app=\"nutritionApp\" ng-cloak>\r\n\r\n\r\n    <div layout=\"column\" class=\"layout-column \">\r\n        <div layout=\"column\" class=\"layout-column md-dialog-is-showing\" ng-show=\"!tool.checked\">\r\n");
            EndContext();
            BeginContext(1059, 240, true);
            WriteLiteral("\r\n\r\n\r\n            <md-content layout=\"column\" flex ng-controller=\"nutritionController\">\r\n\r\n                <md-card>\r\n                    <md-toolbar class=\"md-table-toolbar md-default\" ng-show=\"!search.searchclicked\" aria-hidden=\"false\">\r\n");
            EndContext();
            BeginContext(1435, 69, true);
            WriteLiteral("\r\n                        <div class=\"md-toolbar-tools search-bar\">\r\n");
            EndContext();
            BeginContext(1570, 105, true);
            WriteLiteral("                            <span>EventsList</span>\r\n\r\n\r\n                            <span flex></span>\r\n");
            EndContext();
            BeginContext(1876, 508, true);
            WriteLiteral(@"                            <md-button class=""md-icon-button"" ng-click=""check()"">
                                <md-icon class=""add-icon-hover"">search_circle</md-icon>
                            </md-button>


                            <md-button ng-click=""showAdvanced(  )"" style=""min-width:0px"">
                                <md-icon class=""add-icon-hover"">add_circle</md-icon>
                            </md-button>


                        </div>
                    </md-toolbar>
");
            EndContext();
            BeginContext(2459, 176, true);
            WriteLiteral("\r\n\r\n\r\n                    <md-toolbar class=\"md-table-toolbar md-default\" ng-show=\"search.searchclicked\">\r\n                        <div class=\"md-toolbar-tools search-bar\">\r\n\r\n");
            EndContext();
            BeginContext(2842, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3085, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3288, 633, true);
            WriteLiteral(@"


                            <!-- Input Text -->
                            <md-input-container flex>
                                <label for=""search"" style=""margin-bottom:0px"">Search</label>

                                <input id=""search-input"" type=""text"" ng-model=""test"" />
                            </md-input-container>

                            <md-button class=""md-icon-button"" ng-click=""checkagain()"">
                                <md-icon>close</md-icon>
                            </md-button>




                        </div>



                    </md-toolbar>








");
            EndContext();
            BeginContext(3967, 110, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                    <md-toolbar class=\"md-table-toolbar alternate\" ng-show=\" \" aria-hidden=\"true\">\r\n");
            EndContext();
            BeginContext(4206, 504, true);
            WriteLiteral(@"
                        <div class=""md-toolbar-tools"">
                            <span>{{selected.length}} {{selected.length > 1 ? 'Events' : 'Event'}} selected</span>
                            <span flex></span>
                            <md-button class=""md-icon-button"">
                                <md-icon>delete</md-icon>
                            </md-button>
                        </div>
                    </md-toolbar>
                    <md-table-container>




");
            EndContext();
            BeginContext(4969, 834, true);
            WriteLiteral(@"
                        <table data-md-table data-md-on-select=""log"" md-on-deselect=""deselect"" data-ng-model=""selected"" md-progress=""promise"">
                            <thead ng-if=""!options.decapitate"" md-head data-md-order=""query.order"" md-on-reorder=""onReorder"">

                                <tr md-row>

                                    <th md-column md:order:by=""eventName""><span>Name</span></th>


                                    <th md-column md:order:by=""startDate""><span>StartDate</span></th>


                                    <th md-column md:order:by=""endDate""><span>EndDate</span></th>


                                    <th md-column><span>Action</span></th>
                                </tr>
                            </thead>
                            <tbody md-body>

");
            EndContext();
            BeginContext(6081, 310, true);
            WriteLiteral(@"                                <tr md-select-id=""name"" data-md-on-select=""log"" md-on-deselect=""deselect"" x-md-auto-select=""options.autoSelect""
                                    data-ng-repeat=""event in somevalue|filter:test|  orderBy: query.order   |limitTo:query.limit:(query.page - 1) * query.limit"">

");
            EndContext();
            BeginContext(6670, 3341, true);
            WriteLiteral(@"


                                    <td md-cell>{{event.eventName}}</td>
                                    <td md-cell>{{event.formattedStartDate}}</td>
                                    <td md-cell>{{event.formattedEndDate}}</td>

                                    <td md-cell>
                                        <md-button ng-click=""showEdit(event)"" class=""md-icon-button"">
                                            <md-icon class=""icon-hover"">edit</md-icon>
                                        </md-button>
                                        <md-button ng-click=""showTabDialog(event,$index)"" class=""md-icon-button"">
                                            <md-icon class=""icon-hover"">delete</md-icon>

                                        </md-button>


                                    </td>









                                </tr>
                            </tbody>
                        </table>
                    </md-table-container>

");
            WriteLiteral(@"
                    <data-md-table-pagination md-limit=""query.limit"" md-limit-options=""limitOptions"" md-page=""query.page"" md-total=""{{somevalue.length}}"" md-page-select=""options.pageSelect"" md-boundary-links=""options.boundaryLinks"" md-on-paginate=""page"">
                        <div class=""page-select"">
                            <div class=""label"">Page:</div>

                            <md-select virtual-page-select="""" total=""233"" class=""md-table-select ng-pristine ng-untouched ng-valid"" ng-model=""$pagination.page"" md-container-class=""md-pagination-select"" ng-change=""$pagination.onPaginationChange()"" ng-disabled=""$pagination.disabled"" aria-label=""Page: 1"" role=""listbox"" aria-expanded=""false"" aria-multiselectable=""false"" id=""select_2"" aria-owns=""select_container_3"" aria-disabled=""false"" tabindex=""0"" aria-invalid=""false"">
                                <md-select-value class=""md-select-value"" id=""select_value_label_0"">
                                    <span>
                                     ");
            WriteLiteral(@"   <span class=""md-text"">1</span>
                                    </span>
                                    <span class=""md-select-icon"" aria-hidden=""true""></span>
                                </md-select-value><div class=""md-select-menu-container md-pagination-select"" aria-hidden=""true"" id=""select_container_3"">

                                </div>
                            </md-select>
                        </div>


                    </data-md-table-pagination>





                </md-card>

            </md-content>
        </div>
    </div>









    <script type=""text/ng-template"" id=""dialog1.tmpl.html"">
        <md-dialog aria-label=""Mango (Fruit)"">
            <form ng-cloak style=""width:100%"">

                <md-toolbar>
                    <div class=""md-toolbar-tools"">
                        <h2>Create Event</h2>
                        <span flex></span>
                        <md-button class=""md-icon-button"" ng-click=""cancel()"">

 ");
            WriteLiteral(@"                           <md-icon class=""material-icons"">clear</md-icon>


                        </md-button>
                    </div>
                </md-toolbar>

                <md-dialog-content>
                    <div class=""md-dialog-content"">
");
            EndContext();
            BeginContext(10046, 286, true);
            WriteLiteral(@"
                        <div flex-gt-xs style=""width:100%"">
                            <md-input-container class=""md-icon-float md-block"">
                                <!-- Use floating label instead of placeholder -->
                                <label>EventName</label>
");
            EndContext();
            BeginContext(10398, 198, true);
            WriteLiteral("                                <md-icon class=\"account-icon\">account_circle</md-icon>\r\n                                <input id=\"EventName\" class=\"input-insert\" ng-model=\"user.name\" type=\"text\">\r\n");
            EndContext();
            BeginContext(10671, 541, true);
            WriteLiteral(@"                            </md-input-container>

                        </div>

                        <div flex-gt-xs class=""div-datepicker"">

                            <md-datepicker class="""" ng-model=""StartDate"" md-placeholder=""EventStartDate""></md-datepicker>

                        </div>


                        <div flex-gt-xs style=""padding-top:30px;width:100%"">
                            <md-datepicker ng-model=""EndDate"" md-placeholder=""EventEndDate""></md-datepicker>

                        </div>


");
            EndContext();
            BeginContext(11296, 124, true);
            WriteLiteral("\r\n                        <div flex-gt-xs class=\"input-file-container\" ng-show=\"false\">\r\n                            <div>\r\n");
            EndContext();
            BeginContext(11587, 142, true);
            WriteLiteral("                                <md-icon class=\"md-icon\">insert_photo</md-icon>\r\n\r\n                                <input type=\'file\' />\r\n\r\n\r\n");
            EndContext();
            BeginContext(11988, 72, true);
            WriteLiteral("                            </div>\r\n\r\n                        </div>\r\n\r\n");
            EndContext();
            BeginContext(12098, 289, true);
            WriteLiteral(@"
                        <div flex-gt-xs style=""width:100%"">
                            <md-input-container class=""watermark-inputcont "">
                                <!-- Use floating label instead of placeholder -->
                                <label>EventWatermark</label>
");
            EndContext();
            BeginContext(12453, 183, true);
            WriteLiteral("                                <md-icon class=\"account-icon\">account_circle</md-icon>\r\n                                <input class=\"input-insert\" ng-model=\"user.name\" type=\"text\">\r\n");
            EndContext();
            BeginContext(12711, 87, true);
            WriteLiteral("                            </md-input-container>\r\n\r\n                        </div>\r\n\r\n");
            EndContext();
            BeginContext(12840, 290, true);
            WriteLiteral(@"
                        <div flex-gt-xs class=""input-file-container"" ng-show=""true "">

                            <choose-file>
                                <div>
                                    <md-button class=""md-datepicker-button md-icon-button md-button md-ink-ripple"">
");
            EndContext();
            BeginContext(13229, 346, true);
            WriteLiteral(@"
                                        <md-icon class=""file-attachment"">attach_file</md-icon>
                                    </md-button>

                                    <input id=""fileInput"" type=""file"" onchange=""readURL(this);"" ng-model=""confirmed"" class=""ng-hide"" >

                                    <md-input-container>
");
            EndContext();
            BeginContext(13646, 576, true);
            WriteLiteral(@"                                        <input type=""text"" class=""input-field-edit "" ng-model=""fileName"" id=""imgInp"" disabled>


                                    </md-input-container>
                                </div>
                            </choose-file>



                            <div style=""text-align:center"">

                                <img src=""data:image/*;base64,{{photo}}"" ng-show=""!photovalue"" />
                                <img id=""blah"" src="""" alt=""yourimage"" ng-show=""photovalue"" />
                            </div>

");
            EndContext();
            BeginContext(14274, 203, true);
            WriteLiteral("\r\n\r\n                            <choose-logo>\r\n                                <div>\r\n                                    <md-button class=\"md-datepicker-button md-icon-button md-button md-ink-ripple\">\r\n");
            EndContext();
            BeginContext(14576, 324, true);
            WriteLiteral(@"
                                        <md-icon class=""file-attachment"">attach_file</md-icon>
                                    </md-button>

                                    <input id=""LogoInput"" type=""file"" onchange=""readLogo(this)"" class=""ng-hide"">

                                    <md-input-container>
");
            EndContext();
            BeginContext(14971, 455, true);
            WriteLiteral(@"                                        <input type=""text"" class=""input-field-edit "" ng-model=""logoName"" id=""imgInp"" disabled>


                                    </md-input-container>
                                </div>
                            </choose-logo>
                            <div style=""text-align:center"">


                                <img id=""image"" src="""" alt=""yourimage"" />
                            </div>


");
            EndContext();
            BeginContext(15476, 3264, true);
            WriteLiteral(@"
                        </div>


                        <div flex-gt-xs class=""flexforbutton"">

                            <md-button  class=""md-btn-submit"" ng-click=""Callapi()"" >Create</md-button>

                        </div>

                    </div>
                </md-dialog-content>




            </form>
        </md-dialog>
    </script>

    <script type=""text/ng-template"" id=""tabDialog.tmpl.html"">


        <md-dialog aria-label=""Mango (Fruit)"">
            <form ng-cloak>
                <md-toolbar>
                    <div class=""md-toolbar-tools"">
                        <h2>Confirm</h2>
                        <span flex></span>
                        <md-button class=""md-icon-button"" ng-click=""cancel()"">

                            <md-icon class=""add-icon-hover"">clear</md-icon>


                        </md-button>
                    </div>
                </md-toolbar>

                <md-dialog-content>
                    <div class=""md-");
            WriteLiteral(@"dialog-content"">
                        <div>
                            <h2>Are you sure you want to delete ?</h2>

                            <md-button class=""conformation-button"" ng-click=""something()"">Yes</md-button>

                            <md-button class=""conformation-button"" ng-click=""cancel()"">No</md-button>







                        </div>
                    </div>
                </md-dialog-content>




            </form>
        </md-dialog>


    </script>





</div>

<script>

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

    $(document).ready(function () {

        $(""#fileInput"").on('change',");
            WriteLiteral(@" function () {
            var file = document.querySelector('input[type=""file""]').files[0];
            //    console.log($(this).val());



            // var file = document.querySelector('#myfile > input[type=""file""]').files[0];
            getBase64(file).then(
                function (data) {
                    var abc = data.getBase64;





                    //       ObjectData.EventPhoto = data
                    console.log('this is the string', abc);

                }




            );
        });
    });




    $(document).ready(function () {
        $(""#save"").click(function () {

            ObjectEvent.EventName = $('#EventName').val();

            ObjectEvent.OrganizationId = '7C88CB02-BEF6-48C9-BBFE-29EA1A421A33';

            $.ajax({
                url: '/Event/Create',
                type: 'POST',
                data: ObjectEvent,
                success: function (data, textStatus, xhr) {
                    console.log(data);
        ");
            WriteLiteral("        },\r\n                error: function (xhr, textStatus, errorThrown) {\r\n                    console.log(xhr);\r\n                }\r\n            });\r\n        });\r\n    });\r\n</script>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(18740, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc64ba8190cf4c1a9319c9cb075e01ed", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(18788, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(18792, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c0b70cb2be438798cdf7405e359f07", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(18856, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(18860, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3503eefd6ff46949f9f93e7074a6bda", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(18918, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(18920, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f8c87515fd74a59a67e810dc84964ca", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(18982, 18, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
