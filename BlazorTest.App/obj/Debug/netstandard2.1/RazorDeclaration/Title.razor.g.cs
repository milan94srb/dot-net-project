#pragma checksum "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTest.App\Title.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7003b3d3c464c22f296610e4e142937ef07d1b44"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTestApp
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#line 1 "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTest.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTest.App\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#line 3 "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTest.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTest.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTest.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTest.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 7 "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTest.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTest.App\_Imports.razor"
using BlazorTestApp;

#line default
#line hidden
#line 9 "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTest.App\_Imports.razor"
using BlazorTestApp.Components;

#line default
#line hidden
#line 10 "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTest.App\_Imports.razor"
using BlazorTestApp.Shared;

#line default
#line hidden
#line 11 "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTest.App\_Imports.razor"
using BlazorTestApp.Extensions;

#line default
#line hidden
    public partial class Title : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 2 "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTest.App\Title.razor"
 
    [Inject] private NavigationManager NavigationManager { get; set; }
    string Titles() => NavigationManager.BaseUri.Split('?')[0].Split('/').Last();
    protected override void OnInitialized()
    {
        base.OnInitialized();
        NavigationManager.LocationChanged += (s, e) => StateHasChanged();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
