#pragma checksum "C:\Ruben\SBX_WEB\Shared\PanelMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae3f09efaa746f827f9bad8a495a226150d7eb5f"
// <auto-generated/>
#pragma warning disable 1591
namespace SBX_WEB.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Ruben\SBX_WEB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ruben\SBX_WEB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Ruben\SBX_WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Ruben\SBX_WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Ruben\SBX_WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Ruben\SBX_WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Ruben\SBX_WEB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Ruben\SBX_WEB\_Imports.razor"
using SBX_WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Ruben\SBX_WEB\_Imports.razor"
using SBX_WEB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Ruben\SBX_WEB\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class PanelMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(2);
            __builder.AddAttribute(3, "Text", "--");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenMenu>(6);
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(9);
                    __builder3.AddAttribute(10, "Text", "Ventas");
                    __builder3.AddAttribute(11, "Path", "VentaCrearPage");
                    __builder3.AddAttribute(12, "Icon", "shopping_cart");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(14);
                    __builder3.AddAttribute(15, "Text", "Producto");
                    __builder3.AddAttribute(16, "Path", "ProductoPage");
                    __builder3.AddAttribute(17, "Icon", "shopping_bag");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(19);
                    __builder3.AddAttribute(20, "Text", "Cliente");
                    __builder3.AddAttribute(21, "Path", "ClientePage");
                    __builder3.AddAttribute(22, "Icon", "person");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(24);
                    __builder3.AddAttribute(25, "Text", "Proveedor");
                    __builder3.AddAttribute(26, "Path", "ProveedorPage");
                    __builder3.AddAttribute(27, "Icon", "local_shipping");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(29);
                    __builder3.AddAttribute(30, "Text", "Consulta ventas");
                    __builder3.AddAttribute(31, "Path", "VentaPage");
                    __builder3.AddAttribute(32, "Icon", "local_shipping");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n            \r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
