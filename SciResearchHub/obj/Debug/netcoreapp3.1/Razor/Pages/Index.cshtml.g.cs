#pragma checksum "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2709d4527e564ac18c627b17510b3c8ce74b9e7c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2709d4527e564ac18c627b17510b3c8ce74b9e7c", @"/Pages/Index.cshtml")]
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml"
 foreach (var Research in Model.researches)
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 128, "\"", 190, 7);
            WriteAttributeValue("", 136, "card", 136, 4, true);
#nullable restore
#line 10 "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml"
WriteAttributeValue(" ", 140, Research.Domain, 141, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 157, "shadow", 158, 7, true);
            WriteAttributeValue(" ", 164, "p-3", 165, 4, true);
            WriteAttributeValue(" ", 168, "mb-5", 169, 5, true);
            WriteAttributeValue(" ", 173, "bg-white", 174, 9, true);
            WriteAttributeValue(" ", 182, "rounded", 183, 8, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 18rem; display:none\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 235, "\"", 256, 1);
#nullable restore
#line 11 "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml"
WriteAttributeValue("", 242, Research.Link, 242, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link\">\r\n        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 311, "\"", 335, 2);
#nullable restore
#line 12 "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml"
WriteAttributeValue("", 317, Research.Imglink, 317, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 334, "", 335, 1, true);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title text-dark\">");
#nullable restore
#line 14 "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml"
                                        Write(Research.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\"></p>\r\n            \r\n        </div>\r\n\r\n    </a>\r\n</div>\r\n");
#nullable restore
#line 21 "C:\Users\mohaz\OneDrive\Desktop\SciResearchHub\SciResearchHub\Pages\Index.cshtml"
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
