#pragma checksum "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "500aca9d7b4684029b7555dbd1e1a4f1a82a73c0"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
using SBX_WEB.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProveedorPage")]
    public partial class ProveedorPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-6");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-1");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(12);
            __builder.AddAttribute(13, "Icon", "add");
            __builder.AddAttribute(14, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 12 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                      ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                                                     Registro

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "Text", "");
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-1");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(22);
            __builder.AddAttribute(23, "Icon", "update");
            __builder.AddAttribute(24, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 15 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                         ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                                                        Actualizar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "Text", "");
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "  \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n<br>\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<Proveedor>>(32);
            __builder.AddAttribute(33, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "PageSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                                                      6

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Proveedor>>(
#nullable restore
#line 23 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                       ProveedorObj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "AllowColumnResize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "IsLoading", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                                                           isLoading

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Proveedor>>(42);
                __builder2.AddAttribute(43, "Property", "DNI");
                __builder2.AddAttribute(44, "Title", "DNI");
                __builder2.AddAttribute(45, "Width", "80px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Proveedor>>(47);
                __builder2.AddAttribute(48, "Property", "Nombre");
                __builder2.AddAttribute(49, "Title", "Nombre");
                __builder2.AddAttribute(50, "Width", "140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Proveedor>>(52);
                __builder2.AddAttribute(53, "Property", "Direccion");
                __builder2.AddAttribute(54, "Title", "Direccion");
                __builder2.AddAttribute(55, "Width", "140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Proveedor>>(57);
                __builder2.AddAttribute(58, "Property", "Celular");
                __builder2.AddAttribute(59, "Title", "Celular");
                __builder2.AddAttribute(60, "Width", "120px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Proveedor>>(62);
                __builder2.AddAttribute(63, "Width", "50px");
                __builder2.AddAttribute(64, "Property", "Id");
                __builder2.AddAttribute(65, "Title", "");
                __builder2.AddAttribute(66, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Proveedor>)((data) => (__builder3) => {
                    __builder3.AddMarkupContent(67, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(68);
                    __builder3.AddAttribute(69, "Icon", "create");
                    __builder3.AddAttribute(70, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 31 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                         ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "Class", "m-1");
                    __builder3.AddAttribute(72, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                                                                    () => Editar(data.Id,data.DNI,data.Nombre)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n         ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Proveedor>>(75);
                __builder2.AddAttribute(76, "Width", "50px");
                __builder2.AddAttribute(77, "Property", "Id");
                __builder2.AddAttribute(78, "Title", "");
                __builder2.AddAttribute(79, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Proveedor>)((data) => (__builder3) => {
                    __builder3.AddMarkupContent(80, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(81);
                    __builder3.AddAttribute(82, "Icon", "delete");
                    __builder3.AddAttribute(83, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 36 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                         ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(84, "Class", "m-1");
                    __builder3.AddAttribute(85, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                                                                  () => ShowInlineDialog(data.Id,data.DNI,data.Nombre)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(86, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n    ");
            }
            ));
            __builder.AddComponentReferenceCapture(88, (__value) => {
#nullable restore
#line 22 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                       ordersGrid = (Radzen.Blazor.RadzenDataGrid<Proveedor>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
       
    RadzenDataGrid<Proveedor> ordersGrid;
    bool isLoading = false;
    bool resultDialog;
    int IdGlobal = 0;
    List<Data.Proveedor> ProveedorObj = new List<Data.Proveedor>();
    Data.Proveedor ProveedorObjEliminar = new Data.Proveedor();

    List<Data.Proveedor> ProveedorObjVerificar = new List<Data.Proveedor>();
    protected override async Task OnInitializedAsync()
    {
        isLoading = true;
        ProveedorObj = await Task.Run(() => proveedorServicio.GetAllProveedorAsync());
        ProveedorObjVerificar = ProveedorObj;
        isLoading = false;
    }
    async Task Editar(int Id,string DNI, string Nombre)
    {        
        await dialogService.OpenAsync<ClienteEditarPage>($"{DNI} - {Nombre}",
               new Dictionary<string, object>() { { "Id", Id } },
               new DialogOptions() { Width = "60%",Height="85%" });
        NavigationManager.NavigateTo("ProveedorPage",true);
    } 
    async Task Registro()
    {
        await dialogService.OpenAsync<ProveedorCrearPage>($"",
               new Dictionary<string, object>() { },
               new DialogOptions() { Width = "60%",Height="85%" });
        await Actualizar();
    } 
    async Task  Actualizar()
    {
        isLoading = true;
        ProveedorObj = await Task.Run(() => proveedorServicio.GetAllProveedorAsync());
        isLoading = false;
    }

    async Task Eliminar(int Id,string DNI, string Nombre)
    {
        ProveedorObjEliminar = await Task.Run(() => proveedorServicio.GetProveedorAsync(Id));
        await  proveedorServicio.EliminarProveedorAsync(ProveedorObjEliminar);
        await Actualizar();
    } 
      async Task ShowInlineDialog(int Id,string DNI, string Nombre)
    {
     var result = await dialogService.OpenAsync("Confirmacion", ds =>
        

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(89, "div");
            __builder2.AddMarkupContent(90, "\r\n            ");
            __builder2.OpenElement(91, "p");
            __builder2.AddAttribute(92, "class", "mb-4");
            __builder2.AddContent(93, "Estas seguro de Elimiar al proveedor  ");
            __builder2.OpenElement(94, "b");
#nullable restore
#line 89 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
__builder2.AddContent(95, DNI);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(96, "<b>-</b>");
            __builder2.OpenElement(97, "b");
#nullable restore
#line 89 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
__builder2.AddContent(98, Nombre);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddContent(99, " ?");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(100, "\r\n            ");
            __builder2.OpenElement(101, "div");
            __builder2.AddAttribute(102, "class", "row");
            __builder2.AddMarkupContent(103, "\r\n                ");
            __builder2.OpenElement(104, "div");
            __builder2.AddAttribute(105, "class", "col");
            __builder2.AddMarkupContent(106, "\r\n                    ");
            __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(107);
            __builder2.AddAttribute(108, "Text", "Ok");
            __builder2.AddAttribute(109, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                   () => ds.Close(true)

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(110, "Class", "mr-1");
            __builder2.AddAttribute(111, "Style", "width: 80px;");
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(112, "\r\n                    ");
            __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(113);
            __builder2.AddAttribute(114, "Text", "Cancelar");
            __builder2.AddAttribute(115, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                         () => ds.Close(false)

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(116, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 93 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
                                                                                             ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(117, "Class", "mr-1");
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(118, "                  \r\n                ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(119, "\r\n            ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(120, "\r\n    ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(121, "\r\n");
        }
#nullable restore
#line 97 "C:\Ruben\SBX_WEB\Pages\ProveedorPage.razor"
       );

        if(result == null)
        {
            result = false;
        }       
        if (result)
        {
            await Eliminar(Id, DNI, Nombre);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProveedorServicio proveedorServicio { get; set; }
    }
}
#pragma warning restore 1591