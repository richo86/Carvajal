// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "D:\Carvajal\Proyecto.UI\Pages\StoreProducts.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Carvajal\Proyecto.UI\Pages\StoreProducts.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/store/{text}")]
    public partial class StoreProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Carvajal\Proyecto.UI\Pages\StoreProducts.razor"
       
    [Parameter]
    public string text { get; set; }

    List<Models.Cart> cartList = new List<Models.Cart>();

    Models.Cart cart = new Models.Cart();

    public bool LoggedIn = false;

    List<Models.Products> products = new List<Models.Products>();

    string path = "/images/";

    int i = 0;

    int[] quantityList;

    int currentIndex = 0;

    private List<BreadcrumbItem> _items = new List<BreadcrumbItem>
    {
        new BreadcrumbItem("Tienda", href: "/store"),
        new BreadcrumbItem("Carrito", href: "/cart"),
    };

    protected override async Task OnInitializedAsync()
    {
        products = await productService.GetAllProducts();

        var category = (Categorias)Enum.Parse(typeof(Categorias), text);

        products = products.Where(x => x.category == category).ToList();

        quantityList = new int[products.Count()];
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        LoggedIn = await sessionStorage.GetItemAsync<bool>("loggedIn");

        StateHasChanged();
    }

    private void navigateBack()
    {
        navigation.NavigateTo("/store");
    }

    private void onSelect(ChangeEventArgs e)
    {
        quantityList[currentIndex] = Convert.ToInt32(e.Value);
    }

    private async Task AddToCart(int id, bool redirect, int index)
    {
        var selectedProduct = products.Where(x => x.id == id).FirstOrDefault();

        cart.imagePath = selectedProduct.imagePath;
        cart.Price = selectedProduct.price;
        cart.ProductName = selectedProduct.name;
        cart.ProductId = id;
        cart.Quantity = 1;

        cartList.Add(cart);

        await sessionStorage.SetItemAsync<List<Models.Cart>>("cart", cartList);

        cart = new Models.Cart();

        if (redirect)
            navigation.NavigateTo("/cart");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
    }
}
#pragma warning restore 1591