#pragma checksum "C:\Users\Vivek\Desktop\DotNet\MovieWebApplication\MovieWebApplication\Views\Movie\_PartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be155c8889f47312941b127b11e09f418ad53d8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie__PartialView), @"mvc.1.0.view", @"/Views/Movie/_PartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/_PartialView.cshtml", typeof(AspNetCore.Views_Movie__PartialView))]
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
#line 1 "C:\Users\Vivek\Desktop\DotNet\MovieWebApplication\MovieWebApplication\Views\_ViewImports.cshtml"
using MovieWebApplication;

#line default
#line hidden
#line 5 "C:\Users\Vivek\Desktop\DotNet\MovieWebApplication\MovieWebApplication\Views\Movie\_PartialView.cshtml"
using MovieWebApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be155c8889f47312941b127b11e09f418ad53d8e", @"/Views/Movie/_PartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6f73e2ed439b1e68dbde6e82c833c92bdde2916", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie__PartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(161, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Vivek\Desktop\DotNet\MovieWebApplication\MovieWebApplication\Views\Movie\_PartialView.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(204, 100, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 18 "C:\Users\Vivek\Desktop\DotNet\MovieWebApplication\MovieWebApplication\Views\Movie\_PartialView.cshtml"
         foreach (var movieDetail in Model)
        {

#line default
#line hidden
            BeginContext(360, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(411, 19, false);
#line 21 "C:\Users\Vivek\Desktop\DotNet\MovieWebApplication\MovieWebApplication\Views\Movie\_PartialView.cshtml"
                           Write(movieDetail.MovieId);

#line default
#line hidden
            EndContext();
            BeginContext(430, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(458, 21, false);
#line 22 "C:\Users\Vivek\Desktop\DotNet\MovieWebApplication\MovieWebApplication\Views\Movie\_PartialView.cshtml"
               Write(movieDetail.MovieName);

#line default
#line hidden
            EndContext();
            BeginContext(479, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(507, 23, false);
#line 23 "C:\Users\Vivek\Desktop\DotNet\MovieWebApplication\MovieWebApplication\Views\Movie\_PartialView.cshtml"
               Write(movieDetail.ReleaseYear);

#line default
#line hidden
            EndContext();
            BeginContext(530, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(558, 17, false);
#line 24 "C:\Users\Vivek\Desktop\DotNet\MovieWebApplication\MovieWebApplication\Views\Movie\_PartialView.cshtml"
               Write(movieDetail.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(575, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "C:\Users\Vivek\Desktop\DotNet\MovieWebApplication\MovieWebApplication\Views\Movie\_PartialView.cshtml"
        }

#line default
#line hidden
            BeginContext(612, 46, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
