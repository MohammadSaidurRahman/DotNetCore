#pragma checksum "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "082b6783f7e1031f7292e8978755b1372386efe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_Index), @"mvc.1.0.view", @"/Views/Room/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Room/Index.cshtml", typeof(AspNetCore.Views_Room_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"082b6783f7e1031f7292e8978755b1372386efe4", @"/Views/Room/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b698b86928be54839de972c10ccbadb590ecc9ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DotNetCoreProject_Sayed.Models.Room>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 26, true);
            WriteLiteral("\n\n<div id=\"view-all\">\n    ");
            EndContext();
            BeginContext(122, 42, false);
#line 9 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Index.cshtml"
Write(await Html.PartialAsync("_ViewAll", Model));

#line default
#line hidden
            EndContext();
            BeginContext(164, 531, true);
            WriteLiteral(@"
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""form-modal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

            </div>
        </div>
    </div>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(712, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 30 "G:\IDB_C#_R44_Sayed\pppp\1256943 - Copy\DotNetCoreProject_Sayed\DotNetCoreProject_Sayed\Views\Room\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DotNetCoreProject_Sayed.Models.Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591
