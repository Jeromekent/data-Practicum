#pragma checksum "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\overtime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdae87cafa6aeac093611538e619acc153ee973d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_statistics_overtime), @"mvc.1.0.view", @"/Views/statistics/overtime.cshtml")]
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
#line 1 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\_ViewImports.cshtml"
using DB_Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\_ViewImports.cshtml"
using DB_Design.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdae87cafa6aeac093611538e619acc153ee973d", @"/Views/statistics/overtime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7e9d49f005a6455e5844fefd597fc93f1ab614", @"/Views/_ViewImports.cshtml")]
    public class Views_statistics_overtime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\overtime.cshtml"
  
    var over = ViewData["over"] as List<OvertimeStatistic>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n\r\n\r\n</script>\r\n\r\n\r\n<div>\r\n    <div class=\"panel-title\">\r\n        <h1 class=\"text-center\">加班统计</h1>\r\n        <span>统计：");
#nullable restore
#line 17 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\overtime.cshtml"
            Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
    </div>
    <div class=""panel-body"">
        <div class=""table-responsive"">
            <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                    <thead>
                        <tr role=""row"">
                            <th class=""sorting_asc text-center"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Rendering engine: activate to sort column ascending"" style=""width: 211px;"">
                                工号
                            </th>
                            <th class=""sorting  text-center"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Browser: activate to sort column ascending"" style=""width: 288px;"">
                                姓名
                           ");
            WriteLiteral(@" </th>
                            <th class=""sorting text-center"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Platform(s): activate to sort column ascending"" style=""width: 267px;"">
                                年
                            </th>
                            <th class=""sorting text-center"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Engine version: activate to sort column ascending"" style=""width: 183px;"">
                                月
                            </th>
                            <th class=""sorting text-center"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""CSS grade: activate to sort column ascending"" style=""width: 136px;"">
                                加班总计
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 43 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\overtime.cshtml"
                         for (int i = 0; i < over.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"gradeA even\">\r\n                                <td class=\"sorting_1\">");
#nullable restore
#line 46 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\overtime.cshtml"
                                                 Write(over[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center \">");
#nullable restore
#line 47 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\overtime.cshtml"
                                               Write(over[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center \">");
#nullable restore
#line 48 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\overtime.cshtml"
                                               Write(over[i].Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center \">");
#nullable restore
#line 49 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\overtime.cshtml"
                                               Write(over[i].Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center \">");
#nullable restore
#line 50 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\overtime.cshtml"
                                               Write(over[i].TotalOverDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\overtime.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
