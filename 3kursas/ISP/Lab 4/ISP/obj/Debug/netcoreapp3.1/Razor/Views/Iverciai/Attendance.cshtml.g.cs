#pragma checksum "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61f9df66a1ca6dbe628005d82437f9feff4913b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Iverciai_Attendance), @"mvc.1.0.view", @"/Views/Iverciai/Attendance.cshtml")]
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
#line 1 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\_ViewImports.cshtml"
using ISP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\_ViewImports.cshtml"
using ISP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f9df66a1ca6dbe628005d82437f9feff4913b5", @"/Views/Iverciai/Attendance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12aad888534da250386b83b9fba5283636c4f66c", @"/Views/_ViewImports.cshtml")]
    public class Views_Iverciai_Attendance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Module>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Iverciai", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Marks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Attendance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GeneratePDF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            DefineSection("Sidebar", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61f9df66a1ca6dbe628005d82437f9feff4913b55069", async() => {
                    WriteLiteral("Įverčiai");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61f9df66a1ca6dbe628005d82437f9feff4913b56716", async() => {
                    WriteLiteral("Lankomumas");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61f9df66a1ca6dbe628005d82437f9feff4913b58452", async() => {
                    WriteLiteral("Generuoti ataskaita");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Modals", async() => {
                WriteLiteral(@"

    <div class=""modal fade"" id=""newEntryModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">

                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""textModalLabel"">Pervadinti</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>

                <div class=""modal-body"">
                    <div class=""input-group mb-3"">
                        <label for=""inputModalStatus"">Statusas:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <input id=""inputModalStatus"" type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1338, "\"", 1352, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-label=""Statusas"" aria-describedby=""basic-addon1"">
                    </div>

                    <div class=""input-group mb-3"">
                        <label for=""inputModalStudent"">Studentas:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <input id=""inputModalStudent"" type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1702, "\"", 1716, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-label", " aria-label=\"", 1717, "\"", 1730, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-describedby=""basic-addon1"">
                    </div>

                    <div class=""input-group mb-3"">
                        <label for=""inputModalLecture"">Paskaita:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <input id=""inputModalLecture"" type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2057, "\"", 2071, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-label", " aria-label=\"", 2072, "\"", 2085, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-describedby=""basic-addon1"">
                    </div>

                </div>
                <div class=""modal-footer"">
                    <button id=""inputModalConfirm"" type=""button"" class=""btn btn-success"" data-dismiss=""modal"">Redaguoti</button>
                    <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Atšaukti</button>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""viewEntryModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div");
                BeginWriteAttribute("class", " class=\"", 2674, "\"", 2743, 1);
#nullable restore
#line 52 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
WriteAttributeValue("", 2682, ViewBag.Teacher ? "modal-dialog" : "modal-dialog modal-lg", 2682, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" role=""document"">
            <div class=""modal-content"">

                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""textModalLabel"">Pervadinti</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>

                <div class=""modal-body"">
                    <div class=""input-group mb-3"">
                        <label for=""inputModalStatus"">Statusas:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <input disabled id=""inputModalStatus"" type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3461, "\"", 3475, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-label=""Statusas"" aria-describedby=""basic-addon1"">
                    </div>

                    <div class=""input-group mb-3"">
                        <label for=""inputModalStudent"">Studentas:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <input disabled id=""inputModalStudent"" type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3834, "\"", 3848, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-label", " aria-label=\"", 3849, "\"", 3862, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-describedby=""basic-addon1"">
                    </div>

                    <div class=""input-group mb-3"">
                        <label for=""inputModalLecture"">Modulis:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <input disabled id=""inputModalLecture"" type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4197, "\"", 4211, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-label", " aria-label=\"", 4212, "\"", 4225, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-describedby=""basic-addon1"">
                    </div>

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Uždaryti</button>
                </div>
            </div>
        </div>
    </div>

");
            }
            );
            WriteLiteral("\r\n    <table class=\"table\" style=\"width: 100%\">\r\n");
#nullable restore
#line 89 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
         if (ViewBag.Teacher)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <tr>
                <th>
                    <div class=""isp-item"" id=""CreateAttendence"" style=""margin-bottom: 15px;"">
                        <i class=""fas fa-plus"" style=""color: #3c5c4a;""></i>
                        <span class=""name"">Prideti lankomuma</span>
                    </div>
                </th>
            </tr>
");
#nullable restore
#line 99 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
            
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 104 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
               Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ID: <b>");
#nullable restore
#line 104 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                     Write(Model[i].ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></th>\r\n            </tr>\r\n");
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <div class=\"isp-item-list col\">\r\n\r\n");
#nullable restore
#line 111 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                         for (int u = 0; u < Model[i].Lectures.Count; u++)
                        {
                            var lecture = Model[i].Lectures[u];
                            string tooltipDirection = u == 0 ? "bottom" : "top";


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"isp-item\"");
            BeginWriteAttribute("name", " name=\"", 5568, "\"", 5591, 1);
#nullable restore
#line 116 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
WriteAttributeValue("", 5575, lecture.Subject, 5575, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <span hidden class=\"isp-item-id\">");
#nullable restore
#line 117 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                                            Write(lecture.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span hidden class=\"isp-item-subject\">");
#nullable restore
#line 118 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                                                 Write(lecture.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span hidden class=\"isp-item-date\">");
#nullable restore
#line 119 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                                              Write(lecture.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span hidden class=\"isp-item-moduleID\">");
#nullable restore
#line 120 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                                                  Write(lecture.ModuleID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                ");
#nullable restore
#line 121 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                           Write(lecture.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </div>\r\n");
            WriteLiteral("                            <ul class=\"list-group\"");
            BeginWriteAttribute("id", " id=\"", 6101, "\"", 6117, 1);
#nullable restore
#line 125 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
WriteAttributeValue("", 6106, lecture.Id, 6106, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 126 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                 foreach (var attendence in lecture.Attendences)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-group-item\">\r\n                                        <span hidden class=\"isp-item-status\">");
#nullable restore
#line 129 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                                                        Write(attendence.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span hidden class=\"isp-item-atndId\">");
#nullable restore
#line 130 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                                                        Write(attendence.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span hidden class=\"isp-item-student\">");
#nullable restore
#line 131 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                                                         Write(attendence.Student);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span hidden class=\"isp-item-lecture\">");
#nullable restore
#line 132 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                                                         Write(attendence.Lecture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                        <b>");
#nullable restore
#line 134 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                      Write(attendence.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 134 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                                              Write(attendence.StudentSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> ");
#nullable restore
#line 134 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                                                                             Write(attendence.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 136 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                         if (ViewBag.Teacher)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"icons icons-count-2\">\r\n                                                <i class=\"fas fa-pen\" data-toggle=\"tooltip\" data-placement=\"");
#nullable restore
#line 139 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                                                                                       Write(tooltipDirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Redaguoti\"></i>\r\n\r\n                                                <i class=\"fas\"></i>\r\n\r\n                                                <i class=\"fas fa-trash\" data-toggle=\"tooltip\" data-placement=\"");
#nullable restore
#line 143 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                                                                                         Write(tooltipDirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Ištrinti\"></i>\r\n\r\n                                            </div>\r\n");
#nullable restore
#line 146 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </li>\r\n");
#nullable restore
#line 148 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n");
#nullable restore
#line 150 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 154 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var selectedElement = null;\r\n\r\n        function deleteConfirmed() {\r\n            // Funkcija iskviecia kai patvirtintas istrynimas, reikia ajax requesto\r\n            fetch(\"");
#nullable restore
#line 163 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
              Write(Url.Action("DeleteAttendence", "Iverciai"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""", {
                method: ""post"",
                headers: { 'Content-Type': 'application/json' },
                body: entryToJSON(selectedElement)
            }).then(response => {
                if (response.status !== 200) {
                    // Error
                } else {
                    // Add element
                    location.reload(true);
                }
            })
        }

        function getEntryName(element) {
            return $(element).closest("".isp-item"").attr(""name"");
        }

        function getItem(element) {
            return $(element).closest("".list-group-item"");
        }

        function getAsObject(element) {
            let item = getItem(element);

            let status = item.find("".isp-item-status"").text();
            let id = item.find("".isp-item-atndId"").text();
            let student = item.find("".isp-item-student"").text();
            let lecture = item.find("".isp-item-lecture"").text();

            return {
    ");
                WriteLiteral(@"            status: status,
                id: id,
                student: student,
                lecture: lecture
            }
        }

        function entryToJSON(element) {
            return JSON.stringify({
                Id: parseInt(element.id),
                Status: element.status,
                Student: element.student,
                Lecture: parseInt(element.lecture)
            })
        }

        function deleteEntry(element) {
            selectedElement = getAsObject(element)

            $(""#modalEntryName"").text(""studento "" + selectedElement.student + "" lankomuma"");
            $('#deleteEntryModal').modal();
        }

        function editEntry(element) {
            selectedElement = getAsObject(element);
            console.log(selectedElement.status)

            requestInput(
                ""Redaguoti"",
                selectedElement.status,
                selectedElement.student,
                selectedElement.lecture,
               ");
                WriteLiteral(@" ""Redaguoti"",
                function () {
                    selectedElement.status = $(""#inputModalStatus"").val();
                    selectedElement.student = $(""#inputModalStudent"").val();
                    selectedElement.lecture = $(""#inputModalLecture"").val();
                    //console.log(selectedElement.id + ""-"" + selectedElement.mark);
                    fetch(""");
#nullable restore
#line 232 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                      Write(Url.Action("EditAttendence", "Iverciai"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""", {
                        method: ""post"",
                        headers: { 'Content-Type': 'application/json' },
                        body: entryToJSON(selectedElement)
                    }).then(response => {
                        if (response.status !== 200) {
                            // Error
                        } else {
                            // Add element
                            location.reload(true);
                        }
                    })
                });
        }

        function requestInput(header, initialText1, initialText2, initialText3, btnText, clickcb) {
            $(""#textModalLabel"").text(header);
            $(""#inputModalConfirm"").text(btnText);
            $(""#inputModalConfirm"").off(""click"");
            $(""#inputModalConfirm"").click(clickcb);
            $(""#inputModalStatus"").val(initialText1);
            $(""#inputModalStudent"").val(initialText2);
            $(""#inputModalLecture"").val(initialText3);
            $('#new");
                WriteLiteral(@"EntryModal').modal();
        }

        function newEntry() {
            requestInput(
                ""Prideti lankomuma"",
                """",
                """",
                """",
                ""Sukurti"",
                function () {
                    fetch(""");
#nullable restore
#line 266 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Iverciai\Attendance.cshtml"
                      Write(Url.Action("NewAttendence", "Iverciai"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""", {
                        method: ""post"",
                        headers: { 'Content-Type': 'application/json' },
                        body: JSON.stringify({
                            Status: $(""#inputModalStatus"").val(),
                            Lecture: parseInt($(""#inputModalLecture"").val()),
                            Student: $(""#inputModalStudent"").val()
                        })
                    }).then(response => {
                        if (response.status !== 200) {
                            // Error
                        } else {
                            // Add element
                            location.reload(true);
                        }
                    })
                });
        }

        function selectElement(element) {
            $(""#viewModalName"").val(getEntryName(element));
            $(""#viewModalContent"").val(""PRANESIMO TEKSTAS"");
            $('#viewEntryModal').modal();
        }

        $(document).ready(function () {");
                WriteLiteral(@"
            // Don't ask
            $(function () {
                $('[data-toggle=""tooltip""]').tooltip()
            });

            // Ištrinti
            $("".icons"").on('click', '.fa-trash', function (event) {
                event.stopPropagation();
                deleteEntry($(this));
            });

            // Redaguoti
            $("".icons"").on('click', '.fa-pen', function (event) {
                event.stopPropagation();
                editEntry($(this));
            });

            // Sukurimas 
            $(""#CreateAttendence"").click(function (event) {
                event.stopPropagation();
                newEntry();
            });

            // Paspaudimas ant elemento
            $("".isp-item-list"").on(""click"", "".isp-item"", function (event) {
                event.stopPropagation();
                selectElement($(this));
            });
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Module>> Html { get; private set; }
    }
}
#pragma warning restore 1591