#pragma checksum "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ceebbb1bd1cc63ccccc2e7699562d5a0f66ac09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_TryView), @"mvc.1.0.view", @"/Views/Employee/TryView.cshtml")]
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
#nullable restore
#line 1 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\_ViewImports.cshtml"
using TryStateStatement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\_ViewImports.cshtml"
using TryStateStatement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ceebbb1bd1cc63ccccc2e7699562d5a0f66ac09", @"/Views/Employee/TryView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff763d5116d898eb0f0a3614b34c47aff08ad76f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_TryView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
  
    ViewData["Title"] = "TryView";
    var Emps = ViewBag.Emp as List<Employee>;
    var EmpsViewData = ViewData["Emp"] as List<Employee>;
    var EmpTempData = new List<Employee>();
    if (TempData.ContainsKey("Emp"))  
    {  
        EmpTempData = TempData["Emp"] as List<Employee>;  
    }  
     

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Try ViewBag</h1>

<table class=""table table-bordered table-striped table-hover table-dark"">
    <tr>
        <th>Id</th>
        <th>name</th>
        <th>age</th>
        <th>address</th>
        <th>Salary</th>
        <th>Department Name</th>
    </tr>
");
#nullable restore
#line 25 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
     foreach (var item in Emps)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            <td>");
#nullable restore
#line 30 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
           Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
           Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
           Write(item.Department.DeptName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</table>

<h1>Try ViewData</h1>

<table class=""table table-bordered table-striped table-hover table-dark"">
    <tr>
        <th>Id</th>
        <th>name</th>
        <th>age</th>
        <th>address</th>
        <th>Salary</th>
        <th>Department Name</th>
    </tr>
");
#nullable restore
#line 50 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
     foreach (var item in EmpsViewData)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 53 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            <td>");
#nullable restore
#line 55 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
           Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 56 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 57 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
            Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 58 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
           Write(item.Department.DeptName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 60 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</table>

<h1>Try TempData</h1>

<table class=""table table-bordered table-striped table-hover table-dark"">
    <tr>
        <th>Id</th>
        <th>name</th>
        <th>age</th>
        <th>address</th>
        <th>Salary</th>
        <th>Department Name</th>
    </tr>
");
#nullable restore
#line 75 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
     foreach (var item in EmpTempData)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 78 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            <td>");
#nullable restore
#line 80 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
           Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 81 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 82 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
            Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 83 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
           Write(item.Department.DeptName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 85 "E:\.NET ITI\MVC Core\Day 5\Lab 5\TryStateStatement\TryStateStatement\Views\Employee\TryView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
