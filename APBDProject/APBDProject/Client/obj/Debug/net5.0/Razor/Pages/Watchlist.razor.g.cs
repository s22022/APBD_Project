#pragma checksum "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44084b0685b3bda1b4a7c2e84f1fd69cedb9ccda"
// <auto-generated/>
#pragma warning disable 1591
namespace APBDProject.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\_Imports.razor"
using APBDProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\_Imports.razor"
using APBDProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
using APBDProject.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Watchlist")]
    public partial class Watchlist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-582nlkx2yw>Watchlist</h3>");
#nullable restore
#line 12 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
 if(stocks == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p b-582nlkx2yw>...</p>");
#nullable restore
#line 15 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "style", "width: 100%; text-align : center");
            __builder.AddAttribute(4, "b-582nlkx2yw");
            __builder.AddMarkupContent(5, @"<thead b-582nlkx2yw><tr b-582nlkx2yw><th b-582nlkx2yw>Ticker</th> 
                <th b-582nlkx2yw>Locale</th>
                <th b-582nlkx2yw>Name</th>
                <th b-582nlkx2yw>Homepage</th>
                <th b-582nlkx2yw>Remove</th></tr></thead>
        ");
            __builder.OpenElement(6, "tbody");
            __builder.AddAttribute(7, "b-582nlkx2yw");
#nullable restore
#line 29 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
             foreach (var stock in stocks)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.AddAttribute(9, "b-582nlkx2yw");
            __builder.OpenElement(10, "td");
            __builder.AddAttribute(11, "style", "border-top: 1px solid ");
            __builder.AddAttribute(12, "b-582nlkx2yw");
#nullable restore
#line 33 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
__builder.AddContent(13, stock.ticker);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, " \r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddAttribute(16, "style", "border-top: 1px solid ");
            __builder.AddAttribute(17, "b-582nlkx2yw");
#nullable restore
#line 34 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
__builder.AddContent(18, stock.locale);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "style", "border-top: 1px solid ");
            __builder.AddAttribute(22, "b-582nlkx2yw");
#nullable restore
#line 35 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
__builder.AddContent(23, stock.name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddAttribute(26, "style", "border-top: 1px solid ");
            __builder.AddAttribute(27, "b-582nlkx2yw");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", 
#nullable restore
#line 36 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                                                     stock.homepage_url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "target", "_blank");
            __builder.AddAttribute(31, "b-582nlkx2yw");
#nullable restore
#line 36 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
__builder.AddContent(32, stock.homepage_url);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                  ");
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "style", "border-top: 1px solid ");
            __builder.AddAttribute(36, "b-582nlkx2yw");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "btn btn-danger");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                                                                                                    ()=> RemoveRecord(stock)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "b-582nlkx2yw");
            __builder.AddContent(42, "-");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Davido\Desktop\APBD\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
       
    private StockInfo[] stocks;
    private string userID;

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        userID = authState.User.Identity.Name;
        stocks = await Http.GetFromJsonAsync<StockInfo[]>($"api/watchlist/{userID}");

    }

    private async Task RemoveRecord(StockInfo stock)
    {

        // var delete = await Http.PostAsJsonAsync($"api/watchlist/delete/{userID}", stock);

        stocks = null;

        

       //  stocks = await Http.GetFromJsonAsync<StockInfo[]>($"api/watchlist/{userID}");

    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591