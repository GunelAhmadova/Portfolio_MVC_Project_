#pragma checksum "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbd550cedb7ec2a253566532db1ce881bd591b3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Detail.cshtml")]
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
#nullable restore
#line 1 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.Domain.Models.Entites;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.Domain.AppCode.Bussines.PersonModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.Domain.AppCode.Bussines.SkillModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.Domain.AppCode.Bussines.BackgroundModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.Domain.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.Domain.Models.Entites.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.Domain.Models.Roles;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd550cedb7ec2a253566532db1ce881bd591b3c", @"/Areas/Admin/Views/User/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eabfd6c9350464ab2e867e7ec7fa979fbfd93f5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-2 col-form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/tab-control/tab-control.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/tab-control/tab-control.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Page-header start -->
<div class=""page-header"">
    <div class=""row align-items-end"">
        <div class=""col-lg-8"">
            <div class=""page-header-title"">
                <div class=""d-inline"">
                    <h4>Bootstrap Basic Tables</h4>
                    <span>
                        lorem ipsum dolor sit amet, consectetur adipisicing
                        elit
                    </span>
                </div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <div class=""page-header-breadcrumb"">
                <ul class=""breadcrumb-title"">
                    <li class=""breadcrumb-item"" style=""float: left;"">
                        <a href=""../index.html""> <i class=""feather icon-home""></i> </a>
                    </li>
                    <li class=""breadcrumb-item"" style=""float: left;"">
                        <a href=""#!"">Bootstrap Table</a>
                    </li>
                    <li class=""breadcrumb-item"" style=""float");
            WriteLiteral(@": left;"">
                        <a href=""#!"">Basic Table</a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- Page-header end -->

<div class=""page-body"">
    <div class=""card"">
        <div class=""card-header"">
            <h5>Basic Table</h5>
            <span>use class <code>table</code> inside table element</span>
        </div>
        <div class=""card-block table-border-style"">
            <div class=""card-block"">
                <h4 class=""sub-title"">Basic Inputs</h4>
                <div>
                    <div class=""form-group row"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd550cedb7ec2a253566532db1ce881bd591b3c9293", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 52 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"col-sm-10\">\r\n                            <p class=\"form-control\">\r\n                                ");
#nullable restore
#line 55 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 55 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                                       Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd550cedb7ec2a253566532db1ce881bd591b3c11712", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 60 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"col-sm-10\">\r\n");
#nullable restore
#line 62 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                             if (Model.EmailConfirmed)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-success\">");
#nullable restore
#line 64 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                                                             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 65 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-warning\">");
#nullable restore
#line 68 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                                                             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 69 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd550cedb7ec2a253566532db1ce881bd591b3c15089", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 73 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhoneNumber);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"col-sm-10\">\r\n");
#nullable restore
#line 75 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                             if (Model.PhoneNumberConfirmed)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-success\">");
#nullable restore
#line 77 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                                                             Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 78 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-warning\">");
#nullable restore
#line 81 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                                                             Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 82 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-group row"">
                        <div class=""tab-control w-100"" role=""tabcontrol"">
                            <div class=""tab-page"" id=""roles"" aria-title=""Rollar"" selected>
                                <table class=""table table-hover"">
                                    <tbody>
");
#nullable restore
#line 90 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                                         foreach (AvailableRole item in ViewBag.AvailableRoles)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <tr>
                                                <td>
                                                    <input class=""role-selector checkbox""
                                                           data-role-name=""");
#nullable restore
#line 95 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                                                                      Write(item.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                                           data-user-id=\"");
#nullable restore
#line 96 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                                                                    Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("id", "\r\n                                                           id=\"", 4195, "\"", 4274, 1);
#nullable restore
#line 97 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
WriteAttributeValue("", 4260, item.RoleName, 4260, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                                           type=\"checkbox\"\r\n                                                           ");
#nullable restore
#line 99 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                                                       Write(item.Selected ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" />\r\n                                                    <label");
            BeginWriteAttribute("for", " for=\"", 4508, "\"", 4528, 1);
#nullable restore
#line 100 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
WriteAttributeValue("", 4514, item.RoleName, 4514, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 100 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                                                                           Write(item.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 103 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n                            <div class=\"tab-page\" id=\"principals\" aria-title=\"S??lahiyy??tl??r\">\r\n\r\n");
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <div class=\"col-12 d-flex justify-content-end\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd550cedb7ec2a253566532db1ce881bd591b3c22692", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <button class=\"publish\">salam</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("addcss", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dbd550cedb7ec2a253566532db1ce881bd591b3c24263", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <style>
        input[type=checkbox].checkbox {
            display: none;
        }

            input[type=checkbox].checkbox + label {
                position: relative;
                padding-left: 25px;
            }

                input[type=checkbox].checkbox + label::before {
                    content: """";
                    font-size: 0.7em;
                    font-weight: 900;
                    font-family: ""Font Awesome 5 Free"";
                    position: absolute;
                    border: 1px solid #cccccc85;
                    width: 18px;
                    height: 18px;
                    border-radius: 2px;
                    top: 50%;
                    left: 0px;
                    transform: translateY(-50%);
                    text-align: center;
                    text-indent: 1px;
                    line-height: 1.7em;
                }

        input[type=checkbox]:checked.checkbox + label::before {
            content: ""\f");
                WriteLiteral("00c\";\r\n            color: #ffffff;\r\n            background-color: teal;\r\n            border-color: teal;\r\n        }\r\n    </style>\r\n");
            }
            );
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd550cedb7ec2a253566532db1ce881bd591b3c26766", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        $(document).ready(function() {
            $('.role-selector').change(function (e) {
                const body = $(e.currentTarget).data();
                body.selected = $(e.currentTarget).is(':checked');

                $.ajax({
                    type: ""POST"",
                    url: '");
#nullable restore
#line 196 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Detail.cshtml"
                     Write(Url.Action("SetRole"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    data: body,
                    contentType: 'application/x-www-form-urlencoded',
                    success: function (response) {
                        console.log(response)

                        if (response.error == false) {
                            toastr.success(response.message, ""Ugur!"");
                        }
                        else {
                            $(e.currentTarget).prop('checked', !body.selected);
                            toastr.error(response.message, ""X??ta!"");
                        }
                    },
                    error: function(response) {
                        $(e.currentTarget).prop('checked', !body.selected);
                        toastr.error('Sistem xetasi biraz sonra yeniden yoxlayin', ""X??ta!"");
                    }
                });
            });


");
                WriteLiteral("        });\r\n    </script>\r\n    \r\n       \r\n    \r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
