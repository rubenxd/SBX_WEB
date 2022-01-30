// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SBX_WEB.Pages
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
#nullable restore
#line 2 "C:\Ruben\SBX_WEB\Pages\ClienteEditarPage.razor"
using SBX_WEB.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Ruben\SBX_WEB\Pages\ClienteEditarPage.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ClienteEditarPage/{Id}")]
    public partial class ClienteEditarPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Ruben\SBX_WEB\Pages\ClienteEditarPage.razor"
       
    [Parameter]
    public int Id {get; set;}

    Cliente cliente = new Cliente();
    Cliente cliente2 = new Cliente();
    Cliente cliente3 = new Cliente();
    double DNI_ = 0;
    double telefono_ = 0;
    double celular_ = 0;
    string dniValidar = "";
    string pruebas = "0";
    bool v_ok = true;

    protected override async Task OnInitializedAsync()
    {
        cliente = await Task.Run(() => clienservicio.GetClienteAsync(Id));
        dniValidar = cliente.DNI;
        DNI_ = Convert.ToDouble(cliente.DNI);
        telefono_ = Convert.ToDouble(cliente.telefono);
        celular_ = Convert.ToDouble(cliente.Celular);
    }   

    protected async void OnSubmit(Cliente arg)
    {
        //validar DNI
         arg.DNI = DNI_.ToString();
        if (dniValidar != arg.DNI )
        {
            cliente2 = await Task.Run(() => clienservicio.GetClienteXDNIAsync(arg.DNI));
            if (cliente2 == null)
            {
                arg.DNI = DNI_.ToString();
                arg.telefono = telefono_.ToString();
                arg.Celular = celular_.ToString();
                v_ok = await clienservicio.UpdateClienteAsync(arg);
                if (v_ok)
                {
                    NavigationManager.NavigateTo("ClientePage");
                }
            }
            else
            {
                await ShowInlineDialog(arg.DNI);
            }
        }
        else
        {
            arg.DNI = DNI_.ToString();
            arg.telefono = telefono_.ToString();
            arg.Celular = celular_.ToString();
             v_ok = await clienservicio.UpdateClienteAsync(arg);
                if (v_ok)
                {
                    NavigationManager.NavigateTo("ClientePage");
                }
        }

    }
       async Task ShowInlineDialog(string DNI)
    {
        var result = await dialogService.OpenAsync("Informacion", ds =>
    

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "div");
            __builder2.AddMarkupContent(1, "\r\n        ");
            __builder2.OpenElement(2, "p");
            __builder2.AddAttribute(3, "class", "mb-4");
            __builder2.AddContent(4, "DNI: ");
            __builder2.OpenElement(5, "b");
#nullable restore
#line 165 "C:\Ruben\SBX_WEB\Pages\ClienteEditarPage.razor"
__builder2.AddContent(6, DNI);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddContent(7, " ya existe ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(8, "\r\n        ");
            __builder2.AddMarkupContent(9, "<div class=\"row\">\r\n            <div class=\"col\">\r\n                <RadzenButton Text=\"Ok\" Click=\"() => ds.Close(false)\" Class=\"mr-1\" Style=\"width: 80px;\"></RadzenButton>\r\n            </div>\r\n        </div>\r\n    ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(10, "\r\n");
        }
#nullable restore
#line 172 "C:\Ruben\SBX_WEB\Pages\ClienteEditarPage.razor"
    );

        if (result == null)
        {
            result = false;
        }
        if (result)
        {

        }
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("ClientePage",true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteServicio clienservicio { get; set; }
    }
}
#pragma warning restore 1591
