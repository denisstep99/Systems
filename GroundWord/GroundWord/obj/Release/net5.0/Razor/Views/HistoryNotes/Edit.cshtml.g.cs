#pragma checksum "C:\Users\deniska\source\repos\GroundWord\GroundWord\Views\HistoryNotes\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d81ea58d8a5cf5e58f2e98c1864bbe7946416819"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HistoryNotes_Edit), @"mvc.1.0.view", @"/Views/HistoryNotes/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d81ea58d8a5cf5e58f2e98c1864bbe7946416819", @"/Views/HistoryNotes/Edit.cshtml")]
    public class Views_HistoryNotes_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroundWord.Models.HistoryNote>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\deniska\source\repos\GroundWord\GroundWord\Views\HistoryNotes\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>HistoryNote</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""HistoryNoteId"" />
            <div class=""form-group"">
                <label asp-for=""Temperature"" class=""control-label""></label>
                <input asp-for=""Temperature"" class=""form-control"" />
                <span asp-validation-for=""Temperature"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Humidity"" class=""control-label""></label>
                <input asp-for=""Humidity"" class=""form-control"" />
                <span asp-validation-for=""Humidity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Pressure"" class=""control-label""></label>
                <input asp-for=""Pressure"" class=""form-control"" />
     ");
            WriteLiteral(@"           <span asp-validation-for=""Pressure"" class=""text-danger""></span>
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
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\deniska\source\repos\GroundWord\GroundWord\Views\HistoryNotes\Edit.cshtml"
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
