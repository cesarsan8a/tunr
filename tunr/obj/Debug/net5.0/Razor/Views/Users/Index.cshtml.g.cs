#pragma checksum "C:\Users\cesar\Documents\repos\c#_exercises\tunr\tunr\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f24fc1929beef343295b3d6fa99d14e40ad4fde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\cesar\Documents\repos\c#_exercises\tunr\tunr\Views\_ViewImports.cshtml"
using tunr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cesar\Documents\repos\c#_exercises\tunr\tunr\Views\_ViewImports.cshtml"
using tunr.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f24fc1929beef343295b3d6fa99d14e40ad4fde", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c21e9ba64b89c9241dd481b0292b38d75810b88b", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<tunr.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cesar\Documents\repos\c#_exercises\tunr\tunr\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\cesar\Documents\repos\c#_exercises\tunr\tunr\Views\Users\Index.cshtml"
 foreach (var user in Model)
 {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cesar\Documents\repos\c#_exercises\tunr\tunr\Views\Users\Index.cshtml"
Write(Html.DisplayFor(modelUser => user.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cesar\Documents\repos\c#_exercises\tunr\tunr\Views\Users\Index.cshtml"
                                            
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<tunr.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
