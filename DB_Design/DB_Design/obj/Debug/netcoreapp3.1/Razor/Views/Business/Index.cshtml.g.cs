#pragma checksum "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10c53a0ac6ce0c6aa12ade82a792ffb514eb906c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Business_Index), @"mvc.1.0.view", @"/Views/Business/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10c53a0ac6ce0c6aa12ade82a792ffb514eb906c", @"/Views/Business/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7e9d49f005a6455e5844fefd597fc93f1ab614", @"/Views/_ViewImports.cshtml")]
    public class Views_Business_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Business>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Business.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    //var students = ViewData["Students"] as List<Student>;
    var business = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10c53a0ac6ce0c6aa12ade82a792ffb514eb906c4316", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <div class="" box-name ui-draggable-handle box ui-draggable ui-droppable"">
        <h4>新增出差信息（将相应信息输入相应文本框中，点击“新增”):</h4>
        <table>
            <thead>
                <tr>
                    <th>员工编号</th>
                    <th>&nbsp</th>
                    <th>开始时间</th>
                    <th>&nbsp</th>
                    <th>结束时间</th>
                    <th>&nbsp</th>
                    <th>出差时长</th>
                    <th>&nbsp</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td><input id=""newWId"" type=""text"" style=""height:25px;width:100px"" /></td>
                    <th></th>
                    <td><input id=""newStartTime"" type=""text"" style=""height:25px;width:100px"" /></td>
                    <th></th>
                    <td><input id=""newEndTime"" type=""text"" style=""height:25px;width:100px"" /></td>
                    <th></th>
                    <td><input id=""newD");
            WriteLiteral(@"uration"" type=""text"" style=""height:25px;width:100px"" /></td>
                    <th></th>
                    <td><button type=""button"" onclick=""Add()"">新增</button></td>
                </tr>
            </tbody>
        </table>
        <span>（开始时间/结束时间格式：2020-03-08 00:00:00）</span>
    </div>

<br />

<div class="" box-name ui-draggable-handle"">
    <span>出差信息修改：修改相应记录后，点击“修改”按钮</span>
    <br />
    <span>出差信息删除：对要删除的学生记录，点击“删除”按钮</span>
    <br />
    <span>出差信息查询：</span>  <a");
            BeginWriteAttribute("href", " href=\'", 1748, "\'", 1791, 1);
#nullable restore
#line 50 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
WriteAttributeValue("", 1755, Url.Action("Query_Page","Business"), 1755, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">查询页面</a>
    <br /> <br />
</div>

<div class=""box-content no-padding"">
    <table class=""table table-striped table-bordered table-hover table-heading no-border-bottom"">
        <thead>
            <tr>
                <th>序号</th>
                <th>出差编号</th>
                <th>员工编号</th>
                <th>开始时间</th>
                <th>结束时间</th>
                <th>总时长</th>
                <th>操作</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 68 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
             for (int i = 0, j = 1; i < business.Count; i++, j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
                   Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 72 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
                   Write(business[i].BusNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 73 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
                   Write(business[i].WId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><input");
            BeginWriteAttribute("id", " id=\"", 2550, "\"", 2584, 2);
            WriteAttributeValue("", 2555, "StartTime_", 2555, 10, true);
#nullable restore
#line 74 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
WriteAttributeValue("", 2565, business[i].BusNum, 2565, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2597, "\"", 2630, 1);
#nullable restore
#line 74 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
WriteAttributeValue("", 2605, business[i].BusStartTime, 2605, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:25px;width:130px\" /></td>\r\n                    <td><input");
            BeginWriteAttribute("id", " id=\"", 2703, "\"", 2735, 2);
            WriteAttributeValue("", 2708, "EndTime_", 2708, 8, true);
#nullable restore
#line 75 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
WriteAttributeValue("", 2716, business[i].BusNum, 2716, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2748, "\"", 2779, 1);
#nullable restore
#line 75 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
WriteAttributeValue("", 2756, business[i].BusEndTime, 2756, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:25px;width:130px\" /></td>\r\n                    <td><input");
            BeginWriteAttribute("id", " id=\"", 2852, "\"", 2885, 2);
            WriteAttributeValue("", 2857, "Duration_", 2857, 9, true);
#nullable restore
#line 76 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
WriteAttributeValue("", 2866, business[i].BusNum, 2866, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2898, "\"", 2930, 1);
#nullable restore
#line 76 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
WriteAttributeValue("", 2906, business[i].BusDuration, 2906, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:25px;width:30px\" /></td>\r\n                    <td>\r\n                        <button class=\"btn btn-primary\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3067, "\"", 3104, 3);
            WriteAttributeValue("", 3077, "Update(", 3077, 7, true);
#nullable restore
#line 78 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
WriteAttributeValue("", 3084, business[i].BusNum, 3084, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3103, ")", 3103, 1, true);
            EndWriteAttribute();
            WriteLiteral(">修改</button>\r\n                        <button class=\"btn btn-danger\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3187, "\"", 3225, 3);
            WriteAttributeValue("", 3197, "Delete(", 3197, 7, true);
#nullable restore
#line 79 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
WriteAttributeValue("", 3204, business[i].BusNum, 3204, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3223, ");", 3223, 2, true);
            EndWriteAttribute();
            WriteLiteral(">删除</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Business\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Business>> Html { get; private set; }
    }
}
#pragma warning restore 1591
