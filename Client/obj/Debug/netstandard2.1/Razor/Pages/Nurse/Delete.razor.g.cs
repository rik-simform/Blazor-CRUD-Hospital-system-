#pragma checksum "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Nurse\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f56ab917fb19ddaa05da203ebf0b82f48dbef3e4"
// <auto-generated/>
#pragma warning disable 1591
namespace HospitalSystem.Client.Pages.Nurse
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
#nullable restore
#line 2 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Nurse\Delete.razor"
using HospitalSystem.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/nurse/{Id}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Delete Person</h2>\r\n");
#nullable restore
#line 7 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Nurse\Delete.razor"
 if (nurse != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, "Are you sure you want to delete this person with Name: ");
            __builder.OpenElement(4, "b");
            __builder.AddContent(5, 
#nullable restore
#line 9 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Nurse\Delete.razor"
                                                                  nurse.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.AddMarkupContent(15, "<td>Name</td>\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 14 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Nurse\Delete.razor"
                     nurse.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.AddMarkupContent(22, "<td>Birth Date</td>\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 18 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Nurse\Delete.razor"
                     nurse.BirthDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.AddMarkupContent(29, "<td>Shift-Time</td>\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 22 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Nurse\Delete.razor"
                     nurse.ShiftTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n            ");
            __builder.OpenElement(34, "tr");
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.AddMarkupContent(36, "<td>Joining Date</td>\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 27 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Nurse\Delete.razor"
                     nurse.JoiningDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 31 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Nurse\Delete.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "row");
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-md-4");
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "form-group");
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "button");
            __builder.AddAttribute(54, "class", "btn btn-primary");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Nurse\Delete.razor"
                                                                    Deleted

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "class", "btn");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Nurse\Delete.razor"
                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Nurse\Delete.razor"
       
    [Parameter]
    public int Id { get; set; }
    Nurse nurse = new Nurse();
    protected override async Task OnInitializedAsync()
    {
        nurse = await Http.GetFromJsonAsync<Nurse>("api/nurse/" + Id);
    }
    protected async Task Deleted()
    {
        var response = await Http.DeleteAsync("api/nurse/" + Id);
        bool deleteResponse = await response.Content.ReadFromJsonAsync<bool>();
        if (deleteResponse)
        {
            await JsRuntime.InvokeVoidAsync("alert", "Deleted Successfully!");
            NavigationManager.NavigateTo("/Nurse");
        }
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("/nurse");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
