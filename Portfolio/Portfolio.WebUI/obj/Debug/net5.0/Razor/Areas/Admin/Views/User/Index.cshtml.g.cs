#pragma checksum "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a467cafc7bb277856e3246599fb65c07360c3079"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a467cafc7bb277856e3246599fb65c07360c3079", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eabfd6c9350464ab2e867e7ec7fa979fbfd93f5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedViewModel<AppUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/sweetalert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

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
                    <li class=""breadcrumb-item"" style=""float: ");
            WriteLiteral(@"left;"">
                        <a href=""#!"">Users</a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>

<div class=""page-body"">
    <!-- Basic table card start -->
    <div class=""card"">
        <div class=""card-header"">
            <h5>Basic Table</h5>
            <span>use class <code>table</code> inside table element</span>

        </div>
        <div class=""card-block table-border-style"">
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Email</th>
                            <th>PhoneNumber</th>
                            <th class=""operation"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a467cafc7bb277856e3246599fb65c07360c30798927", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-plus\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 63 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml"
                         foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 66 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 66 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml"
                                          Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 68 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml"
                                     if (item.EmailConfirmed)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"badge badge-success\">");
#nullable restore
#line 70 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml"
                                                                     Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 71 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"badge badge-warning\">");
#nullable restore
#line 74 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml"
                                                                     Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 75 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 77 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml"
                               Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"operation\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a467cafc7bb277856e3246599fb65c07360c307913542", async() => {
                WriteLiteral("\r\n                                        <i class=\"fa fa-eye\"></i>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml"
                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 84 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a467cafc7bb277856e3246599fb65c07360c307916481", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        //function removeEntity(e, id, name) {
        //    e.preventDefault();

        //    swal({
        //        title: ""Diqqət!"",
        //        text: `${name} - silinsinmi?`,
        //        icon: ""warning"",
        //        buttons: ['Xeyr','Bəli'],
        //        dangerMode: true,
        //    })
        //        .then((willDelete) => {
        //            if (willDelete) {

        //                $.ajax({
        //                    url:`");
#nullable restore
#line 111 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Areas\Admin\Views\User\Index.cshtml"
                              Write(Url.Action("Remove"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/${id}`,
        //                    type:""POST"",
        //                    success: function(response) {
        //                        console.log(response);

        //                        if (response.error == false)
        //                        {
        //                          toastr.success(response.message, ""Ugur!"");
        //                          window.location.reload();
        //                        }
        //                        else{
        //                            toastr.error(response.message, ""Xəta!"");
        //                        }
        //                    },
        //                    error: function(response) {
        //                        toastr.error('Sistem xətası.Biraz sonra yenidən yoxlayın', ""Xəta!"")
        //                        console.warn(response);
        //                    }

        //                });

        //            }
        //        });
        //}
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedViewModel<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591