#pragma checksum "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f41ea6492dec38ab77bf609a6bd6d35af69bcd2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PersonProfiles_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PersonProfiles/Default.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Domain.Models.Entites;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Domain.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Domain.AppCode.Bussines.AccountModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41ea6492dec38ab77bf609a6bd6d35af69bcd2f", @"/Views/Shared/Components/PersonProfiles/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2757339048d6345580f9112a986c001662aa70e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PersonProfiles_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonProfilesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/avatar.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/pdf-icon.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/word-icon.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onSubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"side-bar\">\r\n\r\n    <!-- Professional Details -->\r\n    <h5 class=\"tittle\">Professional Details</h5>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f41ea6492dec38ab77bf609a6bd6d35af69bcd2f7867", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <ul class=\"personal-info\">\r\n        <li>\r\n            <p> <span> Name</span> ");
#nullable restore
#line 9 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
                              Write(Model.Person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        </li>\r\n        <li>\r\n            <p> <span> Age</span> ");
#nullable restore
#line 12 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
                             Write(Model.Person.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Years </p>\r\n        </li>\r\n        <li>\r\n            <p> <span> Location</span> ");
#nullable restore
#line 15 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
                                  Write(Model.Person.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        </li>\r\n        <li>\r\n            <p> <span> Experience</span> ");
#nullable restore
#line 18 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
                                    Write(Model.Person.Experiences);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Years </p>\r\n        </li> \r\n\r\n        <li>\r\n            <p> <span> Degree</span> ");
#nullable restore
#line 22 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
                                Write(Model.Person.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        </li>  \r\n        <li>\r\n            <p> <span> Career Level</span> ");
#nullable restore
#line 25 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
                                      Write(Model.Person.CareerLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        </li>\r\n        <li>\r\n            <p> <span> Phone</span> ");
#nullable restore
#line 28 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
                               Write(Model.Person.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        </li>\r\n        <li>\r\n            <p> <span> FAX</span> ");
#nullable restore
#line 31 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
                             Write(Model.Person.Fax);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p> \r\n        </li>\r\n        <li>\r\n            <p> <span> E-mail</span> <a href=\"#.\"> ");
#nullable restore
#line 34 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
                                              Write(Model.Person.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </p>\r\n        </li>\r\n        <li>\r\n            <p> <span> Website</span><a href=\"#.\"> ");
#nullable restore
#line 37 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
                                              Write(Model.Person.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n        </li>\r\n    </ul>\r\n\r\n    <!-- Attachments -->\r\n    <h5 class=\"tittle\">Attachments</h5>\r\n    <div class=\"attach bor-btm padding-25\">\r\n        <ul>\r\n            <li>\r\n                <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f41ea6492dec38ab77bf609a6bd6d35af69bcd2f13159", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" Curriculum-Vitae.pdf <a href=\"#.\"><i class=\"fa fa-cloud-download\"></i></a> <a href=\"#.\"><i class=\"fa fa-eye\"></i></a></p>\r\n            </li>\r\n            <li>\r\n                <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f41ea6492dec38ab77bf609a6bd6d35af69bcd2f14464", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" COE.docx <a href=""#.""><i class=""fa fa-cloud-download""></i></a> <a href=""#.""><i class=""fa fa-eye""></i></a></p>
            </li>
        </ul>
    </div>

    <!-- Social Profiles -->
    <h5 class=""tittle"">Social Profiles</h5>
    <div class=""social-icon bor-btm padding-25"">
        <ul>
");
#nullable restore
#line 58 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
            foreach (var item in Model.Profiles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li> <a");
            BeginWriteAttribute("href", " href=\"", 2076, "\"", 2092, 1);
#nullable restore
#line 60 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
WriteAttributeValue("", 2083, item.Url, 2083, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 2096, "\"", 2134, 3);
            WriteAttributeValue("", 2104, "fa-brands", 2104, 9, true);
            WriteAttributeValue(" ", 2113, "fa-", 2114, 4, true);
#nullable restore
#line 60 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
WriteAttributeValue("", 2117, item.ProfileName, 2117, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n");
#nullable restore
#line 61 "C:\Users\user\Desktop\Portfolio_MVC_Project_\Portfolio\Portfolio.WebUI\Views\Shared\Components\PersonProfiles\Default.cshtml"
               
            }  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </ul>
    </div>

    <!-- Contact Me -->
    <h5 class=""tittle"">Contact Me</h5>
    <div class=""contact padding-25"">
        <!-- Success Msg -->
        <div id=""contact_message"" class=""success-msg""> <i class=""fa fa-paper-plane-o""></i>Thank You. Your Message has been Submitted</div>

        <!-- FORM -->
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f41ea6492dec38ab77bf609a6bd6d35af69bcd2f17810", async() => {
                WriteLiteral(@"
            <ul class=""row"">
                <li class=""col-sm-12"">
                    <label>
                        <input type=""text"" class=""form-control"" name=""email"" id=""email"" placeholder=""Email"">
                    </label>
                </li>
                <li class=""col-sm-12"">
                    <label>
                        <input type=""text"" class=""form-control"" name=""company"" id=""company"" placeholder=""Subject"">
                    </label>
                </li>
                <li class=""col-sm-12"">
                    <label>
                        <textarea class=""form-control"" name=""message"" id=""message"" rows=""5"" placeholder=""Message""></textarea>
                    </label>
                </li>
                <li class=""col-sm-12"">
                    <button type=""submit"" value=""submit"" id=""btn_submit"" onClick=""proceed();"">Send Message</button>
                </li>
            </ul>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonProfilesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
