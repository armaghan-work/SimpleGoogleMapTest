#pragma checksum "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\Pages\Index - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f40e78427a390ef8c7cf46a9b2c9c6bb681c308"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GoogleMap1.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\_Imports.razor"
using GoogleMap1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\_Imports.razor"
using GoogleMap1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\Pages\Index - Copy.razor"
using GoogleMapsComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\Pages\Index - Copy.razor"
using GoogleMapsComponents.Maps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\Pages\Index - Copy.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\Pages\Index - Copy.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\Pages\Index - Copy.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\Pages\Index - Copy.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\Pages\Index - Copy.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\armaghan\source\repos\GoogleMap1\GoogleMap1\Pages\Index - Copy.razor"
       

    private GoogleMap map1;
    private MapOptions mapOptions;

    private string myLatLong = string.Empty;
    private string myEvent = string.Empty;

    protected override void OnInitialized()
    {
        mapOptions = new MapOptions()
        {
            Zoom = 13,
            Center = new LatLngLiteral()
            {
                Lat = 52.515778,
                Lng = 14.112908
            },
            MapTypeId = MapTypeId.Roadmap
        };
    }

    private async Task OnAfterInitAsync()
    {
        await map1.InteropObject.AddListener<MouseEvent>("click", async (e) => await OnClick(e));
        await map1.InteropObject.AddListener<MouseEvent>("dblclick", async (e) => await OnDoubleClick(e));
    }

    private async Task OnClick(MouseEvent e)
    {
        // Change the localization to covert comma to dot
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
        myLatLong = e.LatLng.ToString();
        myEvent = "Clicked on:" + myLatLong;

        StateHasChanged();
    }

    private async Task OnDoubleClick(MouseEvent e)
    {
        myLatLong = e.LatLng.ToString();
        myEvent = "Double Clicked on:" + myLatLong;

        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
