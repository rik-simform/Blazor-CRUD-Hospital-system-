#pragma checksum "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Doctor\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b616879723af6aa4f0e0194af2ab7856b876a21f"
// <auto-generated/>
#pragma warning disable 1591
namespace HospitalSystem.Client.Pages.Doctor
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
#line 2 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Doctor\Edit.razor"
using HospitalSystem.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/doctor/Edit/{Id}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit Person</h2>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<label for=\"FirstName\"> Name *</label>\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "form", "FirstName");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Doctor\Edit.razor"
                                                                 doc.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => doc.Name = __value, doc.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-md-6");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.AddMarkupContent(25, "<label for=\"LastName\"> Specilisation *</label>\r\n            ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "form", "LastName");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Doctor\Edit.razor"
                                                                doc.Specialisation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => doc.Specialisation = __value, doc.Specialisation));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-md-6");
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.AddMarkupContent(40, "<label for=\"Email\"> Email *</label>\r\n            ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "form", "Email");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Doctor\Edit.razor"
                                                             doc.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => doc.Email = __value, doc.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-md-6");
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form-group");
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.AddMarkupContent(55, "<label for=\"MobileNo\"> Certificate/Degree*</label>\r\n            ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "form", "mobileNo");
            __builder.AddAttribute(58, "class", "form-control");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Doctor\Edit.razor"
                                                                doc.CertificateDegree

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => doc.CertificateDegree = __value, doc.CertificateDegree));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "row");
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-md-4");
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "form-group");
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "button");
            __builder.AddAttribute(76, "class", "btn btn-primary");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Doctor\Edit.razor"
                                                                    Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "button");
            __builder.AddAttribute(82, "class", "btn");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Doctor\Edit.razor"
                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\rikesh\source\repos\HospitalSystem\Client\Pages\Doctor\Edit.razor"
       
    [Parameter]
    public int Id { get; set; }
    Doctor doc = new Doctor();
    protected override async Task OnInitializedAsync()
    {
        doc = await Http.GetFromJsonAsync<Doctor>("api/doctor/" + Id);
    }
    protected async Task Save()
    {
        var response = await Http.PutAsJsonAsync("api/doctor/" + Id, @doc);
        bool docResponse = await response.Content.ReadFromJsonAsync<bool>();
        if (docResponse)
        {
            await JsRuntime.InvokeVoidAsync("alert", "Updated Successfully!");
            NavigationManager.NavigateTo("/doctor");
        }
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("/doctor");
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
