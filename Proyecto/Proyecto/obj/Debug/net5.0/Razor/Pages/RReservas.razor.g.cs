#pragma checksum "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a54fb12d101e2083b40de077383a9683a3b16b1c"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecto.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Proyecto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Proyecto.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using MoreLinq.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RReservas")]
    public partial class RReservas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.AddMarkupContent(4, "<div class=\"card-header\"><h3>Reservar Vehiculo</h3></div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
#nullable restore
#line 11 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
             if (vofCargar)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\r\n                    Cliente:\r\n                    ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "disabled");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                                       ClienteNombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ClienteNombre = __value, ClienteNombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-secondary btn-block");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                                                          Cambiar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Seleccionar Cliente");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "\r\n                    Desde:\r\n                    ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "date");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                              fecha1

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fecha1 = __value, fecha1, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddMarkupContent(32, "\r\n                    Hasta:\r\n                    ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "date");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                              fecha2

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fecha2 = __value, fecha2, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-secondary btn-block");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                                                          Cambiar2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Seleccionar Vehiculos Disponibles en esa fecha");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-group");
            __builder.AddMarkupContent(46, "\r\n                    Vehiculo:\r\n                    ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "disabled");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                                       VehiculoNombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => VehiculoNombre = __value, VehiculoNombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"


               
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
     if (vof)
    {




#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "contenedor-modal");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "ventana ");
#nullable restore
#line 47 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
         if (vofCliente)
        {



#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "card text-center overflow-auto");
            __builder.AddMarkupContent(58, "<div class=\"card-header \">\r\n                    Seleccionar Cliente\r\n                </div>\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "card-body ");
            __builder.OpenElement(61, "table");
            __builder.AddAttribute(62, "class", "table table-responsive-sm table-hover");
            __builder.AddMarkupContent(63, "<thead><tr><th>Foto</th>\r\n                                <th>Cliente</th>\r\n                                <th>Seleccionar</th></tr></thead>\r\n                        ");
            __builder.OpenElement(64, "tbody");
#nullable restore
#line 68 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                             foreach (var x in clientes)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(65, "tr");
            __builder.OpenElement(66, "td");
            __builder.OpenElement(67, "a");
            __builder.AddAttribute(68, "href", 
#nullable restore
#line 71 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                              x.FotoP

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(69, "target", "_blank");
            __builder.OpenElement(70, "img");
            __builder.AddAttribute(71, "src", 
#nullable restore
#line 71 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                                                                  x.FotoP

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(72, "height", "100");
            __builder.AddAttribute(73, "width", "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 72 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                 x.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(77, " ");
            __builder.AddContent(78, 
#nullable restore
#line 72 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                           x.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                ");
            __builder.OpenElement(80, "td");
            __builder.OpenElement(81, "button");
            __builder.AddAttribute(82, "class", "btn btn-primary btn-block");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                                                                         (() => ObtenerCliente(x.ID, x.Nombre, x.Apellido))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(84, " \r\n                                    SELECCIONAR\r\n                                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 77 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "card-footer");
            __builder.OpenElement(88, "button");
            __builder.AddAttribute(89, "class", "btn btn-dark btn-block");
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                                                     Cambiar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(91, "Cerrar Ventana");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 86 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 92 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
     if(vof2)
            {



#line default
#line hidden
#nullable disable
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "contenedor-modal");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "ventana");
#nullable restore
#line 101 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
         if (vofVehiculo)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "card text-center overflow-auto");
            __builder.AddMarkupContent(98, "<div class=\"card-header \">\r\n                    Seleccionar Vehiculo\r\n                </div>\r\n                ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "card-body ");
            __builder.OpenElement(101, "table");
            __builder.AddAttribute(102, "class", "table table-responsive-sm table-hover");
            __builder.AddMarkupContent(103, "<thead><tr><th>Foto</th>\r\n                                <th>Vehiculo</th>\r\n                                <th>Seleccionar</th></tr></thead>\r\n                        ");
            __builder.OpenElement(104, "tbody");
#nullable restore
#line 120 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                             foreach (var x in vehiculos)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(105, "tr");
            __builder.OpenElement(106, "td");
            __builder.OpenElement(107, "a");
            __builder.AddAttribute(108, "href", 
#nullable restore
#line 123 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                                  x.Foto

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(109, "target", "_blank");
            __builder.OpenElement(110, "img");
            __builder.AddAttribute(111, "src", 
#nullable restore
#line 123 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                                                                     x.Foto

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(112, "height", "100");
            __builder.AddAttribute(113, "width", "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                                    ");
            __builder.OpenElement(115, "td");
            __builder.AddContent(116, 
#nullable restore
#line 124 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                         x.Marca

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(117, " - ");
            __builder.AddContent(118, 
#nullable restore
#line 124 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                                    x.Modelo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(119, " - ");
            __builder.AddContent(120, 
#nullable restore
#line 124 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                                                x.Color

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                                    ");
            __builder.OpenElement(122, "td");
            __builder.OpenElement(123, "button");
            __builder.AddAttribute(124, "class", "btn btn-primary btn-block");
            __builder.AddAttribute(125, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 126 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                                                                            (() => ObtenerVehiculo(x.ID, x.Marca, x.Modelo, x.Color))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(126, "\r\n                                            SELECCIONAR\r\n                                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 131 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "card-footer");
            __builder.OpenElement(130, "button");
            __builder.AddAttribute(131, "class", "btn btn-dark btn-block");
            __builder.AddAttribute(132, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 137 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
                                                                     Cambiar2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(133, "Cerrar Ventana");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 140 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 146 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n");
            __builder.AddContent(135, 
#nullable restore
#line 152 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
 status

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 157 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RReservas.razor"
             // ----------------------------------------------------------- BEGIN -------------------------------------------------------------

    List<Reservas> reservas;
    List<Clientes> clientes;
    List<Vehiculos> vehiculos = new List<Vehiculos>();
    bool vofCargar = true;
    string modal = "contenedor-modal";
    bool vof = false;
    bool vof2 = false;

    bool vofCliente = false;
    bool vofVehiculo = false;

    string ClienteNombre = "";
    string ClienteID = "";
    string VehiculoNombre = "";
    string VehiculoID = "";
    string status = "";
    DateTime fecha1 = Convert.ToDateTime("02/02/2002");
    DateTime fecha2 = Convert.ToDateTime("02/03/2002");





    public async Task Cambiar()
    {
        if (vof)
        {
            vof = false;
        }
        else
        {
            vof = true;
            await VerClientes();
        }
    }

    public async Task Cambiar2()
    {
        if (vof2)
        {
            vof2 = false;
        }
        else
        {
            vof2 = true;
            await VerVehiculos();
        }
    }


    async Task VerClientes()
    {

        HttpClient http = new HttpClient();
        string URI = "https://finalprog3-930fc-default-rtdb.firebaseio.com/Clientes.json";

        var response = await http.GetAsync(URI);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();

            var datos = JsonConvert.DeserializeObject<Dictionary<string, Clientes>>(content).ToList();

            var datos2 = from xd in datos
                         select new Clientes
                         {
                             ID = xd.Key,
                             Apellido = xd.Value.Apellido,
                             Cedula = xd.Value.Cedula,
                             Correo = xd.Value.Correo,
                             Estado = xd.Value.Estado,
                             FotoL = xd.Value.FotoL,
                             FotoP = xd.Value.FotoP,
                             Licencia = xd.Value.Licencia,
                             Nacionalidad = xd.Value.Nacionalidad,
                             Nombre = xd.Value.Nombre,
                             Sangre = xd.Value.Sangre



                         };

            clientes = datos2.ToList();

            vofCliente = true;
        }


        // --------------------------------------- END --------------------------------------------------------
    }


    async Task ObtenerCliente(string id, string nombre, string apellido)
    {

        ClienteNombre = $"{nombre} {apellido}";
        ClienteID = id;

        await Cambiar();


    }

    async Task ObtenerVehiculo(string id, string marca, string modelo, string color)
    {

        VehiculoNombre = $"{marca} - {modelo} - {color}";
        VehiculoID = id;

        await Cambiar2();


    }



    async Task VerVehiculos()
    {

        HttpClient http = new HttpClient();

        string URI = "https://finalprog3-930fc-default-rtdb.firebaseio.com/Reservas.json";


        var response = http.GetAsync(URI);

        if (response.Result.IsSuccessStatusCode)
        {
            var content = await response.Result.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<Dictionary<string, Reservas>>(content).ToList();

            var data2 = from x in data
                        select new Reservas
                        {
                            VehiculoID = x.Value.VehiculoID,
                            Estado = x.Value.Estado,
                            Desde = x.Value.Desde,
                            Hasta = x.Value.Hasta
                        };

            var data3 = data2.Where(x => (Convert.ToInt32(fecha1.ToString("MMddyyyy")) >= Convert.ToInt32( x.Desde.ToString("MMddyyyy")) &&  Convert.ToInt32(fecha2.ToString("MMddyyyy")) <= Convert.ToInt32(x.Hasta.ToString("MMddyyyy"))) || (fecha1 <= x.Desde && fecha2 >= x.Hasta )).Select(x => (x.VehiculoID, x.Hasta, x.Desde, x.Estado)).ToList();

            var data4 = from x in data3 select new Reservas { Hasta = x.Hasta, Desde = x.Desde, Estado = x.Estado, VehiculoID = x.VehiculoID };

            reservas = data4.ToList();




            var response2 = await http.GetAsync($"https://finalprog3-930fc-default-rtdb.firebaseio.com/Vehiculos.json");
            if (response2.IsSuccessStatusCode)
            {
                var content2 = await response2.Content.ReadAsStringAsync();

                var dato7 = JsonConvert.DeserializeObject<Dictionary<string, Vehiculos>>(content2).ToList();


                var dato2 = (from dato in dato7 select new Vehiculos
                {

                    ID = dato.Key,
                    Carga = dato.Value.Carga,
                    Color = dato.Value.Color,
                    Estado = dato.Value.Estado,
                    Foto = dato.Value.Foto,
                    Lat = dato.Value.Lat,
                    Lng = dato.Value.Lng,
                    Seguro = dato.Value.Seguro,
                    Marca = dato.Value.Marca,
                    Matricula = dato.Value.Matricula,
                    Modelo = dato.Value.Modelo,
                    Pasajeros = dato.Value.Pasajeros,
                    Price = dato.Value.Price,
                    Tipo = dato.Value.Tipo,
                    Year = dato.Value.Year



                }).ToList();
                vehiculos.Clear();
                // foreach (var x in reservas)
                //  {
                // status += $"- {x.VehiculoID} -";
                int num = 0;
                int num2 = 0;
                bool vofNum = false;

                //
                // int z = reservas.Count();
                var dato5 = (from x in reservas
                             from z in dato2

                             where z.ID != x.VehiculoID
                             select new
                             {
                                 z.ID
                             }



                             ) ;
                //vehiculos = dato5;

                var dato8 = from x in reservas select new Vehiculos { ID = x.VehiculoID };

                vehiculos = dato2.ExceptBy(dato8, c => c.ID).ToList();
                //




                //  }


            }


            // vehiculos = lista.ToList();
            vofVehiculo = true;
            //await Cambiar2();
        }




    }




    //------------------------------------ END --------------------------------------------------------

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
