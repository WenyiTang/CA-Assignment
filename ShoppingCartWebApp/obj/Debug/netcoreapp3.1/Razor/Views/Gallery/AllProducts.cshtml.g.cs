#pragma checksum "C:\Users\Wenyi\Desktop\NUS ISS\SA4102 Enterprise Solutions\ASP.NET\Assignment\Code\ShoppingCartWebApp\Views\Gallery\AllProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa908ec64fce5365fbd5125f5a93288d879fcf59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_AllProducts), @"mvc.1.0.view", @"/Views/Gallery/AllProducts.cshtml")]
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
#line 1 "C:\Users\Wenyi\Desktop\NUS ISS\SA4102 Enterprise Solutions\ASP.NET\Assignment\Code\ShoppingCartWebApp\Views\_ViewImports.cshtml"
using ShoppingCartWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wenyi\Desktop\NUS ISS\SA4102 Enterprise Solutions\ASP.NET\Assignment\Code\ShoppingCartWebApp\Views\_ViewImports.cshtml"
using ShoppingCartWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa908ec64fce5365fbd5125f5a93288d879fcf59", @"/Views/Gallery/AllProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51d4e14ef855d197b29f17fd722b89fc21f7786f", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_AllProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Gallery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Wenyi\Desktop\NUS ISS\SA4102 Enterprise Solutions\ASP.NET\Assignment\Code\ShoppingCartWebApp\Views\Gallery\AllProducts.cshtml"
   List<ShoppingCartWebApp.Models.Product> products =
                         (List<ShoppingCartWebApp.Models.Product>)ViewData["products"];

    Cart cart = (Cart)ViewData["cart"];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa908ec64fce5365fbd5125f5a93288d879fcf594151", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("id", " id=\"", 270, "\"", 275, 0);
            EndWriteAttribute();
            WriteLiteral(@"><a href=""#"" style=""color:#434343"">Cart <span class=""cart-badge"" id=""select_cart"">0</span></a></div>


<div>
    <div style=""color:#434343"">
        <a href=""#"">
            <div>
                Cart    <div id=""count"" style=""display:inline; font-weight:bold"">0</div>
            </div>
        </a>
    </div>
</div>




<div style=""text-align:center"">
    <div class=""task_list"" style=""display:inline-block"">
");
#nullable restore
#line 29 "C:\Users\Wenyi\Desktop\NUS ISS\SA4102 Enterprise Solutions\ASP.NET\Assignment\Code\ShoppingCartWebApp\Views\Gallery\AllProducts.cshtml"
         foreach (ShoppingCartWebApp.Models.Product p in products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("id", " id=", 789, "", 798, 1);
#nullable restore
#line 31 "C:\Users\Wenyi\Desktop\NUS ISS\SA4102 Enterprise Solutions\ASP.NET\Assignment\Code\ShoppingCartWebApp\Views\Gallery\AllProducts.cshtml"
WriteAttributeValue("", 793, p.Id, 793, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"a_product\">\r\n    <div");
            BeginWriteAttribute("id", " id=", 827, "", 845, 1);
#nullable restore
#line 32 "C:\Users\Wenyi\Desktop\NUS ISS\SA4102 Enterprise Solutions\ASP.NET\Assignment\Code\ShoppingCartWebApp\Views\Gallery\AllProducts.cshtml"
WriteAttributeValue("", 831, p.ProductName, 831, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\Wenyi\Desktop\NUS ISS\SA4102 Enterprise Solutions\ASP.NET\Assignment\Code\ShoppingCartWebApp\Views\Gallery\AllProducts.cshtml"
                      Write(p.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>");
#nullable restore
#line 33 "C:\Users\Wenyi\Desktop\NUS ISS\SA4102 Enterprise Solutions\ASP.NET\Assignment\Code\ShoppingCartWebApp\Views\Gallery\AllProducts.cshtml"
    Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>\r\n        <a href=\"#!\"\r\n           class=\"add-to-cart-btn\">Add to Cart</a>\r\n    </div>\r\n</div>");
#nullable restore
#line 38 "C:\Users\Wenyi\Desktop\NUS ISS\SA4102 Enterprise Solutions\ASP.NET\Assignment\Code\ShoppingCartWebApp\Views\Gallery\AllProducts.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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
