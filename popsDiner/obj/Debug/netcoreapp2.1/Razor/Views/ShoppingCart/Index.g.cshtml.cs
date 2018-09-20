#pragma checksum "C:\Users\patel\OneDrive\Documents\GitHub\Pops-Diner\popsDiner\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16a6c9daec11a5f1bcece6cfcdb6788da74e71ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShoppingCart/Index.cshtml", typeof(AspNetCore.Views_ShoppingCart_Index))]
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
#line 1 "C:\Users\patel\OneDrive\Documents\GitHub\Pops-Diner\popsDiner\Views\_ViewImports.cshtml"
using popsDiner.Models;

#line default
#line hidden
#line 2 "C:\Users\patel\OneDrive\Documents\GitHub\Pops-Diner\popsDiner\Views\_ViewImports.cshtml"
using popsDiner.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16a6c9daec11a5f1bcece6cfcdb6788da74e71ca", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970c2464b334b9df4f68878ae669cafcf089643b", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 374, true);
            WriteLiteral(@"
<h2>Your shopping cart</h2>
<h4>Here are the delicious pies in your shopping cart.</h4>
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Selected amount</th>
            <th>Pie</th>
            <th class=""text-right"">Price</th>
            <th class=""text-right"">Subtotal</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 15 "C:\Users\patel\OneDrive\Documents\GitHub\Pops-Diner\popsDiner\Views\ShoppingCart\Index.cshtml"
         foreach (var line in Model.ShoppingCart.shoppingCartItems)
        {

#line default
#line hidden
            BeginContext(484, 58, true);
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\">");
            EndContext();
            BeginContext(543, 11, false);
#line 18 "C:\Users\patel\OneDrive\Documents\GitHub\Pops-Diner\popsDiner\Views\ShoppingCart\Index.cshtml"
                                   Write(line.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(554, 45, true);
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
            EndContext();
            BeginContext(600, 14, false);
#line 19 "C:\Users\patel\OneDrive\Documents\GitHub\Pops-Diner\popsDiner\Views\ShoppingCart\Index.cshtml"
                                 Write(line.Item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(614, 46, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right\">");
            EndContext();
            BeginContext(661, 29, false);
#line 20 "C:\Users\patel\OneDrive\Documents\GitHub\Pops-Diner\popsDiner\Views\ShoppingCart\Index.cshtml"
                                  Write(line.Item.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(690, 68, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(760, 45, false);
#line 22 "C:\Users\patel\OneDrive\Documents\GitHub\Pops-Diner\popsDiner\Views\ShoppingCart\Index.cshtml"
                Write((line.Amount * line.Item.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(806, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "C:\Users\patel\OneDrive\Documents\GitHub\Pops-Diner\popsDiner\Views\ShoppingCart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(861, 154, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n            <td class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(1016, 37, false);
#line 31 "C:\Users\patel\OneDrive\Documents\GitHub\Pops-Diner\popsDiner\Views\ShoppingCart\Index.cshtml"
           Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 58, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591