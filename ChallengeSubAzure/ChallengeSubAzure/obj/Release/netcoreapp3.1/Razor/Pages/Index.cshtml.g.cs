#pragma checksum "C:\Users\joelm\myProjects\C.NET\ChallengeSubAzure\ChallengeSubAzure\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea2e9524649cf63ea9e9418a24818141e0d65a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ChallengeSubAzure.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ChallengeSubAzure.Pages
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
#line 1 "C:\Users\joelm\myProjects\C.NET\ChallengeSubAzure\ChallengeSubAzure\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joelm\myProjects\C.NET\ChallengeSubAzure\ChallengeSubAzure\Pages\_ViewImports.cshtml"
using ChallengeSubAzure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joelm\myProjects\C.NET\ChallengeSubAzure\ChallengeSubAzure\Pages\_ViewImports.cshtml"
using ChallengeSubAzure.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea2e9524649cf63ea9e9418a24818141e0d65a9", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fce4d747faeeed1a14fdcea94324071c6e022b06", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\joelm\myProjects\C.NET\ChallengeSubAzure\ChallengeSubAzure\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 8 "C:\Users\joelm\myProjects\C.NET\ChallengeSubAzure\ChallengeSubAzure\Pages\Index.cshtml"
    
    var greeting = "Hello,";
    var weekDay = DateTime.Now.DayOfWeek;
    var greet = greeting + " The Day of the week is: " + weekDay;
  

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h2 class=\"display-4\">");
#nullable restore
#line 13 "C:\Users\joelm\myProjects\C.NET\ChallengeSubAzure\ChallengeSubAzure\Pages\Index.cshtml"
                   Write(greet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n  <p>Current time is ");
#nullable restore
#line 14 "C:\Users\joelm\myProjects\C.NET\ChallengeSubAzure\ChallengeSubAzure\Pages\Index.cshtml"
                Write(ViewData["TimeStamp"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n</div>\r\n ");
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