#pragma checksum "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43b30058ae97d0184f49e16b30f124323c2400e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43b30058ae97d0184f49e16b30f124323c2400e2", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7e9d49f005a6455e5844fefd597fc93f1ab614", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Department>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Department.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    //var students = ViewData["Students"] as List<Student>;
    var department = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43b30058ae97d0184f49e16b30f124323c2400e24334", async() => {
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
    <h4>新增部门信息（输入新的部门名称，点击“新增”):</h4>
    <table>
        <thead>
            <tr>
                <th>部门名称</th>
                <th>&nbsp</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td><input id=""newName"" type=""text"" style=""height:25px;width:100px"" /></td>
                <th></th>
                <td><button type=""button"" onclick=""Add()"">新增</button></td>
            </tr>
        </tbody>
    </table>
</div>

<br />

<div class="" box-name ui-draggable-handle"">
    <span>出差信息修改：修改相应记录后，点击“修改”按钮</span>
    <br />
    <span>出差信息删除：对要删除的学生记录，点击“删除”按钮</span>
    <br /> <br />
</div>

<div class=""box-content no-padding"">
    <table class=""table table-striped table-bordered table-hover table-heading no-border-bottom"">
        <thead>
            <tr>
                <th>序号</th>
                <th>部门编号</th>
                <th>部门名称<");
            WriteLiteral("/th>\r\n                <th>操作</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Department\Index.cshtml"
             for (int i = 0, j = 1; i < department.Count; i++, j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Department\Index.cshtml"
               Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Department\Index.cshtml"
               Write(department[i].DId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><input");
            BeginWriteAttribute("id", " id=\"", 1546, "\"", 1575, 2);
            WriteAttributeValue("", 1551, "DName_", 1551, 6, true);
#nullable restore
#line 55 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Department\Index.cshtml"
WriteAttributeValue("", 1557, department[i].DId, 1557, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1588, "\"", 1616, 1);
#nullable restore
#line 55 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Department\Index.cshtml"
WriteAttributeValue("", 1596, department[i].DName, 1596, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:25px;width:150px\" /></td>\r\n                <td>\r\n                    <button class=\"btn btn-primary\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1746, "\"", 1782, 3);
            WriteAttributeValue("", 1756, "Update(", 1756, 7, true);
#nullable restore
#line 57 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Department\Index.cshtml"
WriteAttributeValue("", 1763, department[i].DId, 1763, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1781, ")", 1781, 1, true);
            EndWriteAttribute();
            WriteLiteral(">修改</button>\r\n                    <button class=\"btn btn-danger\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1861, "\"", 1898, 3);
            WriteAttributeValue("", 1871, "Delete(", 1871, 7, true);
#nullable restore
#line 58 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Department\Index.cshtml"
WriteAttributeValue("", 1878, department[i].DId, 1878, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1896, ");", 1896, 2, true);
            EndWriteAttribute();
            WriteLiteral(">删除</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 61 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\Department\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591