#pragma checksum "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2ebc9568bdd09c7cc40b077bba57cd4611d5c45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Details.cshtml")]
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
#line 1 "C:\Topup_Web\FGW_Management\FGW_Management\_ViewImports.cshtml"
using FGW_Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Topup_Web\FGW_Management\FGW_Management\_ViewImports.cshtml"
using FGW_Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2ebc9568bdd09c7cc40b077bba57cd4611d5c45", @"/Areas/Admin/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2358a4915851c5ca8a1c107ce10dade6d6ec7c6b", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FGW_Management.Models.FGW_User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary justify-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<nav aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2ebc9568bdd09c7cc40b077bba57cd4611d5c455357", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n        <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2ebc9568bdd09c7cc40b077bba57cd4611d5c456959", async() => {
                WriteLiteral("User List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n        <li class=\"breadcrumb-item active\" aria-current=\"page\">Details</li>\r\n    </ol>\r\n</nav>\r\n\r\n<div class=\"container\">\r\n    <h5 class=\"mt-4 mb-4 text-center\">User Details (<em>");
#nullable restore
#line 16 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</em>)</h5>

    <div class=""row mb-5"">
        <div class=""col-12 col-lg-6 pl-4 pr-4 mt-5"">
            <table class=""table table-bordered"">
                <thead class=""table-dark bg-primary text-center"">
                    <tr>
                        <th colspan=""2"">
                            Profile
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th>
                            ");
#nullable restore
#line 31 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 34 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 39 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 42 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 47 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 50 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 55 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 58 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 63 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 66 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            User ");
#nullable restore
#line 71 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                            Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 74 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>

        <div class=""col-12 col-lg-6 pl-4 pr-4 mt-5"">
            <table class=""table table-bordered"">
                <thead class=""table-dark bg-primary text-center"">
                    <tr>
                        <th colspan=""2"">
                            Account Information
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th>
                            ");
#nullable restore
#line 93 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 96 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Department.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 101 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 104 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 109 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.NormalizedUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 112 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.NormalizedUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 117 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 120 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 125 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.NormalizedEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 128 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.NormalizedEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 133 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.EmailConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 136 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.EmailConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 141 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td style=\"word-break: break-word;\">\r\n                            ");
#nullable restore
#line 144 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 149 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.SecurityStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 152 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.SecurityStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 157 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.ConcurrencyStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 160 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.ConcurrencyStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 165 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.TwoFactorEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 168 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.TwoFactorEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 173 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.LockoutEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 176 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.LockoutEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 181 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.LockoutEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 184 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.LockoutEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 189 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.AccessFailedCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 192 "C:\Topup_Web\FGW_Management\FGW_Management\Areas\Admin\Views\User\Details.cshtml"
                       Write(Html.DisplayFor(model => model.AccessFailedCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2ebc9568bdd09c7cc40b077bba57cd4611d5c4525140", async() => {
                WriteLiteral("<i class=\"fas fa-arrow-left\"></i> Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FGW_Management.Models.FGW_User> Html { get; private set; }
    }
}
#pragma warning restore 1591