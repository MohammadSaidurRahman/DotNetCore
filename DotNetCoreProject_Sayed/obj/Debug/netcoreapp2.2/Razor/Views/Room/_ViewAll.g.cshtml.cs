#pragma checksum "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17e483604bba45fed312c3822dde41ba5c039dde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room__ViewAll), @"mvc.1.0.view", @"/Views/Room/_ViewAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Room/_ViewAll.cshtml", typeof(AspNetCore.Views_Room__ViewAll))]
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
#line 1 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\_ViewImports.cshtml"
using DotNetCoreProject_Sayed;

#line default
#line hidden
#line 2 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\_ViewImports.cshtml"
using DotNetCoreProject_Sayed.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17e483604bba45fed312c3822dde41ba5c039dde", @"/Views/Room/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b698b86928be54839de972c10ccbadb590ecc9ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Room__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DotNetCoreProject_Sayed.Models.Room>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 285, true);
            WriteLiteral(@"
    <div class=""col-md-8 offset-md-2"">

        <h1 class=""text-center""><i class=""fas fa-comments-dollar text-success""></i> Room Details</h1>


        <table class=""table"">
            <thead class=""thead-light"">
                <tr>
                    <th>
                        ");
            EndContext();
            BeginContext(342, 46, false);
#line 12 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(388, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(465, 44, false);
#line 15 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(509, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(586, 47, false);
#line 18 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.BookingDate));

#line default
#line hidden
            EndContext();
            BeginContext(633, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(710, 40, false);
#line 21 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(750, 78, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 828, "\"", 923, 4);
            WriteAttributeValue("", 838, "showInPopup(\'", 838, 13, true);
#line 24 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
WriteAttributeValue("", 851, Url.Action("AddOrEdit","Room",null,Context.Request.Scheme), 851, 59, false);

#line default
#line hidden
            WriteAttributeValue("", 910, "\',\'New", 910, 6, true);
            WriteAttributeValue(" ", 916, "Room\')", 917, 7, true);
            EndWriteAttribute();
            BeginContext(924, 168, true);
            WriteLiteral(" class=\"btn btn-success text-white\"><i class=\"fas fa-random\"></i> New Room</a>\n                    </th>\n                </tr>\n            </thead>\n            <tbody>\n");
            EndContext();
#line 29 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1155, 82, true);
            WriteLiteral("                    <tr>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1238, 45, false);
#line 33 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1372, 43, false);
#line 36 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(1415, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1504, 46, false);
#line 39 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
                       Write(Html.DisplayFor(modelItem => item.BookingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1550, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1639, 39, false);
#line 42 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 128, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            <div>\n                                <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1806, "\"", 1920, 4);
            WriteAttributeValue("", 1816, "showInPopup(\'", 1816, 13, true);
#line 46 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
WriteAttributeValue("", 1829, Url.Action("AddOrEdit","Room",new {id=item.RoomId},Context.Request.Scheme), 1829, 75, false);

#line default
#line hidden
            WriteAttributeValue("", 1904, "\',\'Update", 1904, 9, true);
            WriteAttributeValue(" ", 1913, "Room\')", 1914, 7, true);
            EndWriteAttribute();
            BeginContext(1921, 108, true);
            WriteLiteral(" class=\"btn btn-info text-white\"><i class=\"fas fa-pencil-alt\"></i> Edit</a>\n                                ");
            EndContext();
            BeginContext(2029, 333, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e483604bba45fed312c3822dde41ba5c039dde11315", async() => {
                BeginContext(2141, 37, true);
                WriteLiteral("\n                                    ");
                EndContext();
                BeginContext(2178, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "17e483604bba45fed312c3822dde41ba5c039dde11734", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 48 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.RoomId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2224, 131, true);
                WriteLiteral("\n                                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
                                                            WriteLiteral(item.RoomId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2362, 92, true);
            WriteLiteral("\n                            </div>\n                        </td>\n                    </tr>\n");
            EndContext();
#line 54 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\_ViewAll.cshtml"
                }

#line default
#line hidden
            BeginContext(2472, 48, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DotNetCoreProject_Sayed.Models.Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591
