#pragma checksum "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1631d7d433bd70a86e0a8143c70244755f30e7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SciResearchHub.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace SciResearchHub.Pages
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
#line 1 "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\_ViewImports.cshtml"
using SciResearchHub;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1631d7d433bd70a86e0a8143c70244755f30e7b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d1037928d10b790b0ec7c16e6388dc4bba09169", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml"
  var i = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml"
 foreach (var Research in Model.Researches)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-4\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 206, "\"", 226, 1);
#nullable restore
#line 11 "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml"
WriteAttributeValue("", 212, Research.link, 212, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml"
                                  Write(Research.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">Some quick example text to build on the card title and make up the bulk of the card\'s content.</p>\r\n                <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 18 "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml"
        i++;

        }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591