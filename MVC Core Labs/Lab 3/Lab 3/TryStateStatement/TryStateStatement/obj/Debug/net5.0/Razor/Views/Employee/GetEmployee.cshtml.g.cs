#pragma checksum "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Employee\GetEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d127231ca3b56ef3baba1aa8951f70597e17e45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetEmployee), @"mvc.1.0.view", @"/Views/Employee/GetEmployee.cshtml")]
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
#line 1 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\_ViewImports.cshtml"
using TryStateStatement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\_ViewImports.cshtml"
using TryStateStatement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d127231ca3b56ef3baba1aa8951f70597e17e45", @"/Views/Employee/GetEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff763d5116d898eb0f0a3614b34c47aff08ad76f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_GetEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Employee\GetEmployee.cshtml"
  
    ViewData["Title"] = "GetEmployee";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Get Employee</h1>

<table class=""table table-bordered table-hover table-striped"">
    <tr>
        <th>ID</th>
        <th>Name</th>
        <th>Address</th>
        <th>Age</th>
        <th>Salary</th>
        <th>Department Name</th>
    </tr>
       <tr>
           <td>");
#nullable restore
#line 18 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Employee\GetEmployee.cshtml"
          Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 19 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Employee\GetEmployee.cshtml"
          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 20 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Employee\GetEmployee.cshtml"
          Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 21 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Employee\GetEmployee.cshtml"
          Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 22 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Employee\GetEmployee.cshtml"
          Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 23 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Employee\GetEmployee.cshtml"
          Write(Model.Department.DeptName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
