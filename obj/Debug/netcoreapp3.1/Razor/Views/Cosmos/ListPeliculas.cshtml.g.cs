#pragma checksum "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c4509ba9b08723a7905ec5ba035c7be938dac3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cosmos_ListPeliculas), @"mvc.1.0.view", @"/Views/Cosmos/ListPeliculas.cshtml")]
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
#line 1 "C:\Users\FLORES\AZURE-FINAL\Views\_ViewImports.cshtml"
using AZURE_FINAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FLORES\AZURE-FINAL\Views\_ViewImports.cshtml"
using AZURE_FINAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c4509ba9b08723a7905ec5ba035c7be938dac3d", @"/Views/Cosmos/ListPeliculas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"640be83dcda750ce5b15d4151472abbeba99cbf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Cosmos_ListPeliculas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AZURE_FINAL.Models.Pelicula>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
  
    ViewData["Title"] = "Lista de peliculas";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n<br>\n\n<h1>LISTA DE ASISTENCIAS</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c4509ba9b08723a7905ec5ba035c7be938dac3d3645", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\n</p>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
           Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
           Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
           Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
           Write(Html.DisplayNameFor(model => model.Estreno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    \n    <tbody>\n");
#nullable restore
#line 38 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 41 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 44 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 47 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 50 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 53 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estreno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 56 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
           Write(Html.ActionLink("Edit", "Editar", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 57 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
           Write(Html.ActionLink("Details", "Detalles", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 58 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 61 "C:\Users\FLORES\AZURE-FINAL\Views\Cosmos\ListPeliculas.cshtml"
       
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>

</table>
<br>
<h1>REGISTRO MEDIANTE AZURE IOT CENTRAL - GEOLOCALIZACION</h1>
<br>
<iframe width=""1140"" height=""541.25"" src=""https://app.powerbi.com/reportEmbed?reportId=640e8409-7ce5-4013-a14c-7bb21f6bda4e&autoAuth=true&ctid=98201fef-d9f6-4e68-84f5-c2705074e342&config=eyJjbHVzdGVyVXJsIjoiaHR0cHM6Ly93YWJpLXNvdXRoLWNlbnRyYWwtdXMtcmVkaXJlY3QuYW5hbHlzaXMud2luZG93cy5uZXQvIn0%3D"" frameborder=""0"" allowFullScreen=""true""></iframe>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AZURE_FINAL.Models.Pelicula>> Html { get; private set; }
    }
}
#pragma warning restore 1591
