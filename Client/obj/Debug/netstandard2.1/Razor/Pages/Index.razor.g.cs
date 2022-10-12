#pragma checksum "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f52ae4ca70860f253bb1d65a8379d370e28ed5a6"
// <auto-generated/>
#pragma warning disable 1591
namespace HospitalSystem.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rikesh\source\repos\HospitalSystem\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rikesh\source\repos\HospitalSystem\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rikesh\source\repos\HospitalSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rikesh\source\repos\HospitalSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rikesh\source\repos\HospitalSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rikesh\source\repos\HospitalSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rikesh\source\repos\HospitalSystem\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rikesh\source\repos\HospitalSystem\Client\_Imports.razor"
using HospitalSystem.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rikesh\source\repos\HospitalSystem\Client\_Imports.razor"
using HospitalSystem.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rikesh\source\repos\HospitalSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rikesh\source\repos\HospitalSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\rikesh\source\repos\HospitalSystem\Client\_Imports.razor"
using HospitalSystem.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenElement(4, "h1");
                __builder2.AddContent(5, "Hello, ");
                __builder2.AddContent(6, 
#nullable restore
#line 8 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Index.razor"
                    context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, " !");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n    ");
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<h1>You are not authorized to access this page </h1>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<HospitalSystem.Client.Shared.SurveyPrompt>(13);
            __builder.AddAttribute(14, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(16);
            __builder.AddAttribute(17, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n        <br><br>\r\n        ");
                __builder2.OpenElement(19, "button");
                __builder2.AddAttribute(20, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Index.razor"
                                                          DisplayGreetingMessage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(22, "Greetings");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Index.razor"
      
    [CascadingParameter]
    private Task<AuthenticationState> authenticationState { get; set; }

    private async Task DisplayGreetingMessage()
    {
        var authState = await authenticationState;
        var Message = $"Welcome { authState.User.Identity.Name}";
        await js.InvokeVoidAsync("alert", Message);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
