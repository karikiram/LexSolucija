#pragma checksum "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bf21a6c039b17e3ec97343fbaea01595fbb8a59"
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
#line 1 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\_ViewImports.cshtml"
using Tommy_Skrak_LexDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\_ViewImports.cshtml"
using Tommy_Skrak_LexDo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf21a6c039b17e3ec97343fbaea01595fbb8a59", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6abdc888d1ef96bb916a27c8ed9293a91f0b4312", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tommy_Skrak_LexDo.Models.Reminder>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Excel";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<button type=\"button\" class=\"btn btn-primary float-right mb-4 mt-2 ml-2\" data-toggle=\"ajax-modal\" data-target=\"#addReminder\"\r\n        data-url=\"");
#nullable restore
#line 8 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
             Write(Url.Action("Create", "Reminders"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    Create Reminder\r\n</button>\r\n<button type=\"button\" class=\"btn btn-warning float-right mb-4 mt-2\" data-toggle=\"ajax-modal\" data-target=\"#addGroup\"\r\n        data-url=\"");
#nullable restore
#line 12 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
             Write(Url.ActionLink("CreateGroup", "Groups"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    Create Group\r\n</button>\r\n");
#nullable restore
#line 15 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Get, new { @class = "login-form" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bf21a6c039b17e3ec97343fbaea01595fbb8a594727", async() => {
                WriteLiteral("\r\n        <div class=\"mt-2 form-row\">\r\n            <div class=\"col-md-3\">\r\n                ");
#nullable restore
#line 20 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
           Write(Html.DropDownList("Filter", new SelectList(ViewBag.TotalGroups, "Id", "Name"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
            <div class=""col-md-1"">
                <input type=""submit"" name=""command"" class=""btn btn-info mb-4"" value=""Search"" />
            </div>
            <div class=""col-md-1"">
                <input type=""submit"" name=""command"" class=""btn btn-danger mb-4 ml-3"" value=""Delete"" />
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center text-white mt-3\">\r\n    Your Reminders\r\n</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bf21a6c039b17e3ec97343fbaea01595fbb8a597037", async() => {
                WriteLiteral("\r\n    <div class=\"mt-2 form-row\">\r\n        <div class=\"col-md-1 float-left mb-2\">\r\n            ");
#nullable restore
#line 38 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Sort by: Title", "Index", new { sortOrder = ViewBag.TitleSortParm }, new { @class = "btn btn-primary btn-sm" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-1 float-left mb-2 ml-1\">\r\n            ");
#nullable restore
#line 41 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Sort by: Date", "Index", new { sortOrder = ViewBag.DateSortParm }, new { @class = "btn btn-primary btn-sm" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div id=\"PlaceHolderHere\"></div>\r\n\r\n");
#nullable restore
#line 48 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card bettercard mb-4\" style=\"width: 20rem; text-align:center;display:inline-block;\">\r\n        <div class=\"card-block text-white bg-secondary\">\r\n            <p class=\"card-header\">");
#nullable restore
#line 52 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
                              Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h4 class=\"card-title\">");
#nullable restore
#line 53 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
                              Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p class=\"card-text\">");
#nullable restore
#line 54 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
                            Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">Status: ");
#nullable restore
#line 55 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
                                    Write(Html.CheckBoxFor(modelItem => item.Status, new { @disabled = "true", @class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            ");
#nullable restore
#line 56 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Delete", "Delete", "Reminders", new { id = item.Id }, new
            {
                @class = "btn btn-danger float-right ml-2 mr-2",
                @style = "color:white",
            @OnClick = "return confirm('Are you sure you to delete this Reminder?');"
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"btn btn-info float-right mb-2 ml-2\" data-toggle=\"ajax-modal\" data-target=\"#addReminder\"\r\n                    data-url=\"");
#nullable restore
#line 63 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
                         Write(Url.Action("Edit", "Reminders", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                Edit\r\n            </button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 68 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-1 mb-2\">\r\n");
#nullable restore
#line 70 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
     using (Html.BeginForm("ExportExcel", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button class=\"btn btn-success order-button\">ExportExcel</button>\r\n");
#nullable restore
#line 73 "F:\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Tommy_Skrak_LexDo\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tommy_Skrak_LexDo.Models.Reminder>> Html { get; private set; }
    }
}
#pragma warning restore 1591