#pragma checksum "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2525771d707d33d58755ae22c8ed1109fc649239"
// <auto-generated/>
#pragma warning disable 1591
namespace HospitalSystem.Client.Pages.Patient
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
#line 2 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
using HospitalSystem.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/patient/{Id}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Delete Person</h2>\r\n");
#nullable restore
#line 7 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
 if (patient != null)
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
#line 9 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                                                                  patient.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " + ");
            __builder.AddContent(7, 
#nullable restore
#line 9 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                                                                                       patient.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.AddMarkupContent(17, "<td>First Name</td>\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 14 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                     patient.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddMarkupContent(24, "<td>Last Name</td>\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 18 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                     patient.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.AddMarkupContent(31, "<td>Birth Date</td>\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 22 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                     patient.BirthDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.AddMarkupContent(38, "<td>Weight</td>\r\n                ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 26 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                     patient.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "tr");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.AddMarkupContent(45, "<td>Blood Group</td>\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 30 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                     patient.BloodGroup

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "tr");
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.AddMarkupContent(52, "<td>Weight</td>\r\n                ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 34 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                     patient.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "tr");
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.AddMarkupContent(59, "<td>Mobile</td>\r\n                ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 38 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                     patient.Mobile

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "tr");
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.AddMarkupContent(66, "<td>Guardian Name</td>\r\n                ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 42 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                     patient.GuardianName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "tr");
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.AddMarkupContent(73, "<td>Guardian Contact</td>\r\n                ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 46 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                     patient.GuardianContact

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenElement(78, "tr");
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.AddMarkupContent(80, "<td>Last Checkup Date</td>\r\n                ");
            __builder.OpenElement(81, "td");
            __builder.AddContent(82, 
#nullable restore
#line 50 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                     patient.LastCheckUpDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 54 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "row");
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col-md-4");
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "form-group");
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.OpenElement(96, "input");
            __builder.AddAttribute(97, "type", "button");
            __builder.AddAttribute(98, "class", "btn btn-primary");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                                                                    Deleted

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(100, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.OpenElement(102, "input");
            __builder.AddAttribute(103, "type", "button");
            __builder.AddAttribute(104, "class", "btn");
            __builder.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Patient\Delete.razor"
       
    [Parameter]
    public int Id { get; set; }
    Patient patient = new Patient();
    protected override async Task OnInitializedAsync()
    {
        patient = await Http.GetFromJsonAsync<Patient>("api/patient/" + Id);
    }
    protected async Task Deleted()
    {
        var response = await Http.DeleteAsync("api/Patient/" + Id);
        bool deleteResponse = await response.Content.ReadFromJsonAsync<bool>();
        if (deleteResponse)
        {
            await JsRuntime.InvokeVoidAsync("alert", "Deleted Successfully!");
            NavigationManager.NavigateTo("/patient");
        }
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("/patient");
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
