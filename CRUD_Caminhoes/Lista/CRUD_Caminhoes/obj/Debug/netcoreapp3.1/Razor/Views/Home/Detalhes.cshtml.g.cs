#pragma checksum "C:\Users\fh160\Pessoal\Projetos\semana-5-e-6-asp.net-core\CRUD_Caminhoes\CRUD_Caminhoes\Views\Home\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1d63a8303be2d937e7a231ceb5b1023743cc9c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detalhes), @"mvc.1.0.view", @"/Views/Home/Detalhes.cshtml")]
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
#line 1 "C:\Users\fh160\Pessoal\Projetos\semana-5-e-6-asp.net-core\CRUD_Caminhoes\CRUD_Caminhoes\Views\_ViewImports.cshtml"
using CRUD_Caminhoes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fh160\Pessoal\Projetos\semana-5-e-6-asp.net-core\CRUD_Caminhoes\CRUD_Caminhoes\Views\_ViewImports.cshtml"
using CRUD_Caminhoes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1d63a8303be2d937e7a231ceb5b1023743cc9c4", @"/Views/Home/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71b36fd28340f3ca9a162f678e1f0974c839f040", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CRUD_Caminhoes.Models.Caminhao>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fh160\Pessoal\Projetos\semana-5-e-6-asp.net-core\CRUD_Caminhoes\CRUD_Caminhoes\Views\Home\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h2>Detalhes</h2>\r\n    <h5>");
#nullable restore
#line 8 "C:\Users\fh160\Pessoal\Projetos\semana-5-e-6-asp.net-core\CRUD_Caminhoes\CRUD_Caminhoes\Views\Home\Detalhes.cshtml"
   Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <hr />\r\n    <dl>\r\n        <dt>Código de identificação</dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 13 "C:\Users\fh160\Pessoal\Projetos\semana-5-e-6-asp.net-core\CRUD_Caminhoes\CRUD_Caminhoes\Views\Home\Detalhes.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>Nome</dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 17 "C:\Users\fh160\Pessoal\Projetos\semana-5-e-6-asp.net-core\CRUD_Caminhoes\CRUD_Caminhoes\Views\Home\Detalhes.cshtml"
       Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>Data de Criação</dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 21 "C:\Users\fh160\Pessoal\Projetos\semana-5-e-6-asp.net-core\CRUD_Caminhoes\CRUD_Caminhoes\Views\Home\Detalhes.cshtml"
       Write(Model.DtCriacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>Descrição</dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 25 "C:\Users\fh160\Pessoal\Projetos\semana-5-e-6-asp.net-core\CRUD_Caminhoes\CRUD_Caminhoes\Views\Home\Detalhes.cshtml"
       Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CRUD_Caminhoes.Models.Caminhao> Html { get; private set; }
    }
}
#pragma warning restore 1591
