#pragma checksum "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25d830fd25df949b160278203b8a56f082a2e2b7"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecto.UI.Components
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
#line 2 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/signin")]
    public partial class SignInForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                  model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                                        OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(7);
                __builder2.AddAttribute(8, "Style", "margin-top:250px");
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(11);
                    __builder3.AddAttribute(12, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(15, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudCard>(16);
                        __builder4.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(18, "\r\n");
#nullable restore
#line 14 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                 if (Message != null)
                {

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(19, "                    ");
                            __builder5.OpenComponent<MudBlazor.MudText>(20);
                            __builder5.AddAttribute(21, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 16 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                                   Typo.h6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(22, "Class", "red-text");
                            __builder5.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(24, 
#nullable restore
#line 16 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                                                              Message

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(25, "\r\n");
#nullable restore
#line 17 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                }

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(26, "                ");
                            __builder5.OpenComponent<MudBlazor.MudCardContent>(27);
                            __builder5.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(29, "\r\n                    ");
                                __Blazor.Proyecto.UI.Components.SignInForm.TypeInference.CreateMudTextField_0(__builder6, 30, 31, "Email", 32, "El correo con el cual te registraste en la tienda", 33, "mt-3", 34, 
#nullable restore
#line 20 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                                                                   () => model.Email

#line default
#line hidden
#nullable disable
                                , 35, 
#nullable restore
#line 20 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                                               model.Email

#line default
#line hidden
#nullable disable
                                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Email = __value, model.Email)));
                                __builder6.AddMarkupContent(37, "\r\n                    ");
                                __Blazor.Proyecto.UI.Components.SignInForm.TypeInference.CreateMudTextField_1(__builder6, 38, 39, "Password", 40, "Ingresa tu contrase??a", 41, "mt-3", 42, 
#nullable restore
#line 22 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                                                                      () => model.Password

#line default
#line hidden
#nullable disable
                                , 43, 
#nullable restore
#line 22 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                                                                                                        InputType.Password

#line default
#line hidden
#nullable disable
                                , 44, 
#nullable restore
#line 22 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                                               model.Password

#line default
#line hidden
#nullable disable
                                , 45, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Password = __value, model.Password)));
                                __builder6.AddMarkupContent(46, "\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(47, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCardActions>(48);
                            __builder5.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(50, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudButton>(51);
                                __builder6.AddAttribute(52, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 25 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                                           ButtonType.Submit

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(53, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 25 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                                                                       Variant.Filled

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(54, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 25 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
                                                                                              Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(55, "Class", "ml-auto");
                                __builder6.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(57, "Ingresar");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(58, "\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(59, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(60, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\Carvajal\Proyecto.UI\Components\SignInForm.razor"
       
    SignInAccountForm model = new SignInAccountForm();
    string Message = null;
    Models.Products product = new Products();
    bool LoggedIn = false;

    public class SignInAccountForm
    {
        [Required (ErrorMessage = "Este campo es requerido.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required (ErrorMessage = "Este campo es requerido.")]
        [StringLength(30, ErrorMessage = "Contrase??a no valida", MinimumLength = 4)]
        public string Password { get; set; }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        LoggedIn = await sessionStorage.GetItemAsync<bool>("loggedIn");
    }

    private async void OnValidSubmit(EditContext context)
    {
        StateHasChanged();

        var user = authenticationService.SignIn(model.Email, model.Password).Result;

        if (user.isLoggedIn == "false" || user.isLoggedIn == null)
            Message = "No ha sido posible iniciar sesi??n. Comprueba tus credenciales e intentalo nuevamente";
        else
            await sessionStorage.SetItemAsync<bool>("loggedIn", true);

        if (user.isLoggedIn == "true" && user.role == Roles.Admin)
            navigation.NavigateTo("/products");
        else if(user.isLoggedIn == "true" && user.role == Roles.client)
            navigation.NavigateTo("/store");
    }

    public void signOut()
    {
        sessionStorage.ClearAsync();
        LoggedIn = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthentication authenticationService { get; set; }
    }
}
namespace __Blazor.Proyecto.UI.Components.SignInForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "HelperText", __arg1);
        __builder.AddAttribute(__seq2, "Class", __arg2);
        __builder.AddAttribute(__seq3, "For", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg3, int __seq4, global::MudBlazor.InputType __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "HelperText", __arg1);
        __builder.AddAttribute(__seq2, "Class", __arg2);
        __builder.AddAttribute(__seq3, "For", __arg3);
        __builder.AddAttribute(__seq4, "InputType", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
