#pragma checksum "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8761a6da0ab370d7773328ccb95ad4016df560f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actividad_Compras), @"mvc.1.0.view", @"/Views/Actividad/Compras.cshtml")]
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
#line 1 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8761a6da0ab370d7773328ccb95ad4016df560f3", @"/Views/Actividad/Compras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Actividad_Compras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Obligatorio.Compra>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"">

    <h1 class=""display-4"">Compras</h1>


    <table class=""col table table-striped"">
        <tr>
            <th>Actividad</th>
            <th>Cant. Entradas</th>
            <th>Precio Entrada</th>
            <th>Precio Final </th>
            <th>Fecha</th>
            <th>Estado</th>

        </tr>

");
#nullable restore
#line 19 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
         foreach (var c in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                 if (c.Activa)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                     if (c.Actividad.FechaHora > DateTime.Now)
                    {
                        // actividad pr??ximas


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 30 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                       Write(c.Actividad.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 31 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                        Write(c.CantidadEntradas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 32 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                        Write(c.PrecioFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 33 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                        Write(c.CalcularPrecioFinal());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                       Write(c.Actividad.FechaHora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                         if (c.Actividad.FechaHora > DateTime.Now.AddDays(1))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td> ");
#nullable restore
#line 38 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                            Write(Html.ActionLink("Cancelar", "CancelarCompra", new { idCompra = c.Id, Class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 39 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>No es posible anular</td>\r\n");
#nullable restore
#line 43 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                         

                    }
                    else
                    {
                        // actividad pasada


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 50 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                       Write(c.Actividad.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 51 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                        Write(c.CantidadEntradas);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                        <td> ");
#nullable restore
#line 52 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                        Write(c.PrecioFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 53 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                        Write(c.CalcularPrecioFinal());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                       Write(c.Actividad.FechaHora);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>Finalizada </td>\r\n");
#nullable restore
#line 56 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                     
                }
                else
                {
                    // actividad cancelada


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 62 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                   Write(c.Actividad.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 63 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                   Write(c.CantidadEntradas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 64 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                    Write(c.PrecioFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 65 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                    Write(c.CalcularPrecioFinal());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 66 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"
                   Write(c.Actividad.FechaHora);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>Cancelada </td>\r\n");
#nullable restore
#line 68 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 71 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\Compras.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Obligatorio.Compra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
