#pragma checksum "C:\Users\Siphiwe Christabel\Documents\2019\Second Semester\ITRW324\project3\Project_3_29834643\Project_3_29834643\Views\Returns\ReturnsChart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6867dc96f7ab22cd424e5aa1a0d80cc8c0c5c25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Returns_ReturnsChart), @"mvc.1.0.view", @"/Views/Returns/ReturnsChart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Returns/ReturnsChart.cshtml", typeof(AspNetCore.Views_Returns_ReturnsChart))]
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
#line 1 "C:\Users\Siphiwe Christabel\Documents\2019\Second Semester\ITRW324\project3\Project_3_29834643\Project_3_29834643\Views\_ViewImports.cshtml"
using Project_3_29834643;

#line default
#line hidden
#line 2 "C:\Users\Siphiwe Christabel\Documents\2019\Second Semester\ITRW324\project3\Project_3_29834643\Project_3_29834643\Views\_ViewImports.cshtml"
using Project_3_29834643.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6867dc96f7ab22cd424e5aa1a0d80cc8c0c5c25", @"/Views/Returns/ReturnsChart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9552cfcbc34b45138afa6b02c7ecc8476e0e6264", @"/Views/_ViewImports.cshtml")]
    public class Views_Returns_ReturnsChart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Siphiwe Christabel\Documents\2019\Second Semester\ITRW324\project3\Project_3_29834643\Project_3_29834643\Views\Returns\ReturnsChart.cshtml"
  
    ViewData["Title"] = "ReturnsChart";

#line default
#line hidden
            BeginContext(50, 65, true);
            WriteLiteral("\r\n<h1>superstore returns analysis</h1>\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(115, 1709, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6867dc96f7ab22cd424e5aa1a0d80cc8c0c5c253989", async() => {
                BeginContext(121, 639, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Pie Charts</title>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.2.2/Chart.bundle.min.js""></script>
    <script>

            function dynamicColors() {
    var r = Math.floor(Math.random() * 255);
    var g = Math.floor(Math.random() * 255);
    var b = Math.floor(Math.random() * 255);
    return ""rgba("" + r + "","" + g + "","" + b + "", 0.5)"";
        }
        function poolColors(a) {
    var pool = [];
    for(i = 0; i < a; i++) {
        pool.push(dynamicColors());
    }
    return pool;
}





        var jsreturns = ");
                EndContext();
                BeginContext(761, 34, false);
#line 33 "C:\Users\Siphiwe Christabel\Documents\2019\Second Semester\ITRW324\project3\Project_3_29834643\Project_3_29834643\Views\Returns\ReturnsChart.cshtml"
                   Write(Html.Raw( ViewBag.TheReturnTotals));

#line default
#line hidden
                EndContext();
                BeginContext(795, 61, true);
                WriteLiteral(";\r\n        var PieChartData =\r\n        {\r\n            labels:");
                EndContext();
                BeginContext(857, 33, false);
#line 36 "C:\Users\Siphiwe Christabel\Documents\2019\Second Semester\ITRW324\project3\Project_3_29834643\Project_3_29834643\Views\Returns\ReturnsChart.cshtml"
              Write(Html.Raw(ViewBag.TheReturnlabels));

#line default
#line hidden
                EndContext();
                BeginContext(890, 927, true);
                WriteLiteral(@",
            datasets: [{
                label: 'returns per region',
                backgroundColor: poolColors(jsreturns.length),
                borderWidth: 2,
                data: jsreturns
            }]
        };

        window.onload = function () {
            var ctx1 = document.getElementById(""barcanvas"").getContext(""2d"");
            window.myBar = new Chart(ctx1,
                {
                    type: 'bar',
                    data: PieChartData,
                    options:
                    {
                        title:
                        {
                            display: true,
                            text: ""Superstore total number of returns in every region""
                        },
                        responsive: true,
                        maintainAspectRatio: true
                    }
                });
        }
    </script>
");
                EndContext();
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
            EndContext();
            BeginContext(1824, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1826, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6867dc96f7ab22cd424e5aa1a0d80cc8c0c5c257708", async() => {
                BeginContext(1832, 146, true);
                WriteLiteral("\r\n    <div style=\"text-align: center\">\r\n        <canvas id=\"barcanvas\"></canvas>\r\n    </div>\r\n    <div style=\"text-align: center\">\r\n\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1985, 13, true);
            WriteLiteral("\r\n\r\n</html>  ");
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