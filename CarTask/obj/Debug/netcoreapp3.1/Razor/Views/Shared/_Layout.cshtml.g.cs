#pragma checksum "C:\Users\tu7bxfga8\source\repos\CarTask\CarTask\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c04f7313bb60c9474469b758a6a7950a4a04c8ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c04f7313bb60c9474469b758a6a7950a4a04c8ad", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb5b80186eeb23ea95b8ff0840ff3c46b212309", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c04f7313bb60c9474469b758a6a7950a4a04c8ad2895", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c04f7313bb60c9474469b758a6a7950a4a04c8ad4408", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-dark bg-primary"" aria-label=""Eighth navbar example"">
        <div class=""container"">
            <i class=""bi bi-stopwatch"" style=""color: white;""></i>
            <a class=""navbar-brand"" href=""#"">Mon - Sun: 8:00am - 6:00pm</a>
            <i class=""bi bi-telephone-fill"" style=""color: white;""></i>
            <a class=""navbar-brand"" href=""#"">(123) 456-7890</a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarsExample07"" aria-controls=""navbarsExample07"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarsExample07"">
                <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""#""></a>
                    </li>
                    <li cla");
                WriteLiteral(@"ss=""nav-item"">
                        <a class=""nav-link"" href=""#""></a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link disabled""></a>
                    </li>
                    <li class=""nav-item dropdown"">
                    </li>
                </ul>
                <form role=""icons"">
                    <h3 style=""color: white;"">| <i class=""bi bi-facebook"" style=""color: white;""></i>|<i class=""bi bi-twitter"" style=""color: white;""></i>| <i class=""bi bi-instagram"" style=""color: white;""></i>| <i class=""bi bi-file-ppt-fill"" style=""color: white;""></i></h3>
                </form>
            </div>
        </div>
    </nav>
    <nav class=""navbar navbar-expand-lg navbar-dark bg-white"" aria-label=""Eighth navbar example"">
        <div class=""container"">
            <img src=""http://malikhassan.com/html/car-rental/html/images/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 2538, "\"", 2544, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <div class=""collapse navbar-collapse"" id=""navbarsExample07"">
                <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""#"" style=""color: black;""></a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#""></a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link disabled""></a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""dropdown07"" data-bs-toggle=""dropdown"" aria-expanded=""false""></a>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdown07"">
                            <li><a class=""dropdown-item"" href=""#""></a></li>
                            <li><a class=""dropdown-item"" href=""#""> </a></li>
                      ");
                WriteLiteral(@"      <li><a class=""dropdown-item"" href=""#"">  </a></li>
                        </ul>
                    </li>
                </ul>
                <form role=""serch"">
                    <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                        <li class=""nav-item"" style=""color: black;"">
                            <a class=""nav-link active"" aria-current=""page"" href=""#"" style=""color: black;"">Home</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"" style=""color: black;"">Services</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link disabled"" style=""color: black;"">Vehicles</a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link "" href=""#"" style=""color: black;"">Supports</a>
                        </li>
                        <li class=""nav-item ");
                WriteLiteral(@"dropdown"">
                            <a class=""nav-link "" href=""#"" style=""color: black;"">Clients</a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link "" href=""#"" style=""color: black;"">Blog</a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link "" href=""#"" style=""color: black;"">Contact Us</a>
                        </li>
                    </ul>
                </form>
            </div>
        </div>
    </nav>
    ");
#nullable restore
#line 92 "C:\Users\tu7bxfga8\source\repos\CarTask\CarTask\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <footer class=""py-5"">
        <div class=""row"">
            <div class=""col-6 col-md-2 mb-3"">
                <h5><i class=""bi bi-geo-alt"" style=""border-color: blue;color: blue""></i> Address</h5>
                <p> 123 Lorem Ispum 456 Sit. Atlanta Ga. 30377</p>
            </div>

            <div class=""col-6 col-md-2 mb-3"">
                <h5><i class=""bi bi-geo-alt"" style=""border-color: blue;color: blue;""></i> Address</h5>
                <p> 123 Lorem Ispum 456 Sit. Atlanta Ga. 30377</p>
            </div>

            <div class=""col-6 col-md-2 mb-3"">
                <h5><i class=""bi bi-geo-alt"" style=""border-color: blue;color: blue;""></i> Address</h5>
                <p> 123 Lorem Ispum 456 Sit. Atlanta Ga. 30377</p>
            </div>
        </div>
        <div style=""text-align: center;"">
            <a class=""link-dark"" href=""#""><i class=""bi bi-facebook"" style=""color: blue;""></i></a>
            <a class=""link-dark"" href=""#""><i class=""bi bi-twitter"" style=""color: blue;""></");
                WriteLiteral(@"i></a>
            <a class=""link-dark"" href=""#""><i class=""bi bi-youtube"" style=""color: red;""></i></a>
            <a class=""link-dark"" href=""#""><i class=""bi bi-incognito"" style=""color: blue;""></i></a>
            <a class=""link-dark"" href=""#""><i class=""bi bi-google"" style=""color: red;""></i></a>
        </div>
        <p style=""text-align: center;"">© 2022 Company, Inc. All rights reserved.</p>
    </footer>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
