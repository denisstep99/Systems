#pragma checksum "C:\Users\deniska\source\repos\GroundWord\GroundWord\Views\HistoryNotes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "288f50b10f311c9cb180bdd3f7f9aa8468caa57c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HistoryNotes_Create), @"mvc.1.0.view", @"/Views/HistoryNotes/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"288f50b10f311c9cb180bdd3f7f9aa8468caa57c", @"/Views/HistoryNotes/Create.cshtml")]
    public class Views_HistoryNotes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroundWord.Models.HistoryNote>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\deniska\source\repos\GroundWord\GroundWord\Views\HistoryNotes\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>HistoryNote</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""HistoryNoteId"" class=""control-label""></label>
                <input asp-for=""HistoryNoteId"" class=""form-control"" />
                <span asp-validation-for=""HistoryNoteId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Temperature"" class=""control-label""></label>
                <input asp-for=""Temperature"" class=""form-control"" />
                <span asp-validation-for=""Temperature"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Humidity"" class=""control-label""></label>
                <input asp-for=""Humidity"" class=""form-control"" />
                <span asp-validation-for=""Humid");
            WriteLiteral(@"ity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Pressure"" class=""control-label""></label>
                <input asp-for=""Pressure"" class=""form-control"" />
                <span asp-validation-for=""Pressure"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Date"" class=""control-label""></label>
                <input asp-for=""Date"" class=""form-control"" />
                <span asp-validation-for=""Date"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""GroundHumidity"" class=""control-label""></label>
                <input asp-for=""GroundHumidity"" class=""form-control"" />
                <span asp-validation-for=""GroundHumidity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
      ");
            WriteLiteral("      </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\deniska\source\repos\GroundWord\GroundWord\Views\HistoryNotes\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroundWord.Models.HistoryNote> Html { get; private set; }
    }
}
#pragma warning restore 1591
