#pragma checksum "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Home\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0492d2ec93952eb8721d301fdb2e3c785440410d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_View), @"mvc.1.0.view", @"/Views/Home/View.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0492d2ec93952eb8721d301fdb2e3c785440410d", @"/Views/Home/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff763d5116d898eb0f0a3614b34c47aff08ad76f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Home\View.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-content page-container"" id=""page-content"">
    <div class=""padding"">
        <div class=""row container d-flex justify-content-center"">
            <div class=""col-xl-6 col-md-12"">
                <div class=""card user-card-full"">
                    <div class=""row m-l-0 m-r-0 m-5"">
                        <div class=""col-sm-4 bg-c-lite-green user-profile"">
                            <div class=""card-block text-center text-white"">
                                <div class=""m-b-25"">
                                    <img src=""https://img.icons8.com/bubbles/100/000000/user.png"" class=""img-radius"" alt=""User-Profile-Image"">
                                </div>
                                <h6 class=""f-w-600"">");
#nullable restore
#line 16 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Home\View.cshtml"
                                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                <i class="" mdi mdi-square-edit-outline feather icon-edit m-t-10 f-16""></i>
                            </div>
                        </div>
                        <div class=""col-sm-8"">
                            <div class=""card-block"">
                                <h6 class=""m-b-20 p-b-5 b-b-default f-w-600 text-red"">Information</h6>
                                <div class=""row"">
                                    <div class=""col-sm-6"">
                                        <p class=""m-b-10 f-w-600 text-red"">Age</p>
                                        <h6 class=""text-muted f-w-400"">");
#nullable restore
#line 26 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Home\View.cshtml"
                                                                  Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                    </div>
                                    <div class=""col-sm-6"">
                                        <p class=""m-b-10 f-w-600 text-red"">Salary</p>
                                        <h6 class=""text-muted f-w-400"">");
#nullable restore
#line 30 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Home\View.cshtml"
                                                                  Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-sm-6"">
                                        <p class=""m-b-10 f-w-600 text-red"">Address</p>
                                        <h6 class=""text-muted f-w-400"">");
#nullable restore
#line 36 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Home\View.cshtml"
                                                                  Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                    </div>
                                    <div class=""col-sm-6"">
                                        <p class=""m-b-10 f-w-600 text-red"">Department Name</p>
                                        <h6 class=""text-muted f-w-400"">");
#nullable restore
#line 40 "E:\.NET ITI\MVC Core\Day 3\Lab 3\TryStateStatement\TryStateStatement\Views\Home\View.cshtml"
                                                                  Write(Model.Department.DeptName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-sm-6"">
                                        <a href=""/Home/Index""><i class=""fa-solid fa-house-chimney-user"" style=""font-size: 40px;padding: 10px;color: burlywood;""></i></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
