#pragma checksum "C:\Users\Ashley\Documents\CSharp\ORM\WeddingPlanner\Views\Wedding\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "490ddd822723be4c0400975c31e6510921316341"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_View), @"mvc.1.0.view", @"/Views/Wedding/View.cshtml")]
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
#line 1 "C:\Users\Ashley\Documents\CSharp\ORM\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ashley\Documents\CSharp\ORM\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ashley\Documents\CSharp\ORM\WeddingPlanner\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"490ddd822723be4c0400975c31e6510921316341", @"/Views/Wedding/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74b8ca08b40f37ad1199f2c8f4e56e10e34ca9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"text-center\">");
#nullable restore
#line 3 "C:\Users\Ashley\Documents\CSharp\ORM\WeddingPlanner\Views\Wedding\View.cshtml"
                   Write(Model.WedderOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" & ");
#nullable restore
#line 3 "C:\Users\Ashley\Documents\CSharp\ORM\WeddingPlanner\Views\Wedding\View.cshtml"
                                      Write(Model.WedderTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Wedding</h1>\r\n<h3 class=\"text-center mt-4\">Date: ");
#nullable restore
#line 4 "C:\Users\Ashley\Documents\CSharp\ORM\WeddingPlanner\Views\Wedding\View.cshtml"
                              Write(Model.Date.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"text-center mt-4\">Guests:</h3>\r\n");
#nullable restore
#line 6 "C:\Users\Ashley\Documents\CSharp\ORM\WeddingPlanner\Views\Wedding\View.cshtml"
 foreach(var g in Model.Attendees)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"text-center\">");
#nullable restore
#line 8 "C:\Users\Ashley\Documents\CSharp\ORM\WeddingPlanner\Views\Wedding\View.cshtml"
                       Write(g.User.FullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 9 "C:\Users\Ashley\Documents\CSharp\ORM\WeddingPlanner\Views\Wedding\View.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591
