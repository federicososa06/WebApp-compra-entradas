#pragma checksum "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\CompraConfirmada.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4bf9cd7ab84760e93ed7fd8ae925859aaff9159"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actividad_CompraConfirmada), @"mvc.1.0.view", @"/Views/Actividad/CompraConfirmada.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4bf9cd7ab84760e93ed7fd8ae925859aaff9159", @"/Views/Actividad/CompraConfirmada.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Actividad_CompraConfirmada : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Obligatorio.Compra>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n\r\n    <h1>Compra confirmada</h1>\r\n\r\n    <p>");
#nullable restore
#line 7 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\CompraConfirmada.cshtml"
  Write(Model.Usuario.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 8 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\CompraConfirmada.cshtml"
  Write(Model.Actividad.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 9 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\CompraConfirmada.cshtml"
  Write(Model.CalcularPrecioFinal());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 10 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\CompraConfirmada.cshtml"
  Write(Model.CantidadEntradas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 11 "C:\Users\feder\Desktop\Fede\ORT\SEGUNDO SEMESTRE\Programacion 2\Obligatorio2\WebApplication1\WebApplication1\Views\Actividad\CompraConfirmada.cshtml"
  Write(Model.FechaHora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Obligatorio.Compra> Html { get; private set; }
    }
}
#pragma warning restore 1591
