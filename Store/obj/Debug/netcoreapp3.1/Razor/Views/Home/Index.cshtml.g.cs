#pragma checksum "C:\Users\Вова\Desktop\PR3\Store\Store\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a00a2cbf43caab1d6e14f316344ff821b890e71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\_ViewImports.cshtml"
using Store.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\_ViewImports.cshtml"
using Store.Data.Entities.PhoneAggregate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\_ViewImports.cshtml"
using Store;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a00a2cbf43caab1d6e14f316344ff821b890e71", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80d495cd5f26a8757f357af146be0c90530f4a7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhoneListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\Home\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Все телефоны</h1>\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 17 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\Home\Index.cshtml"
      
        foreach (Phone phone in Model.Phones)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                <h2>");
#nullable restore
#line 22 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\Home\Index.cshtml"
               Write(phone.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 22 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\Home\Index.cshtml"
                             Write(phone.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>Desc: ");
#nullable restore
#line 23 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\Home\Index.cshtml"
                    Write(phone.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Amount: ");
#nullable restore
#line 24 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\Home\Index.cshtml"
                      Write(phone.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Price: ");
#nullable restore
#line 25 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\Home\Index.cshtml"
                     Write(phone.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><a class=\"btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 752, "\"", 811, 1);
#nullable restore
#line 26 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\Home\Index.cshtml"
WriteAttributeValue("", 759, Url.Action("Index", "Phone", new { id = phone.Id }), 759, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">More info</a></p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a00a2cbf43caab1d6e14f316344ff821b890e716015", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 994, "\"", 1011, 1);
#nullable restore
#line 28 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\Home\Index.cshtml"
WriteAttributeValue("", 1002, phone.Id, 1002, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <button class=\"btn btn-outline-success\" type=\"submit\">В корзину</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 862, Url.Action("ReservePhone", "Order", new { phoneId = phone.Id }), 862, 64, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\Users\Вова\Desktop\PR3\Store\Store\Views\Home\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhoneListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591