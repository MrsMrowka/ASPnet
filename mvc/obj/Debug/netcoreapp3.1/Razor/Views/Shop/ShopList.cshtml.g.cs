#pragma checksum "C:\Users\Gosia\Documents\GitHub\ASPnet\mvc\Views\Shop\ShopList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be11417497c01593b8babf13ccc14a486cf72d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_ShopList), @"mvc.1.0.view", @"/Views/Shop/ShopList.cshtml")]
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
#line 1 "C:\Users\Gosia\Documents\GitHub\ASPnet\mvc\Views\_ViewImports.cshtml"
using mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gosia\Documents\GitHub\ASPnet\mvc\Views\_ViewImports.cshtml"
using mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be11417497c01593b8babf13ccc14a486cf72d01", @"/Views/Shop/ShopList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6a06753573638890b0ff2d42042a0bcf031bf36", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_ShopList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShopModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gosia\Documents\GitHub\ASPnet\mvc\Views\Shop\ShopList.cshtml"
  
    ViewData["Title"] = "ShopList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1> ShopList </h1>\r\n\r\n\r\n\r\n<ul>\r\n");
#nullable restore
#line 11 "C:\Users\Gosia\Documents\GitHub\ASPnet\mvc\Views\Shop\ShopList.cshtml"
     foreach (var item in @Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 13 "C:\Users\Gosia\Documents\GitHub\ASPnet\mvc\Views\Shop\ShopList.cshtml"
       Write(item.ShopItem);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 13 "C:\Users\Gosia\Documents\GitHub\ASPnet\mvc\Views\Shop\ShopList.cshtml"
                       Write(item.ItemPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</li>\r\n");
#nullable restore
#line 14 "C:\Users\Gosia\Documents\GitHub\ASPnet\mvc\Views\Shop\ShopList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShopModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
