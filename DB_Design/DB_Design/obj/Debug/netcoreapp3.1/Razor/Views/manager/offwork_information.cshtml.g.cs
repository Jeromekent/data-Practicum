#pragma checksum "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6629d4465e3d7c07f92be86900592fae13214e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_manager_offwork_information), @"mvc.1.0.view", @"/Views/manager/offwork_information.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6629d4465e3d7c07f92be86900592fae13214e2", @"/Views/manager/offwork_information.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7e9d49f005a6455e5844fefd597fc93f1ab614", @"/Views/_ViewImports.cshtml")]
    public class Views_manager_offwork_information : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 4 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
  
    var off = ViewData["off"] as List<Offwork>;
    var staff = ViewData["staff"] as List<Worker>;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6629d4465e3d7c07f92be86900592fae13214e23597", async() => {
                WriteLiteral(@"


    <script type=""text/javascript"">

        function detele(i) {
                var xmlhttp;
                if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
                    xmlhttp = new XMLHttpRequest();
                }
                else {// code for IE6, IE5
                    xmlhttp = new ActiveXObject(""Microsoft.XMLHTTP"");
                }

                xmlhttp.onreadystatechange = function () {
                    if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                        window.location.href = """);
#nullable restore
#line 24 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
                                           Write(Url.Action("offwork_information","manager"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                    }
                }

                xmlhttp.open(""Post"", ""/manager/detele_off"", true);
                xmlhttp.setRequestHeader(""Content-type"",""application/x-www-form-urlencoded"");
                xmlhttp.send(""num=""+i);
        }

        function ch(i) {
            var id = document.getElementById(""wid_"" + i).value;
            var start = document.getElementById(""starttime_"" + i).value;
            var end = document.getElementById(""endtime_"" + i).value;
                var xmlhttp;
                if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
                    xmlhttp = new XMLHttpRequest();
                }
                else {// code for IE6, IE5
                    xmlhttp = new ActiveXObject(""Microsoft.XMLHTTP"");
                }

                xmlhttp.onreadystatechange = function () {
                    if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                        window.location.href = """);
#nullable restore
#line 47 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
                                           Write(Url.Action("offwork_information","manager"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                    }
                }

                xmlhttp.open(""Post"", ""/manager/change_off"", true);
                xmlhttp.setRequestHeader(""Content-type"",""application/x-www-form-urlencoded"");
                xmlhttp.send(""&num=""+i+""&id=""+id+""&starttime=""+start+""&endtime=""+end);
        }

        function add() {
                var num = document.getElementById(""num"").value;
                var id = document.getElementById(""id_a"" ).value;
                var start = document.getElementById(""start_a"" ).value;
                var end = document.getElementById(""end_a"").value;

                var xmlhttp;
                if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
                    xmlhttp = new XMLHttpRequest();
                }
                else {// code for IE6, IE5
                    xmlhttp = new ActiveXObject(""Microsoft.XMLHTTP"");
                }

                xmlhttp.onreadystatechange = function () {
                    if");
                WriteLiteral(" (xmlhttp.readyState == 4 && xmlhttp.status == 200) {\r\n                        window.location.href = \"");
#nullable restore
#line 72 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
                                           Write(Url.Action("offwork_information","manager"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                    }
                }

                xmlhttp.open(""Post"", ""/manager/add_off"", true);
                xmlhttp.setRequestHeader(""Content-type"",""application/x-www-form-urlencoded"");
                xmlhttp.send(""&num=""+num+""&id=""+id+""&starttime=""+start+""&endtime=""+end);
        }

        function search() {
            var xmlhttp;
            var id = document.getElementById(""s_id"" ).value;
            var name = document.getElementById(""s_name"").value;
        
                if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
                    xmlhttp = new XMLHttpRequest();
                }
                else {// code for IE6, IE5
                    xmlhttp = new ActiveXObject(""Microsoft.XMLHTTP"");
                }

                xmlhttp.onreadystatechange = function () {
                    if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                        alert(""查询成功"");
                        document.getElemen");
                WriteLiteral(@"tById(""table"").innerHTML = xmlhttp.responseText;
                            document.getElementById(""mydiv"").style.display = """";
                            document.getElementById(""div"").style.display=""none""                    }
                }

                xmlhttp.open(""Post"", ""/manager/off_search"", true);
                xmlhttp.setRequestHeader(""Content-type"",""application/x-www-form-urlencoded"");
                xmlhttp.send(""&id=""+id+""&name=""+name);
        }


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
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"panel panel-default\">\r\n        <div class=\"panel-heading\">\r\n            <h2 class=\"text-center\">请假信息</h2>\r\n            <h3 class=\"text-danger\">共 ");
#nullable restore
#line 117 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
                                 Write(off.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 行信息</h3>
        </div>
        <div>
            <input id=""s_id"" type=""text"" placeholder=""精确查询（工号）"" class=""text-center form-control"" style=""width: 30%;"" />
            <input id=""s_name"" type=""text"" placeholder=""模糊查询（姓名）"" class=""text-center form-control"" style=""width: 30%;"" />
            <button class=""btn btn-success btn-icon-split"" type=""button"" onclick=""search()"">查询</button>
        </div>
        <div id=""mydiv"" style=""display:none"">
            <h3 class=""text-center"">查询结果</h3>
            <table class=""table table-striped table-bordered table-hover dataTable no-footer"">
                <thead>
                    <tr role=""row"">
                        <th tabindex=""0"" style=""width: 8%;"">
                            行号
                        </th>
                        <th tabindex=""0"" style=""width: 8%;"">
                            加班编号
                        </th>
                        <th tabindex=""0"" style=""width: 5%;"">
                            工号
                   ");
            WriteLiteral(@"     </th>
                        <th tabindex=""0"" style=""width: 10%;"">
                            姓名
                        </th>
                        <th tabindex=""0"" style=""width: 15%;"">
                            开始时间
                        </th>
                        <th tabindex=""0"" style=""width: 15%;"">
                            结束时间
                        </th>
                        <th tabindex=""0"" style=""width: 10%;"">
                            加班时长
                        </th>
                    </tr>
                </thead>
                <tbody id=""table"">
                </tbody>
            </table>

        </div>

        <div id=""div"" class=""panel-body"">
            <div class=""table-responsive"">
                <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"">

                    <thead>
                        <tr>
                            <th>
                                行号
   ");
            WriteLiteral(@"                         </th>
                            <th>
                                加班编号
                            </th>
                            <th>
                                工号
                            </th>
                            <th>
                                姓名
                            </th>
                            <th>
                                开始时间
                            </th>
                            <th>
                                结束时间
                            </th>
                            <th>
                                加班时长
                            </th>
                            <th>
                                操作
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr class=""even gradeC"">
                            <td> </td>
                            <td><input id=""num"" type=""text"" placehold");
            WriteLiteral(@"er=""输入编号"" class=""text-center form-control"" /></td>
                            <td><input id=""id_a"" type=""text"" placeholder=""输入工号"" class=""text-center form-control"" /></td>
                            <td>姓名将自动匹配</td>
                            <td><input id=""start_a"" type=""text"" placeholder=""输入开始时间"" class=""text-center form-control"" /></td>
                            <td><input id=""end_a"" type=""text"" placeholder=""输入结束时间"" class=""text-center form-control"" /></td>
                            <td>加班时长自动计算</td>
                            <td>
                                <button class=""btn btn-success btn-icon-split"" type=""button"" onclick=""add()"">添加</button>
                            </td>
                        </tr>
");
#nullable restore
#line 203 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
                         for (int i = 0; i < off.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"odd gradeX\">\r\n                                <td>");
#nullable restore
#line 206 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
                                Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 207 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
                               Write(off[i].OffNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center \"><input");
            BeginWriteAttribute("id", " id=\"", 8961, "\"", 8972, 2);
            WriteAttributeValue("", 8966, "wid_", 8966, 4, true);
#nullable restore
#line 208 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
WriteAttributeValue("", 8970, i, 8970, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 8985, "\"", 9004, 1);
#nullable restore
#line 208 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
WriteAttributeValue("", 8993, off[i].WId, 8993, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-center form-control\" /></td>\r\n                                <td class=\"center \">");
#nullable restore
#line 209 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
                                               Write(staff[(int)off[i].WId - 1].WName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center \"><input");
            BeginWriteAttribute("id", " id=\"", 9198, "\"", 9215, 2);
            WriteAttributeValue("", 9203, "starttime_", 9203, 10, true);
#nullable restore
#line 210 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
WriteAttributeValue("", 9213, i, 9213, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 9228, "\"", 9256, 1);
#nullable restore
#line 210 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
WriteAttributeValue("", 9236, off[i].OffStartTime, 9236, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-center form-control\" /></td>\r\n                                <td class=\"center \"><input");
            BeginWriteAttribute("id", " id=\"", 9358, "\"", 9373, 2);
            WriteAttributeValue("", 9363, "endtime_", 9363, 8, true);
#nullable restore
#line 211 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
WriteAttributeValue("", 9371, i, 9371, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 9386, "\"", 9412, 1);
#nullable restore
#line 211 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
WriteAttributeValue("", 9394, off[i].OffEndTime, 9394, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-center form-control\" /></td>\r\n                                <td class=\"center \">");
#nullable restore
#line 212 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
                                               Write(off[i].OffDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</td>\r\n                                <td class=\"center \">\r\n                                    <button class=\" btn btn-success btn-icon-split\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 9686, "\"", 9702, 3);
            WriteAttributeValue("", 9696, "ch(", 9696, 3, true);
#nullable restore
#line 214 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
WriteAttributeValue("", 9699, i, 9699, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9701, ")", 9701, 1, true);
            EndWriteAttribute();
            WriteLiteral(">修改</button>\r\n                                    <button class=\"btn btn-success btn-icon-split\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 9813, "\"", 9833, 3);
            WriteAttributeValue("", 9823, "detele(", 9823, 7, true);
#nullable restore
#line 215 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
WriteAttributeValue("", 9830, i, 9830, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9832, ")", 9832, 1, true);
            EndWriteAttribute();
            WriteLiteral(">删除</button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 218 "C:\Users\lenovo\Documents\XiaoMiNet\Upupoo\Docker\config\QAQ\员工考勤系统\DB_Design (第1版)\DB_Design\DB_Design\Views\manager\offwork_information.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
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
