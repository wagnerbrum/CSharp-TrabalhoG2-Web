#pragma checksum "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9865108547c6a7f293595bffbce3ddb9a788d22a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Imovel_Update), @"mvc.1.0.view", @"/Views/Imovel/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Imovel/Update.cshtml", typeof(AspNetCore.Views_Imovel_Update))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9865108547c6a7f293595bffbce3ddb9a788d22a", @"/Views/Imovel/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9904adfed7a1c0590d46c36d800a7d74b04431f", @"/Views/_ViewImports.cshtml")]
    public class Views_Imovel_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proj.Domain.Entities.Imovel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 42, true);
            WriteLiteral("\r\n<h2 class=\"text-center\">Imóveis</h2>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(113, 28, false);
#line 7 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(154, 33, false);
#line 9 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
   Write(Html.HiddenFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(191, 214, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n            <div class=\"editor-label\">\r\n                Identificação\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(406, 101, false);
#line 16 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
           Write(Html.EditorFor(model => model.identificacao, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(507, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(562, 55, false);
#line 17 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.identificacao));

#line default
#line hidden
            EndContext();
            BeginContext(617, 46, true);
            WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(665, 207, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n            <div class=\"editor-label\">\r\n                Estado\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(873, 94, false);
#line 26 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
           Write(Html.EditorFor(model => model.estado, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(967, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1022, 48, false);
#line 27 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.estado));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 46, true);
            WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(1118, 207, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n            <div class=\"editor-label\">\r\n                Cidade\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(1326, 94, false);
#line 36 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
           Write(Html.EditorFor(model => model.cidade, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1420, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1475, 48, false);
#line 37 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1523, 46, true);
            WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(1571, 207, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n            <div class=\"editor-label\">\r\n                Bairro\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(1779, 94, false);
#line 46 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
           Write(Html.EditorFor(model => model.bairro, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1873, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1928, 48, false);
#line 47 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1976, 46, true);
            WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(2024, 207, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n            <div class=\"editor-label\">\r\n                Numero\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(2232, 94, false);
#line 56 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
           Write(Html.EditorFor(model => model.numero, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(2326, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(2381, 48, false);
#line 57 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.numero));

#line default
#line hidden
            EndContext();
            BeginContext(2429, 46, true);
            WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(2477, 156, true);
            WriteLiteral("        <div class=\"d-block text-center\">\r\n            <button type=\"submit\" class=\"btn btn-primary d-block my-4 mx-auto\">Atualizar</button>\r\n\r\n            ");
            EndContext();
            BeginContext(2634, 93, false);
#line 64 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
       Write(Html.ActionLink("Voltar para listagem", "Index", null, null, new { @class = "mt-2 d-block" }));

#line default
#line hidden
            EndContext();
            BeginContext(2727, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 66 "C:\Users\Wagner\Desktop\Desenvolvimento c#\Ulbra\2019_2\linguagem_comercial\G2_Projeto1\Proj.Web\Views\Imovel\Update.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proj.Domain.Entities.Imovel> Html { get; private set; }
    }
}
#pragma warning restore 1591
