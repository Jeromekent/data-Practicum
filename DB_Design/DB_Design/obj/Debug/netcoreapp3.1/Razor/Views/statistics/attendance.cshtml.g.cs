#pragma checksum "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdefa76208e8c9b631d4465f6bc1f7f6268a4ca5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_statistics_attendance), @"mvc.1.0.view", @"/Views/statistics/attendance.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdefa76208e8c9b631d4465f6bc1f7f6268a4ca5", @"/Views/statistics/attendance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7e9d49f005a6455e5844fefd597fc93f1ab614", @"/Views/_ViewImports.cshtml")]
    public class Views_statistics_attendance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
  
    var att = ViewData["att"] as List<AttendanceStatistic>;
    var dep = ViewData["dep"] as List<Department>;

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdefa76208e8c9b631d4465f6bc1f7f6268a4ca53608", async() => {
                WriteLiteral(@"
        <script type=""text/javascript"">
        //function search(did) {
        //    var xmlhttp;
        
        //        if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
        //            xmlhttp = new XMLHttpRequest();
        //        }
        //        else {// code for IE6, IE5
        //            xmlhttp = new ActiveXObject(""Microsoft.XMLHTTP"");
        //        }

        //        xmlhttp.onreadystatechange = function () {
        //            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
        //                alert(""   "");
        //            }
        //        }

        //        xmlhttp.open(""Post"", ""/statistics/attendance"", true);
        //        xmlhttp.setRequestHeader(""Content-type"",""application/x-www-form-urlencoded"");
        //        xmlhttp.send(""&id=""+did);
        //}
        </script>
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
            WriteLiteral("\r\n\r\n<div>\r\n    <div class=\"panel-title\">\r\n        <h1 class=\"text-center\">出勤统计</h1>\r\n        <span>统计：");
#nullable restore
#line 36 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
            Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div >\r\n        <table class=\"table table-striped table-bordered table-hover dataTable no-footer\" id=\"dataTables-example\" aria-describedby=\"dataTables-example_info\">\r\n            <tbody >\r\n");
#nullable restore
#line 41 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                 for(int j = 0; j < dep.Count; j++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"gradeA even\">\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                   Write(dep[j].DId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                   Write(dep[j].DName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a type=\"button\"");
            BeginWriteAttribute("href", " href=\"", 1765, "\"", 1825, 3);
#nullable restore
#line 47 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
WriteAttributeValue("", 1772, Url.Action("attendance","statistics"), 1772, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1810, "?id=", 1810, 4, true);
#nullable restore
#line 47 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
WriteAttributeValue("", 1814, dep[j].DId, 1814, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">选择该部门</a>\r\n                    </td>\r\n");
#nullable restore
#line 49 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                     if (j + 1 < dep.Count)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 51 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                       Write(dep[++j].DId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                       Write(dep[j].DName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a type=\"button\"");
            BeginWriteAttribute("href", " href =\"", 2127, "\"", 2188, 3);
#nullable restore
#line 54 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
WriteAttributeValue("", 2135, Url.Action("attendance","statistics"), 2135, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2173, "?id=", 2173, 4, true);
#nullable restore
#line 54 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
WriteAttributeValue("", 2177, dep[j].DId, 2177, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">选择该部门</a>\r\n                        </td>\r\n");
#nullable restore
#line 56 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 59 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""panel-body"">
        <div class=""table-responsive"">
            <div id=""div"">
                <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                    <thead>
                        <tr role=""row"">
                            <th class=""sorting_asc text-center"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Rendering engine: activate to sort column ascending"" style=""width: 211px;"">
                                工号
                            </th>
                            <th class=""sorting text-center"" tabindex=""0"" aria-controls=""dataTables"" rowspan=""1"" colspan=""1"" aria-label=""Browser: activate to sort column ascending"" style=""width: 288px;"">
                                姓名
                            </th>
                            <th class=""sorti");
            WriteLiteral(@"ng text-center"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Platform(s): activate to sort column ascending"" style=""width: 267px;"">
                                年
                            </th>
                            <th class=""sorting text-center"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Engine version: activate to sort column ascending"" style=""width: 183px;"">
                                月
                            </th>
                            <th class=""sorting text-center"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""CSS grade: activate to sort column ascending"" style=""width: 136px;"">
                                迟到次数
                            </th>
                            <th class=""sorting text-center"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""CSS grade: activate to sort column ascending"" style=""width: 13");
            WriteLiteral(@"6px;"">
                                早退次数
                            </th>
                            <th class=""sorting text-center"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""CSS grade: activate to sort column ascending"" style=""width: 136px;"">
                                旷工次数
                            </th>
                            <th class=""sorting text-center"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""CSS grade: activate to sort column ascending"" style=""width: 136px;"">
                                正常次数
                            </th>
                        </tr>
                    </thead>
                    <tbody id=""mytable"">
");
#nullable restore
#line 96 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                         for (int i = 0; i < att.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"gradeA even\">\r\n                                <td class=\"sorting_1\">");
#nullable restore
#line 99 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                                                 Write(att[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center \">");
#nullable restore
#line 100 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                                               Write(att[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center \">");
#nullable restore
#line 101 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                                               Write(att[i].Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center \">");
#nullable restore
#line 102 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                                               Write(att[i].Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center \">");
#nullable restore
#line 103 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                                               Write(att[i].LateTimes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center \">");
#nullable restore
#line 104 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                                               Write(att[i].LeaveEarlyTimes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center \">");
#nullable restore
#line 105 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                                               Write(att[i].AbsenteeismTimes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center \">");
#nullable restore
#line 106 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                                               Write(att[i].NormalTimes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 108 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\statistics\attendance.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
