#pragma checksum "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a70ecde10d1810becaf8c559dbc0b817a3b86b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_Delete), @"mvc.1.0.view", @"/Views/Room/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Room/Delete.cshtml", typeof(AspNetCore.Views_Room_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a70ecde10d1810becaf8c559dbc0b817a3b86b1", @"/Views/Room/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b698b86928be54839de972c10ccbadb590ecc9ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetCoreProject_Sayed.Models.Room>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(83, 165, true);
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Room</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(249, 46, false);
#line 15 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(295, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(356, 42, false);
#line 18 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(398, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(458, 44, false);
#line 21 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(502, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(563, 40, false);
#line 24 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(603, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(663, 45, false);
#line 27 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HotelName));

#line default
#line hidden
            EndContext();
            BeginContext(708, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(769, 41, false);
#line 30 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HotelName));

#line default
#line hidden
            EndContext();
            BeginContext(810, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(870, 48, false);
#line 33 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SecurityCode));

#line default
#line hidden
            EndContext();
            BeginContext(918, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(979, 44, false);
#line 36 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SecurityCode));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1083, 40, false);
#line 39 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1184, 36, false);
#line 42 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1220, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1280, 47, false);
#line 45 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BookingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1388, 43, false);
#line 48 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BookingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(1465, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a70ecde10d1810becaf8c559dbc0b817a3b86b110497", async() => {
                BeginContext(1491, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1500, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a70ecde10d1810becaf8c559dbc0b817a3b86b110887", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 53 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoomId);

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
                BeginContext(1540, 81, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                EndContext();
                BeginContext(1621, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a70ecde10d1810becaf8c559dbc0b817a3b86b112826", async() => {
                    BeginContext(1643, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1659, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1671, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetCoreProject_Sayed.Models.Room> Html { get; private set; }
    }
}
#pragma warning restore 1591
