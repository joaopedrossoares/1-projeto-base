#pragma checksum "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5956ed5c457746d303ce2276986d18d58007da7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuestaoAvaliacao_Index), @"mvc.1.0.view", @"/Views/QuestaoAvaliacao/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QuestaoAvaliacao/Index.cshtml", typeof(AspNetCore.Views_QuestaoAvaliacao_Index))]
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
#line 1 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\_ViewImports.cshtml"
using PUC.LDSI.MVC;

#line default
#line hidden
#line 2 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\_ViewImports.cshtml"
using PUC.LDSI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5956ed5c457746d303ce2276986d18d58007da7d", @"/Views/QuestaoAvaliacao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fbc051568c856e0ae86b15790b1ad608a48f97", @"/Views/_ViewImports.cshtml")]
    public class Views_QuestaoAvaliacao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AvaliacaoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Avaliacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OpcaoAvaliacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
  
    ViewData["Title"] = "Avaliação";
    ViewData["Subtitle"] = Model.Disciplina + " / " + Model.Materia + " / " + Model.Descricao;

#line default
#line hidden
            BeginContext(170, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(177, 17, false);
#line 8 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(194, 13, true);
            WriteLiteral("</h2>\r\n\r\n<h4>");
            EndContext();
            BeginContext(208, 20, false);
#line 10 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
Write(ViewData["Subtitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(228, 18, true);
            WriteLiteral("</h4>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(246, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f56d6d7435884f34aa2577949961e531", async() => {
                BeginContext(327, 12, true);
                WriteLiteral("Nova Questão");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-avaliacaoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
                                      WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["avaliacaoId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-avaliacaoId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["avaliacaoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(343, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(349, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa08d388daa04c4e9fe994c44711c00a", async() => {
                BeginContext(422, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(432, 465, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Tipo
            </th>
            <th>
                Enunciado
            </th>
            <th>
                Nº Opções
            </th>
            <th>
                Ações
            </th>
            <th>
                Válida
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 40 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
         foreach (var i in Model.ListQuestaoAvaliacao)
        {

#line default
#line hidden
            BeginContext(964, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1025, 34, false);
#line 44 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
               Write(Html.DisplayFor(modelItem => i.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 46 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
                 if (i.Tipo == 1)
                {

#line default
#line hidden
            BeginContext(1138, 47, true);
            WriteLiteral("                    <td>Múltipla Escolha</td>\r\n");
            EndContext();
#line 49 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
                }
                else if (i.Tipo == 2)
                {

#line default
#line hidden
            BeginContext(1262, 50, true);
            WriteLiteral("                    <td>Verdadeiro ou Falso</td>\r\n");
            EndContext();
#line 53 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1331, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1374, 41, false);
#line 55 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
               Write(Html.DisplayFor(modelItem => i.Enunciado));

#line default
#line hidden
            EndContext();
            BeginContext(1415, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1483, 52, false);
#line 58 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
               Write(Html.DisplayFor(modelItem => i.OpcaoAvaliacao.Count));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1602, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02128624022b4da8888505fafe102b45", async() => {
                BeginContext(1644, 42, true);
                WriteLiteral("<i class=\"fas fa-edit\" title=\"Editar\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
                                           WriteLiteral(i.Id);

#line default
#line hidden
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
            BeginContext(1690, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1712, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9173d1073af24671bc447aa4378b7add", async() => {
                BeginContext(1794, 102, true);
                WriteLiteral("\r\n                        <i class=\"fas fa-tools\" title=\"Construir Questão\"></i>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-questaoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
                                                                                   WriteLiteral(i.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questaoId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-questaoId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questaoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1900, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1922, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afb65bf9330e44e8a88f38aeb569da05", async() => {
                BeginContext(1966, 44, true);
                WriteLiteral("<i class=\"fas fa-trash\" title=\"Excluir\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
                                             WriteLiteral(i.Id);

#line default
#line hidden
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
            BeginContext(2014, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 68 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
                     if (i.Erro.Equals(""))
                    {

#line default
#line hidden
            BeginContext(2129, 70, true);
            WriteLiteral("                        <i style=\"color: #00ff00\" class=\"fas fa-check\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2199, "\"", 2214, 1);
#line 70 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
WriteAttributeValue("", 2207, i.Erro, 2207, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2215, 5, true);
            WriteLiteral("></i>");
            EndContext();
#line 70 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
                                                                                           ;
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2295, 70, true);
            WriteLiteral("                        <i style=\"color: #ff0000\" class=\"fas fa-times\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2365, "\"", 2380, 1);
#line 74 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
WriteAttributeValue("", 2373, i.Erro, 2373, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2381, 7, true);
            WriteLiteral("></i>\r\n");
            EndContext();
#line 75 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2411, 44, true);
            WriteLiteral("                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 79 "C:\Users\PICHAU\source\repos\vouf\PUC.LDSI.MVC\Views\QuestaoAvaliacao\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2466, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AvaliacaoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
