#pragma checksum "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e74a41992e2d3ebc3684e548d2dc25da4dec5efb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\_ViewImports.cshtml"
using HospitalManagementSystemTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\_ViewImports.cshtml"
using HospitalManagementSystemTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\_ViewImports.cshtml"
using HospitalManagementSystemTask.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e74a41992e2d3ebc3684e548d2dc25da4dec5efb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ce04836c843c18db176997b0a70f2f16dbcfbe2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Doctor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Doctors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-2\">\r\n");
#nullable restore
#line 6 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
         if (User.IsInRole("Admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e74a41992e2d3ebc3684e548d2dc25da4dec5efb5068", async() => {
                WriteLiteral("Yeni həkim əlavə et");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 11 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-8 offset-2"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Həkim</th>
                            <th>Vəzifə</th>
");
#nullable restore
#line 19 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
                             if (!User.IsInRole("Admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th>Qəbula yazıl</th>\r\n");
#nullable restore
#line 22 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
                            }
                            else if (User.IsInRole("Admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th>Nəzər yetir</th>\r\n");
#nullable restore
#line 26 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n");
#nullable restore
#line 29 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
                     foreach (var doctor in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tbody>\r\n                            <tr>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
                               Write(doctor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
                                            Write(doctor.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 34 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
                               Write(doctor.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
                                 if (!User.IsInRole("Admin"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        <a class=\"alert-primary\"");
            BeginWriteAttribute("href", " href=\"", 1472, "\"", 1515, 2);
            WriteAttributeValue("", 1479, "/Appointment/Registration/", 1479, 26, true);
#nullable restore
#line 38 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
WriteAttributeValue("", 1505, doctor.Id, 1505, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Növbə götür</a>\r\n                                    </td>\r\n");
#nullable restore
#line 40 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
                                }
                                else if (User.IsInRole("Admin"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        <a class=\"alert-primary\"");
            BeginWriteAttribute("href", " href=\"", 1819, "\"", 1850, 2);
            WriteAttributeValue("", 1826, "/Doctors/Edit/", 1826, 14, true);
#nullable restore
#line 44 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
WriteAttributeValue("", 1840, doctor.Id, 1840, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Redaktə et</a>  <a class=\"alert-danger\"");
            BeginWriteAttribute("href", " href=\"", 1891, "\"", 1924, 2);
            WriteAttributeValue("", 1898, "/Doctors/Delete/", 1898, 16, true);
#nullable restore
#line 44 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
WriteAttributeValue("", 1914, doctor.Id, 1914, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a>\r\n                                    </td>\r\n");
#nullable restore
#line 46 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n                        </tbody>\r\n");
#nullable restore
#line 49 "C:\Users\DELL\source\repos\HospitalManagementSystemTask\HospitalManagementSystemTask\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
