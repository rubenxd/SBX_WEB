#pragma checksum "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d08ea5890f9d1d84b029b1a4304719f347849b0f"
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
#line 1 "C:\Ruben\SBX_WEB\SBX_WEB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ruben\SBX_WEB\SBX_WEB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Ruben\SBX_WEB\SBX_WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Ruben\SBX_WEB\SBX_WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Ruben\SBX_WEB\SBX_WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Ruben\SBX_WEB\SBX_WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Ruben\SBX_WEB\SBX_WEB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Ruben\SBX_WEB\SBX_WEB\_Imports.razor"
using SBX_WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Ruben\SBX_WEB\SBX_WEB\_Imports.razor"
using SBX_WEB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Ruben\SBX_WEB\SBX_WEB\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
using SBX_WEB.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ClienteCrudPage/{Id}")]
    public partial class ClienteCrudPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Cliente>>(0);
            __builder.AddAttribute(1, "Submit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Cliente>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Cliente>(this, 
#nullable restore
#line 7 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                            OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Cliente>(
#nullable restore
#line 7 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                                           cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenFieldset>(5);
                __builder2.AddAttribute(6, "Text", "Cliente");
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n        ");
                    __builder3.OpenElement(9, "div");
                    __builder3.AddAttribute(10, "class", "alert alert-primary");
                    __builder3.AddAttribute(11, "role", "alert");
                    __builder3.AddMarkupContent(12, "\r\n            ");
#nullable restore
#line 10 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
__builder3.AddContent(13, Accion);

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(14, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(15, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "class", "row");
                    __builder3.AddMarkupContent(18, "\r\n            ");
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "col-md-4 align-items-center d-flex");
                    __builder3.AddMarkupContent(21, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(22);
                    __builder3.AddAttribute(23, "Text", "DNI");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(25, "\r\n            ");
                    __builder3.OpenElement(26, "div");
                    __builder3.AddAttribute(27, "class", "col-md-8");
                    __builder3.AddMarkupContent(28, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(29);
                    __builder3.AddAttribute(30, "style", "width: 100%;");
                    __builder3.AddAttribute(31, "Name", "DNI");
                    __builder3.AddAttribute(32, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                                                            cliente.DNI

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.DNI = __value, cliente.DNI))));
                    __builder3.AddAttribute(34, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.DNI));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(36, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(37, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(38, "div");
                    __builder3.AddAttribute(39, "class", "row");
                    __builder3.AddMarkupContent(40, "\r\n            ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "class", "col-md-4 align-items-center d-flex");
                    __builder3.AddMarkupContent(43, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(44);
                    __builder3.AddAttribute(45, "Text", "Nombre");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\r\n            ");
                    __builder3.OpenElement(48, "div");
                    __builder3.AddAttribute(49, "class", "col-md-8");
                    __builder3.AddMarkupContent(50, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(51);
                    __builder3.AddAttribute(52, "style", "width: 100%;");
                    __builder3.AddAttribute(53, "Name", "Nombre");
                    __builder3.AddAttribute(54, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                                                               cliente.Nombre

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Nombre = __value, cliente.Nombre))));
                    __builder3.AddAttribute(56, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Nombre));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "row");
                    __builder3.AddMarkupContent(62, "\r\n            ");
                    __builder3.OpenElement(63, "div");
                    __builder3.AddAttribute(64, "class", "col-md-4 align-items-center d-flex");
                    __builder3.AddMarkupContent(65, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(66);
                    __builder3.AddAttribute(67, "Text", "Ciudad");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\r\n            ");
                    __builder3.OpenElement(70, "div");
                    __builder3.AddAttribute(71, "class", "col-md-8");
                    __builder3.AddMarkupContent(72, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(73);
                    __builder3.AddAttribute(74, "style", "width: 100%;");
                    __builder3.AddAttribute(75, "Name", "Ciudad");
                    __builder3.AddAttribute(76, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                                                               cliente.Ciudad

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(77, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Ciudad = __value, cliente.Ciudad))));
                    __builder3.AddAttribute(78, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Ciudad));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(82, "div");
                    __builder3.AddAttribute(83, "class", "row");
                    __builder3.AddMarkupContent(84, "\r\n            ");
                    __builder3.OpenElement(85, "div");
                    __builder3.AddAttribute(86, "class", "col-md-4 align-items-center d-flex");
                    __builder3.AddMarkupContent(87, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(88);
                    __builder3.AddAttribute(89, "Text", "Direccion");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\r\n            ");
                    __builder3.OpenElement(92, "div");
                    __builder3.AddAttribute(93, "class", "col-md-8");
                    __builder3.AddMarkupContent(94, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(95);
                    __builder3.AddAttribute(96, "style", "width: 100%;");
                    __builder3.AddAttribute(97, "Name", "Direccion");
                    __builder3.AddAttribute(98, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                                                                  cliente.Direccion

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Direccion = __value, cliente.Direccion))));
                    __builder3.AddAttribute(100, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Direccion));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(103, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(104, "div");
                    __builder3.AddAttribute(105, "class", "row");
                    __builder3.AddMarkupContent(106, "\r\n            ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddAttribute(108, "class", "col-md-4 align-items-center d-flex");
                    __builder3.AddMarkupContent(109, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(110);
                    __builder3.AddAttribute(111, "Text", "Telefono");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(112, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\r\n            ");
                    __builder3.OpenElement(114, "div");
                    __builder3.AddAttribute(115, "class", "col-md-8");
                    __builder3.AddMarkupContent(116, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(117);
                    __builder3.AddAttribute(118, "style", "width: 100%;");
                    __builder3.AddAttribute(119, "Name", "telefono");
                    __builder3.AddAttribute(120, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                                                                 cliente.telefono

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(121, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.telefono = __value, cliente.telefono))));
                    __builder3.AddAttribute(122, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.telefono));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(123, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(124, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(125, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(126, "div");
                    __builder3.AddAttribute(127, "class", "row");
                    __builder3.AddMarkupContent(128, "\r\n            ");
                    __builder3.OpenElement(129, "div");
                    __builder3.AddAttribute(130, "class", "col-md-4 align-items-center d-flex");
                    __builder3.AddMarkupContent(131, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(132);
                    __builder3.AddAttribute(133, "Text", "Celular");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(134, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(135, "\r\n            ");
                    __builder3.OpenElement(136, "div");
                    __builder3.AddAttribute(137, "class", "col-md-8");
                    __builder3.AddMarkupContent(138, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(139);
                    __builder3.AddAttribute(140, "style", "width: 100%;");
                    __builder3.AddAttribute(141, "Name", "celular");
                    __builder3.AddAttribute(142, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                                                                cliente.Celular

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(143, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Celular = __value, cliente.Celular))));
                    __builder3.AddAttribute(144, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Celular));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(145, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(146, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(147, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(148, "div");
                    __builder3.AddAttribute(149, "class", "row");
                    __builder3.AddMarkupContent(150, "\r\n            ");
                    __builder3.OpenElement(151, "div");
                    __builder3.AddAttribute(152, "class", "col-md-4 align-items-center d-flex");
                    __builder3.AddMarkupContent(153, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(154);
                    __builder3.AddAttribute(155, "Text", "Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(156, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(157, "\r\n            ");
                    __builder3.OpenElement(158, "div");
                    __builder3.AddAttribute(159, "class", "col-md-8");
                    __builder3.AddMarkupContent(160, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(161);
                    __builder3.AddAttribute(162, "style", "width: 100%;");
                    __builder3.AddAttribute(163, "Name", "Email");
                    __builder3.AddAttribute(164, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 72 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                                                              cliente.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(165, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Email = __value, cliente.Email))));
                    __builder3.AddAttribute(166, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Email));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(167, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(168, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(169, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(170, "div");
                    __builder3.AddAttribute(171, "class", "row");
                    __builder3.AddMarkupContent(172, "\r\n            ");
                    __builder3.OpenElement(173, "div");
                    __builder3.AddAttribute(174, "class", "col-md-4 align-items-center d-flex");
                    __builder3.AddMarkupContent(175, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(176);
                    __builder3.AddAttribute(177, "Text", "Sitio web");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(178, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(179, "\r\n            ");
                    __builder3.OpenElement(180, "div");
                    __builder3.AddAttribute(181, "class", "col-md-8");
                    __builder3.AddMarkupContent(182, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(183);
                    __builder3.AddAttribute(184, "style", "width: 100%;");
                    __builder3.AddAttribute(185, "Name", "Sitio web");
                    __builder3.AddAttribute(186, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                                                                  cliente.SitioWeb

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(187, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.SitioWeb = __value, cliente.SitioWeb))));
                    __builder3.AddAttribute(188, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.SitioWeb));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(189, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(190, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(191, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(192, "\r\n    ");
                __builder2.OpenElement(193, "div");
                __builder2.AddAttribute(194, "class", "row justify-content-center");
                __builder2.AddMarkupContent(195, "\r\n        ");
                __builder2.OpenElement(196, "div");
                __builder2.AddAttribute(197, "class", "col-md-12 d-flex align-items-end justify-content-center");
                __builder2.AddAttribute(198, "style", "margin-top: 16px;");
                __builder2.AddMarkupContent(199, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(200);
                __builder2.AddAttribute(201, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 87 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                       ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(202, "Icon", "note_add");
                __builder2.AddAttribute(203, "Text", "Nuevo");
                __builder2.AddAttribute(204, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                                                                                   limpiar

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(205, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(206);
                __builder2.AddAttribute(207, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 88 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                       ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(208, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 88 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(209, "Icon", "save");
                __builder2.AddAttribute(210, "Text", "Guardar");
                __builder2.AddAttribute(211, "style", "display: inline-block; margin-left: 10px;");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(212, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(213);
                __builder2.AddAttribute(214, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 89 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                       ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(215, "Icon", "cancel");
                __builder2.AddAttribute(216, "style", "display: inline-block; margin-left: 10px;");
                __builder2.AddAttribute(217, "Text", "Cancelar");
                __builder2.AddAttribute(218, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
                                                                                                                                                      Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(219, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(220, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(221, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Ruben\SBX_WEB\SBX_WEB\Pages\ClienteCrudPage.razor"
       
    [Parameter] public int Id { get; set; }
    public bool Guardar { get; set; } = false;
    public string Accion { get; set; } = "Actualizar Cliente";
    Cliente cliente = new Cliente();

    protected override async Task OnInitializedAsync()
    {
        cliente = await Task.Run(() => clienservicio.GetClienteAsync(Id));
    }

    protected async void OnSubmit(Cliente arg)
    {
        //guardar
        if (Guardar)
        {
            await clienservicio.InsertClienteAsync(arg);
        NavigationManager.NavigateTo("ClientePage");
        }
        else
        {
            await clienservicio.UpdateClienteAsync(arg);
        NavigationManager.NavigateTo("ClientePage");
        }
        
        //
    }
    void Cancel()
    {
        //
        NavigationManager.NavigateTo("ClientePage");
    }
    void limpiar()
    {
        Guardar = true;
        Accion = "Nuevo cliente";
        cliente = new Cliente();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteServicio clienservicio { get; set; }
    }
}
#pragma warning restore 1591