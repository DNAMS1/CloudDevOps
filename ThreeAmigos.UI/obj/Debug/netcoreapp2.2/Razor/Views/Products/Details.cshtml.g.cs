#pragma checksum "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f80d44daabba4c01e7728c26c56271bfb2f383d7d8aad6ec9f0e31c8bde81878"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\_ViewImports.cshtml"
using ThreeAmigos.UI

    ;
#line 2 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\_ViewImports.cshtml"
using ThreeAmigos.UI.Models

    ;
#line 3 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\_ViewImports.cshtml"
using ThreeAmigos.Domain.Entities

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f80d44daabba4c01e7728c26c56271bfb2f383d7d8aad6ec9f0e31c8bde81878", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f6ac5c8b079c1e72bd757b366bbc1ec5c76e6b558cdeadfc6ab8b4105345ba01", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#line 1 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
       IEnumerable<Product>

#line default
#line hidden
    >
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden

            BeginContext(74, 35, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(109, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f80d44daabba4c01e7728c26c56271bfb2f383d7d8aad6ec9f0e31c8bde818784886", async() => {
                BeginContext(132, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(146, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(239, 40, false);
            Write(
#line 18 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                 Html.DisplayNameFor(model => model.Name)

#line default
#line hidden
            );
            EndContext();
            BeginContext(279, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(335, 47, false);
            Write(
#line 21 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                 Html.DisplayNameFor(model => model.Description)

#line default
#line hidden
            );
            EndContext();
            BeginContext(382, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(438, 41, false);
            Write(
#line 24 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                 Html.DisplayNameFor(model => model.Price)

#line default
#line hidden
            );
            EndContext();
            BeginContext(479, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(535, 46, false);
            Write(
#line 27 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                 Html.DisplayNameFor(model => model.StockLevel)

#line default
#line hidden
            );
            EndContext();
            BeginContext(581, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(637, 42, false);
            Write(
#line 30 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                 Html.DisplayNameFor(model => model.Active)

#line default
#line hidden
            );
            EndContext();
            BeginContext(679, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(735, 44, false);
            Write(
#line 33 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                 Html.DisplayNameFor(model => model.Category)

#line default
#line hidden
            );
            EndContext();
            BeginContext(779, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(835, 41, false);
            Write(
#line 36 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                 Html.DisplayNameFor(model => model.Brand)

#line default
#line hidden
            );
            EndContext();
            BeginContext(876, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 42 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden

            BeginContext(1011, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1072, 39, false);
            Write(
#line 46 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                     Html.DisplayFor(modelItem => item.Name)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1111, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1179, 46, false);
            Write(
#line 49 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                     Html.DisplayFor(modelItem => item.Description)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1225, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1293, 40, false);
            Write(
#line 52 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                     Html.DisplayFor(modelItem => item.Price)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1333, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1401, 45, false);
            Write(
#line 55 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                     Html.DisplayFor(modelItem => item.StockLevel)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1446, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1514, 41, false);
            Write(
#line 58 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                     Html.DisplayFor(modelItem => item.Active)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1555, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1623, 46, false);
            Write(
#line 61 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                     Html.DisplayFor(modelItem => item.Category.Id)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1669, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1737, 43, false);
            Write(
#line 64 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                     Html.DisplayFor(modelItem => item.Brand.Id)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1780, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1847, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f80d44daabba4c01e7728c26c56271bfb2f383d7d8aad6ec9f0e31c8bde8187813352", async() => {
                BeginContext(1899, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 67 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
                                                        item.IdProduct

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1907, 68, true);
            WriteLiteral(" |\r\n                    \r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 71 "C:\Users\ASRAD\OneDrive\Desktop\ThreeAmigos\ThreeAmigos.UI\Views\Products\Details.cshtml"
        }

#line default
#line hidden

            BeginContext(1986, 37, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n\r\n    ");
            EndContext();
            BeginContext(2023, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f80d44daabba4c01e7728c26c56271bfb2f383d7d8aad6ec9f0e31c8bde8187816128", async() => {
                BeginContext(2045, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2061, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
