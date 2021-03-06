#pragma checksum "D:\Carvajal\Proyecto.UI\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3873bbd49994fc9244814d9273285726fd4435e4"
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
#line 2 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudBreadcrumbs>(0);
            __builder.AddAttribute(1, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MudBlazor.BreadcrumbItem>>(
#nullable restore
#line 7 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                       _items

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n<br>\r\n<br>\r\n\r\n");
#nullable restore
#line 12 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
 if (products.Count == 0)
{



#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p>No hay productos en la base de datos</p>\r\n");
#nullable restore
#line 17 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenComponent<MudBlazor.MudIconButton>(6);
            __builder.AddAttribute(7, "Link", "/manageProducts");
            __builder.AddAttribute(8, "Style", "margin-bottom:25px;");
            __builder.AddAttribute(9, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                                                                             Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "aria-label", "Adicionar");
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.AddContent(12, "    ");
            __builder.OpenComponent<MudBlazor.MudSimpleTable>(13);
            __builder.AddAttribute(14, "Hover", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Striped", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Style", "overflow-x: auto;");
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "thead");
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.OpenElement(22, "tr");
                __builder2.AddMarkupContent(23, "\r\n");
#nullable restore
#line 25 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                 foreach (var h in headings)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(24, "                    ");
                __builder2.OpenElement(25, "th");
                __builder2.AddContent(26, 
#nullable restore
#line 27 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                         h

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n");
#nullable restore
#line 28 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(28, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenElement(31, "tbody");
                __builder2.AddMarkupContent(32, "\r\n");
#nullable restore
#line 32 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
             foreach (var row in products)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(33, "                ");
                __builder2.OpenElement(34, "tr");
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.OpenElement(36, "td");
                __builder2.AddContent(37, 
#nullable restore
#line 35 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                         row.id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenElement(39, "td");
                __builder2.AddContent(40, 
#nullable restore
#line 36 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                         row.name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __builder2.OpenElement(42, "td");
                __builder2.AddContent(43, 
#nullable restore
#line 37 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                         row.category

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                    ");
                __builder2.OpenElement(45, "td");
                __builder2.AddContent(46, 
#nullable restore
#line 38 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                         row.description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.OpenElement(48, "td");
                __builder2.AddContent(49, 
#nullable restore
#line 39 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                         row.price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                __builder2.OpenElement(51, "td");
                __builder2.OpenElement(52, "img");
                __builder2.AddAttribute(53, "src", "/images/" + (
#nullable restore
#line 40 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                                           row.imagePath

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "height", "50");
                __builder2.AddAttribute(55, "width", "50");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __builder2.OpenElement(57, "td");
                __builder2.OpenElement(58, "a");
                __builder2.AddAttribute(59, "href", "/manageProducts/" + (
#nullable restore
#line 41 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                                                  row.id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(60, "Editar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __builder2.OpenElement(62, "td");
                __builder2.OpenComponent<MudBlazor.MudButton>(63);
                __builder2.AddAttribute(64, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 42 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                                            Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                                                                        Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 42 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                                                                                                             Color.Error

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
                                                                                                                                   () => DeleteProduct(row.id)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(69, "Eliminar");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n");
#nullable restore
#line 44 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(72, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 47 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\Carvajal\Proyecto.UI\Pages\Products.razor"
       

    string[] headings = { "ID", "Nombre", "Categoria", "Descripci??n", "Precio", "Imagen", "", "" };
    List<Models.Products> products = new List<Models.Products>();
    public bool LoggedIn { get; set; }

    private List<BreadcrumbItem> _items = new List<BreadcrumbItem>
    {
        new BreadcrumbItem("Productos", href: "/products"),
        new BreadcrumbItem("Estadisticas", href: "/statistics"),
    };

    protected override async Task OnInitializedAsync()
    {
        products = await productService.GetAllProducts();
    }

    private async Task DeleteProduct(int id)
    {
        await productService.DeleteProduct(id);

        products = await productService.GetAllProducts();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
    }
}
#pragma warning restore 1591
