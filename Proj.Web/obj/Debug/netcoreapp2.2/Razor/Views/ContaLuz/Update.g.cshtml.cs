#pragma checksum "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbbb0716cfded29fe4c8c45ce16bf80710dfcb8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContaLuz_Update), @"mvc.1.0.view", @"/Views/ContaLuz/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ContaLuz/Update.cshtml", typeof(AspNetCore.Views_ContaLuz_Update))]
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
#line 1 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\_ViewImports.cshtml"
using Proj.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbbb0716cfded29fe4c8c45ce16bf80710dfcb8c", @"/Views/ContaLuz/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9904adfed7a1c0590d46c36d800a7d74b04431f", @"/Views/_ViewImports.cshtml")]
    public class Views_ContaLuz_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proj.Domain.Entities.ContaLuz>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 48, true);
            WriteLiteral("\r\n<h2 class=\"text-center\">Contas de Luz</h2>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(121, 28, false);
#line 7 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(162, 33, false);
#line 9 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
   Write(Html.HiddenFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(199, 284, true);
            WriteLiteral(@"        <div class=""form-group col-12 col-sm-8 col-md-6 mx-auto"">
            <div class=""editor-label"">
                Imovel
            </div>
            <div class=""editor-field"">
                <select class=""form-control"" name=""imovel.id"" required>
                    ");
            EndContext();
            BeginContext(483, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbbb0716cfded29fe4c8c45ce16bf80710dfcb8c4663", async() => {
                BeginContext(509, 18, true);
                WriteLiteral("Selecione o Imovel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(536, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
                     foreach(var imovel in ViewBag.Imoveis)
                    {

#line default
#line hidden
            BeginContext(622, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(646, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbbb0716cfded29fe4c8c45ce16bf80710dfcb8c6738", async() => {
                BeginContext(718, 20, false);
#line 20 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
                                                                                          Write(imovel.identificacao);

#line default
#line hidden
                EndContext();
                BeginContext(738, 3, true);
                WriteLiteral(" | ");
                EndContext();
                BeginContext(742, 13, false);
#line 20 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
                                                                                                                  Write(imovel.cidade);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
                           WriteLiteral(imovel.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
AddHtmlAttributeValue("", 683, @imovel.id == Model.imovel.id, 683, 32, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(764, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
                    }

#line default
#line hidden
            BeginContext(789, 66, true);
            WriteLiteral("                </select>   \r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(857, 213, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n            <div class=\"editor-label\">\r\n                Data Leitura\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(1071, 99, false);
#line 31 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
           Write(Html.EditorFor(model => model.dataLeitura, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1225, 53, false);
#line 32 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.dataLeitura));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 46, true);
            WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(1326, 209, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n            <div class=\"editor-label\">\r\n                KW Gasto\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(1536, 95, false);
#line 41 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
           Write(Html.EditorFor(model => model.kwGasto, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1686, 49, false);
#line 42 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.kwGasto));

#line default
#line hidden
            EndContext();
            BeginContext(1735, 46, true);
            WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(1783, 214, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n            <div class=\"editor-label\">\r\n                Valor a pagar\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(1998, 99, false);
#line 51 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
           Write(Html.EditorFor(model => model.valorAPagar, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(2097, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(2152, 53, false);
#line 52 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.valorAPagar));

#line default
#line hidden
            EndContext();
            BeginContext(2205, 46, true);
            WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(2253, 215, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n            <div class=\"editor-label\">\r\n                Data Pagamento\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(2469, 101, false);
#line 61 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
           Write(Html.EditorFor(model => model.dataPagamento, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(2570, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(2625, 55, false);
#line 62 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.dataPagamento));

#line default
#line hidden
            EndContext();
            BeginContext(2680, 46, true);
            WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(2728, 217, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n            <div class=\"editor-label\">\r\n                Média de Consumo\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(2946, 100, false);
#line 71 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
           Write(Html.EditorFor(model => model.mediaConsumo, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(3046, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(3101, 54, false);
#line 72 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.mediaConsumo));

#line default
#line hidden
            EndContext();
            BeginContext(3155, 46, true);
            WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(3203, 156, true);
            WriteLiteral("        <div class=\"d-block text-center\">\r\n            <button type=\"submit\" class=\"btn btn-primary d-block my-4 mx-auto\">Atualizar</button>\r\n\r\n            ");
            EndContext();
            BeginContext(3360, 93, false);
#line 79 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
       Write(Html.ActionLink("Voltar para listagem", "Index", null, null, new { @class = "mt-2 d-block" }));

#line default
#line hidden
            EndContext();
            BeginContext(3453, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 81 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\ContaLuz\Update.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proj.Domain.Entities.ContaLuz> Html { get; private set; }
    }
}
#pragma warning restore 1591
