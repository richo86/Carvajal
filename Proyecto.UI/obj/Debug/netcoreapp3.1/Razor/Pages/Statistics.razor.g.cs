#pragma checksum "D:\Carvajal\Proyecto.UI\Pages\Statistics.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "513ea655ae47f8db65b33016cb89cb440f597f91"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecto.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Carvajal\Proyecto.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Carvajal\Proyecto.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Carvajal\Proyecto.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Carvajal\Proyecto.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Carvajal\Proyecto.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Carvajal\Proyecto.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Carvajal\Proyecto.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Carvajal\Proyecto.UI\_Imports.razor"
using Proyecto.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Carvajal\Proyecto.UI\_Imports.razor"
using Proyecto.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Carvajal\Proyecto.UI\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Carvajal\Proyecto.UI\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Carvajal\Proyecto.UI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Carvajal\Proyecto.UI\_Imports.razor"
using Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Carvajal\Proyecto.UI\Pages\Statistics.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Carvajal\Proyecto.UI\Pages\Statistics.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/statistics")]
    public partial class Statistics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudBreadcrumbs>(0);
            __builder.AddAttribute(1, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MudBlazor.BreadcrumbItem>>(
#nullable restore
#line 8 "D:\Carvajal\Proyecto.UI\Pages\Statistics.razor"
                       _items

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<MudBlazor.MudChart>(5);
            __builder.AddAttribute(6, "ChartType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ChartType>(
#nullable restore
#line 11 "D:\Carvajal\Proyecto.UI\Pages\Statistics.razor"
                         ChartType.Bar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChartSeries", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MudBlazor.ChartSeries>>(
#nullable restore
#line 11 "D:\Carvajal\Proyecto.UI\Pages\Statistics.razor"
                                                      Series

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "XAxisLabels", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 11 "D:\Carvajal\Proyecto.UI\Pages\Statistics.razor"
                                                                                                        XAxisLabels

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Width", "100%");
            __builder.AddAttribute(10, "Height", "600px");
            __builder.AddAttribute(11, "SelectedIndex", 
#nullable restore
#line 11 "D:\Carvajal\Proyecto.UI\Pages\Statistics.razor"
                                                                                   Index

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "SelectedIndexChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Index = __value, Index));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\Carvajal\Proyecto.UI\Pages\Statistics.razor"
       
    public List<Sales> sales { get; set; }

    public bool LoggedIn { get; set; }

    private int Index = -10;

    public List<ChartSeries> Series = new List<ChartSeries>();

    public string[] XAxisLabels = { "Ventas" };

    private List<BreadcrumbItem> _items = new List<BreadcrumbItem>
    {
        new BreadcrumbItem("Productos", href: "/products"),
        new BreadcrumbItem("Estadisticas", href: "/statistics"),
    };

    protected override async Task OnInitializedAsync()
    {
        sales = await salesService.GetSales();

        var groups = from sale in sales
                     group sale by sale.ProductId into newGroup
                     orderby newGroup.Key
                     select newGroup;

        foreach(var item in groups)
        {
            Series.Add(new ChartSeries() { Name = item.FirstOrDefault().ProductName, Data = new double[] { item.FirstOrDefault().Quantity } });
        }

        StateHasChanged();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        LoggedIn = await sessionStorage.GetItemAsync<bool>("loggedIn");
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISalesService salesService { get; set; }
    }
}
#pragma warning restore 1591
