#pragma checksum "C:\Users\cassi\OneDrive\Desktop\papelariacanetas2\Views\Cadastro\Excluir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd2b25b46577179626320fb86869190f0a537210"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_Excluir), @"mvc.1.0.view", @"/Views/Cadastro/Excluir.cshtml")]
namespace AspNetCore
{
    #line hidden
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\cassi\OneDrive\Desktop\papelariacanetas2\Views\_ViewImports.cshtml"
using papelariacanetas2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cassi\OneDrive\Desktop\papelariacanetas2\Views\Cadastro\Excluir.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cassi\OneDrive\Desktop\papelariacanetas2\Views\Cadastro\Excluir.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cassi\OneDrive\Desktop\papelariacanetas2\Views\Cadastro\Excluir.cshtml"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cassi\OneDrive\Desktop\papelariacanetas2\Views\Cadastro\Excluir.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cassi\OneDrive\Desktop\papelariacanetas2\Views\Cadastro\Excluir.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cassi\OneDrive\Desktop\papelariacanetas2\Views\Cadastro\Excluir.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cassi\OneDrive\Desktop\papelariacanetas2\Views\Cadastro\Excluir.cshtml"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cassi\OneDrive\Desktop\papelariacanetas2\Views\Cadastro\Excluir.cshtml"
using papelariacanetas2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cassi\OneDrive\Desktop\papelariacanetas2\Views\Cadastro\Excluir.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd2b25b46577179626320fb86869190f0a537210", @"/Views/Cadastro/Excluir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2623fddcdbd39f12ba00369171034f9eb46125dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_Excluir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cadastro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Excluir"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<h1>\r\n    ALERTA!\r\n</h1>\r\n\r\n<h2>\r\n    Tem certeza que deseja Excluir o Produto \"");
#nullable restore
#line 19 "C:\Users\cassi\OneDrive\Desktop\papelariacanetas2\Views\Cadastro\Excluir.cshtml"
                                         Write(Context.Session.GetString("NomeUser"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"?\r\n</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd2b25b46577179626320fb86869190f0a5372105679", async() => {
                WriteLiteral("\r\n\r\n\r\n    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 505, "\"", 548, 1);
#nullable restore
#line 25 "C:\Users\cassi\OneDrive\Desktop\papelariacanetas2\Views\Cadastro\Excluir.cshtml"
WriteAttributeValue("", 513, Context.Session.GetInt32("UserId"), 513, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <input name=\"decisao\" type=\"submit\" value=\"EXCLUIR\">\r\n    <input name=\"decisao\" type=\"submit\" value=\"CANCELAR\">\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cadastro> Html { get; private set; }
    }
}
#pragma warning restore 1591
