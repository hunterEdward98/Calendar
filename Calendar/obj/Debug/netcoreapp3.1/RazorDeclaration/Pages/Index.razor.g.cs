// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Calendar.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hescheel\Documents\Calendar\Calendar\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hescheel\Documents\Calendar\Calendar\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hescheel\Documents\Calendar\Calendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hescheel\Documents\Calendar\Calendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hescheel\Documents\Calendar\Calendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hescheel\Documents\Calendar\Calendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hescheel\Documents\Calendar\Calendar\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hescheel\Documents\Calendar\Calendar\_Imports.razor"
using Calendar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hescheel\Documents\Calendar\Calendar\_Imports.razor"
using Calendar.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hescheel\Documents\Calendar\Calendar\Pages\Index.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\hescheel\Documents\Calendar\Calendar\Pages\Index.razor"
      

    string calendarLink = "https://calendar.google.com/calendar/embed?src=s02nb16k89v0da55tu7il2s8fc%40group.calendar.google.com&ctz=America%2FChicago";
    private IJSRuntime JSRuntime { get; set; }
    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            var timer = new Timer(new TimerCallback(_ =>
            {
                NavigationManager.NavigateTo(NavigationManager.Uri, forceLoad: true);
            }), null, 200000, 200000);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
