#pragma checksum "J:\USMP\2021-I\PROGRAMACIÓN I\Semana 07\Clase 01\Tarea\Pokemon\Views\Ciudad\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "696461f72cbcea74f1c58cab0914563d57e88bd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ciudad_Lista), @"mvc.1.0.view", @"/Views/Ciudad/Lista.cshtml")]
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
#line 1 "J:\USMP\2021-I\PROGRAMACIÓN I\Semana 07\Clase 01\Tarea\Pokemon\Views\_ViewImports.cshtml"
using Pokemon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\USMP\2021-I\PROGRAMACIÓN I\Semana 07\Clase 01\Tarea\Pokemon\Views\_ViewImports.cshtml"
using Pokemon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"696461f72cbcea74f1c58cab0914563d57e88bd6", @"/Views/Ciudad/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2c26f876c2c184762a06dc7dd097b1e06b82a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Ciudad_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ciudad>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Lista de ciudades registradas</h1>\r\n\r\n");
#nullable restore
#line 4 "J:\USMP\2021-I\PROGRAMACIÓN I\Semana 07\Clase 01\Tarea\Pokemon\Views\Ciudad\Lista.cshtml"
 if (Model.Count == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning text-center\">No hay ciudades registradas</div>\r\n");
#nullable restore
#line 6 "J:\USMP\2021-I\PROGRAMACIÓN I\Semana 07\Clase 01\Tarea\Pokemon\Views\Ciudad\Lista.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ol>\r\n");
#nullable restore
#line 9 "J:\USMP\2021-I\PROGRAMACIÓN I\Semana 07\Clase 01\Tarea\Pokemon\Views\Ciudad\Lista.cshtml"
         foreach (var c in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <div>");
#nullable restore
#line 11 "J:\USMP\2021-I\PROGRAMACIÓN I\Semana 07\Clase 01\Tarea\Pokemon\Views\Ciudad\Lista.cshtml"
                Write(c.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>");
#nullable restore
#line 12 "J:\USMP\2021-I\PROGRAMACIÓN I\Semana 07\Clase 01\Tarea\Pokemon\Views\Ciudad\Lista.cshtml"
                Write(c.Lider);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 14 "J:\USMP\2021-I\PROGRAMACIÓN I\Semana 07\Clase 01\Tarea\Pokemon\Views\Ciudad\Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\r\n");
#nullable restore
#line 16 "J:\USMP\2021-I\PROGRAMACIÓN I\Semana 07\Clase 01\Tarea\Pokemon\Views\Ciudad\Lista.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ciudad>> Html { get; private set; }
    }
}
#pragma warning restore 1591
