#pragma checksum "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9f61ab9f13845409de5dd0fd9600f1cab8f7f66"
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
#line 1 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using APBDProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using APBDProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
using APBDProject.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
using APBDProject.Shared.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/details/{id}")]
    public partial class StockDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 14 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
 if(stock==null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<a>...</a>");
#nullable restore
#line 17 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
}else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h1");
#nullable restore
#line 18 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(2, stock.name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, "Ticker: ");
#nullable restore
#line 20 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(5, stock.ticker);

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, " ");
#nullable restore
#line 20 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(7, stock.locale);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
#nullable restore
#line 21 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(10, stock.description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "p");
            __builder.AddContent(13, "Market:  ");
#nullable restore
#line 22 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(14, stock.market);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "p");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", 
#nullable restore
#line 23 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
              stock.homepage_url

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 23 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(19, stock.homepage_url);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
 if(prices==null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "<p>...</p>");
#nullable restore
#line 32 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
}
else
{

   

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, " Open : ");
#nullable restore
#line 37 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(23, prices.o);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, " High: ");
#nullable restore
#line 38 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(27, prices.h);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "p");
            __builder.AddContent(30, " Low: ");
#nullable restore
#line 39 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(31, prices.l);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "p");
            __builder.AddContent(34, " Close: ");
#nullable restore
#line 40 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(35, prices.c);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "p");
            __builder.AddContent(38, " Volume: ");
#nullable restore
#line 41 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(39, prices.v);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
    
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
 if (Prices != null)
{
  

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfStockChart>(40);
            __builder.AddAttribute(41, "Title", "AAPL Historical");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.StockChartSeriesCollection>(43);
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.StockChartSeries>(45);
                    __builder3.AddAttribute(46, "DataSource", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 49 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
                                       StockDetails2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "Type", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 49 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
                                                            ChartSeriesType.Candle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "XName", "Date");
                    __builder3.AddAttribute(49, "High", "High");
                    __builder3.AddAttribute(50, "Low", "Low");
                    __builder3.AddAttribute(51, "Open", "Open");
                    __builder3.AddAttribute(52, "Close", "Close");
                    __builder3.AddAttribute(53, "Volume", "Volume");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 52 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
      
    [Parameter]
    public string id { get; set; }

    public StockInfo stock { get; set; }
    public OHLC prices { get; set; }

    public List<StockPriceDate> Prices = new List<StockPriceDate>();



    protected override async Task OnInitializedAsync()
    {
        StockPriceDate[] tabPrices = await Http.GetFromJsonAsync<StockPriceDate[]>($"api/stocks/prices/{id}");
        Prices.AddRange(tabPrices);
        stock = await Http.GetFromJsonAsync<StockInfo>($"api/stocks/details/{id}");


        prices = await Http.GetFromJsonAsync<OHLC>($"api/stocks/previousclose/{id}");



        var postOHCL = new StockPriceDate
            {
                DateTime = DateTime.Now,
                o = prices.o,
                c = prices.c,
                h = prices.h,
                l = prices.l,
                v = prices.v
            };

        var postStock = new StockInfoOHLC
            {
                Prices = postOHCL,
                Stock = stock
            };


        var postStockInfo = await Http.PostAsJsonAsync<StockInfoOHLC>($"api/stocks", postStock);
    }
    public class ChartData
    {
        public DateTime Date;
        public Double Open;
        public Double Low;
        public Double Close;
        public Double High;
        public Double Volume;
    }
 
    public List<ChartData> StockDetails2 = new List<ChartData>
    {
        new ChartData { Date = new DateTime(2012, 04, 02), Open= 85.9757, High = 90.6657,Low = 85.7685, Close = 90.5257,Volume = 660187068},
        new ChartData { Date = new DateTime(2012, 04, 09), Open= 89.4471, High = 92,Low = 86.2157, Close = 86.4614,Volume = 912634864},
        new ChartData { Date = new DateTime(2012, 04, 16), Open= 87.1514, High = 88.6071,Low = 81.4885, Close = 81.8543,Volume = 1221746066},
        new ChartData { Date = new DateTime(2012, 04, 23), Open= 81.5157, High = 88.2857,Low = 79.2857, Close = 86.1428,Volume = 965935749},
        new ChartData { Date = new DateTime(2012, 04, 30), Open= 85.4, High = 85.4857,Low = 80.7385, Close = 80.75,Volume = 615249365},
        new ChartData { Date = new DateTime(2012, 05, 07), Open= 80.2143, High = 82.2685,Low = 79.8185, Close = 80.9585,Volume = 541742692},
        new ChartData { Date = new DateTime(2012, 05, 14), Open= 80.3671, High = 81.0728,Low = 74.5971, Close = 75.7685,Volume = 708126233},
        new ChartData { Date = new DateTime(2012, 05, 21), Open= 76.3571, High = 82.3571,Low = 76.2928, Close = 80.3271,Volume = 682076215},
        new ChartData { Date = new DateTime(2012, 05, 28), Open= 81.5571, High = 83.0714,Low = 80.0743, Close = 80.1414,Volume = 480059584}
   };
    




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
