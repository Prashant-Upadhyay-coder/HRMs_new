#pragma checksum "C:\DOTNET\PROJECT\Attendance(dashboard)\Demo\Views\Default\sidemenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8adb328259385efda99ba5826c3e583988956435"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_sidemenu), @"mvc.1.0.view", @"/Views/Default/sidemenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Default/sidemenu.cshtml", typeof(AspNetCore.Views_Default_sidemenu))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\DOTNET\PROJECT\Attendance(dashboard)\Demo\Views\_ViewImports.cshtml"
using Demo;

#line default
#line hidden
#line 2 "C:\DOTNET\PROJECT\Attendance(dashboard)\Demo\Views\_ViewImports.cshtml"
using Demo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8adb328259385efda99ba5826c3e583988956435", @"/Views/Default/sidemenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18407c5b9dabc62761fc6cdd8f67817f22bc556", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_sidemenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 239, true);
            WriteLiteral("\r\n<div id=\"sideMenu\">\r\n    <button id=\"toggleButton\"></button>\r\n    <ul id=\"menuItems\">\r\n        <!-- Menu items will be dynamically added here -->\r\n    </ul>\r\n</div>\r\n<script>\r\n     const menuData = [\r\n        {label: \"ATTENDANCE\", url: \"");
            EndContext();
            BeginContext(240, 29, false);
#line 10 "C:\DOTNET\PROJECT\Attendance(dashboard)\Demo\Views\Default\sidemenu.cshtml"
                               Write(Url.Action("Index","Default"));

#line default
#line hidden
            EndContext();
            BeginContext(269, 876, true);
            WriteLiteral(@""", submenus: [/*{label: ""Submenu 1"", url: ""#"" }, {label: ""Submenu 2"", url: ""/submenu2"" }*/] },
      
    ];
</script>

<script>
    var dynamicIcons = [
        { label: 'Attendance', iconClass: 'fa fa-calendar' },
        //{ label: 'CreateException', iconClass: 'fa-solid fa-magnifying-glass' },
        //{ label: 'DashBoard', iconClass: 'fa fa-bar-chart' }
        //{ label: 'sidemenu 1', iconClass: 'fa fa-calendar' },
        //{ label: 'Menu 1', iconClass: 'fa-solid fa-table-cells-large' },
        //{ label: 'Menu 2', iconClass: 'fa-solid fa-table-cells-large' },
        //{ label: 'submenu 1', iconClass: 'fa-solid fa-credit-card' },
        //{ label: 'submenu 2', iconClass: 'fa-solid fa-credit-card' },
        //{ label: 'Panel', iconClass: 'fa-solid fa-server' },
        //{ label: 'Panel3', iconClass: 'fa fa-calendar' }
    ];
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
