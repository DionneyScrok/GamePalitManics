#pragma checksum "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65200e8d40a8f0ca9b5f6d2da1efbf5c2f49c877"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_GamePalitinho.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\_Imports.razor"
using Blazor_GamePalitinho;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\_Imports.razor"
using Blazor_GamePalitinho.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>PalitinManiacs!</h1>\r\n");
#nullable restore
#line 4 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
 if (end == false)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
     if (flag == false)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.AddMarkupContent(4, "<h3>Com quantos Palitos deseja jogar? </h3>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "id", "QtdPalitos");
            __builder.AddAttribute(7, "type", "number");
            __builder.AddAttribute(8, "max", "30");
            __builder.AddAttribute(9, "min", "20");
            __builder.AddAttribute(10, "onkeydown", "return false");
            __builder.AddAttribute(11, "hidden", 
#nullable restore
#line 10 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
                                                                                                                     flag

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
                                                                      qtdPalitos

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => qtdPalitos = __value, qtdPalitos, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "id", "StartButton");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "value", "Iniciar");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
                                                                        StartGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "hidden", 
#nullable restore
#line 11 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
                                                                                            flag

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 12 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
    }   

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "        ");
            __builder.AddMarkupContent(23, "<h3>Quantos palitos deseja retirar?</h3>\r\n        ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "id", "QtdPalitosRetirar");
            __builder.AddAttribute(26, "type", "number");
            __builder.AddAttribute(27, "max", "3");
            __builder.AddAttribute(28, "min", "1");
            __builder.AddAttribute(29, "onkeydown", "return false");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
                                                                                                    qtdPalitosaRetirar

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => qtdPalitosaRetirar = __value, qtdPalitosaRetirar, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "id", "ButtonJogar");
            __builder.AddAttribute(35, "type", "submit");
            __builder.AddAttribute(36, "value", "Retirar");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
                                                                        RetiraPalito

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        <input id=\"Reset1\" type=\"reset\" value=\"Reset\">\r\n    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n<br>\r\n");
            __builder.OpenElement(40, "div");
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenElement(42, "h4");
            __builder.AddContent(43, "O PC retirou ");
            __builder.AddContent(44, 
#nullable restore
#line 22 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
                      jogada

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(45, "  palitos.");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "h2");
            __builder.AddContent(48, "Restam ");
            __builder.AddContent(49, 
#nullable restore
#line 23 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
                qtdPalitos

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(50, "!!!");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.OpenElement(52, "p");
            __builder.AddContent(53, 
#nullable restore
#line 24 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
        msg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 26 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "    ");
            __builder.AddMarkupContent(57, "<h1>Cabo</h1>\r\n");
#nullable restore
#line 30 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\dionn\source\repos\Blazor_GamePalitinho\Blazor_GamePalitinho\Pages\Index.razor"
 
    private int qtdPalitos = 20;
    private int qtdPalitosaRetirar = 1;
    private int jogada;
    private bool flag = false;
    private string msg;
    private bool end = false;

    public void StartGame()
    {
        if (qtdPalitos > 0)
        {
            flag = true;
        }
        else
        {
            flag = false;
        }

    }


    public void RetiraPalito()
    {
        //Player
        if (qtdPalitos > 0)
        {
            qtdPalitos -= qtdPalitosaRetirar;

        }
        else
        {
            msg = "O Você venceu!";
        }

        //PC
        if (qtdPalitos > 0 && qtdPalitos != 2)
        {
            //flag = false;
            Random jogadaPc = new Random();
            jogada = jogadaPc.Next(1, 4);
            qtdPalitos -= jogada;

            if (qtdPalitos > 0 && qtdPalitos != 1)
            {
                msg = "Proxima Jogada!";

            }
            else
            {
                end = true;
                msg = "Você Venceu!";

            }
        }
        else
        {
            jogada = 1;
            qtdPalitos -= jogada;
            msg = "Voce Perdeu";
        }

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
