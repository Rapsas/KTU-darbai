#pragma checksum "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5fa905f1a9f92c1e771c4d53f2f689664f78ca4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Iverciai_Marks), @"mvc.1.0.view", @"/Views/Iverciai/Marks.cshtml")]
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
#line 1 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\_ViewImports.cshtml"
using ISP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\_ViewImports.cshtml"
using ISP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5fa905f1a9f92c1e771c4d53f2f689664f78ca4", @"/Views/Iverciai/Marks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12aad888534da250386b83b9fba5283636c4f66c", @"/Views/_ViewImports.cshtml")]
    public class Views_Iverciai_Marks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Iverciai", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Marks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Attendance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Requirements", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("Sidebar", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5fa905f1a9f92c1e771c4d53f2f689664f78ca44975", async() => {
                    WriteLiteral("Įverčiai");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5fa905f1a9f92c1e771c4d53f2f689664f78ca46709", async() => {
                    WriteLiteral("Lankomumas");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5fa905f1a9f92c1e771c4d53f2f689664f78ca48358", async() => {
                    WriteLiteral("Modulių reikalavimai");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
                    <!-- CIA VISI LAUKAI KURIE RODOMI PRIDEJIMO IR REDAGAVIMO METU, REIKES PAKEISTI requestInput FUNKCIJA -->
                    <div class=""input-group mb-3"">
                        <label for=""inputModalName"">Atsiskaitymo pavadinimas:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <input id=""inputModalName"" type=""text"" class=""form-control"" placehold");
                WriteLiteral(@"er=""Pavadinimas"" aria-label=""Atsiskaitymo pavadinimas"" aria-describedby=""basic-addon1"">
                    </div>

                    <div class=""input-group mb-3"">
                        <label for=""inputModalName"">Data:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <input id=""inputModalName"" type=""date"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1834, "\"", 1848, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-label=""Atsiskaitymo data"" aria-describedby=""basic-addon1"">
                    </div>

                    <div class=""input-group mb-3"">
                        <label for=""inputModalName"">Auditorija:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <input id=""inputModalName"" type=""text"" class=""form-control"" placeholder=""Auditorija"" aria-label=""Auditorija"" aria-describedby=""basic-addon1"">
                    </div>

                    <div class=""input-group mb-3"">
                        <label for=""inputModalName"">Pažymys:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <textarea id=""inputModalContent"" type=""text"" class=""form-control"" placeholder=""Pažymys"" aria-label=""Pažymys"" aria-describedby=""basic-addon1""></textarea>
                    </div>
                </div>

                <div class=""modal-footer"">
                    <button id=""inputModalConfirm"" type=""button"" class=""btn btn-success"" data-dismiss=""modal"">");
                WriteLiteral(@"Redaguoti</button>
                    <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Atšaukti</button>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""viewEntryModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""viewModalLabel"">Peržiūra</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>

                <div class=""modal-body"">
                    <!-- CIA VISI LAUKAI KURIE RODOMI PRIDEJIMO IR REDAGAVIMO METU, REIKES PAKEISTI requestInput FUNKCIJA -->
                    <div class=""input-group mb-3"">
                        <label for");
                WriteLiteral(@"=""inputModalName"">Atsiskaitymo pavadinimas:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <input disabled id=""inputModalName"" type=""text"" class=""form-control"" placeholder=""Pavadinimas"" aria-label=""Atsiskaitymo pavadinimas"" aria-describedby=""basic-addon1"">
                    </div>

                    <div class=""input-group mb-3"">
                        <label for=""inputModalName"">Data:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <input disabled id=""inputModalName"" type=""date"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4480, "\"", 4494, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-label=""Atsiskaitymo data"" aria-describedby=""basic-addon1"">
                    </div>

                    <div class=""input-group mb-3"">
                        <label for=""inputModalName"">Auditorija:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <input disabled id=""inputModalName"" type=""text"" class=""form-control"" placeholder=""Auditorija"" aria-label=""Auditorija"" aria-describedby=""basic-addon1"">
                    </div>

                    <div class=""input-group mb-3"">
                        <label for=""inputModalName"">Pažymys:  </label> <br /> <!--NElabai cia gerai. reikes keisti-->
                        <textarea disabled id=""inputModalContent"" type=""number"" class=""form-control"" placeholder=""Pažymys"" aria-label=""Pažymys"" aria-describedby=""basic-addon1""></textarea>
                    </div>
                </div>

                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Užd");
                WriteLiteral("aryti</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n<table class=\"table\" style=\"width: 100%\">\r\n");
#nullable restore
#line 107 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml"
     for (int i = 0; i < 5; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>Modelis nr. ");
#nullable restore
#line 110 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml"
                        Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n");
#nullable restore
#line 112 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml"
         if (ViewBag.Admin)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <tr>
                <th>
                    <div class=""isp-item"" id=""CreateAssingment"" style=""margin-bottom: 15px;"">
                        <i class=""fas fa-plus"" style=""color: #3c5c4a;""></i>
                        <span class=""name"">Naujas atsiskaitymas</span>
                    </div>
                </th>
            </tr>
");
#nullable restore
#line 122 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <div class=\"isp-item-list col\">\r\n");
#nullable restore
#line 126 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml"
                     for (int u = 0; u < 10; u++)
                    {
                        string tooltipDirection = u == 0 ? "bottom" : "top";


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"isp-item\"");
            BeginWriteAttribute("name", " name=\"", 6805, "\"", 6814, 1);
#nullable restore
#line 130 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml"
WriteAttributeValue("", 6812, u, 6812, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span class=\"name\">Atsiskaitymas ");
#nullable restore
#line 131 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml"
                                                        Write(u);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"right-third\"><b>\'Pazymys\'</b></span>\r\n\r\n");
#nullable restore
#line 134 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml"
                             if (ViewBag.Admin)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"vertical-line\"></div>\r\n");
            WriteLiteral("                                <div class=\"icons icons-count-2\">\r\n                                    <i class=\"fas fa-pen\" data-toggle=\"tooltip\" data-placement=\"");
#nullable restore
#line 139 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml"
                                                                                           Write(tooltipDirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Redaguoti\"></i>\r\n\r\n                                    <i class=\"fas\"></i>\r\n\r\n                                    <i class=\"fas fa-trash\" data-toggle=\"tooltip\" data-placement=\"");
#nullable restore
#line 143 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml"
                                                                                             Write(tooltipDirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Ištrinti\"></i>\r\n                                </div>\r\n");
#nullable restore
#line 145 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 147 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 151 "D:\KTU-darbai\Universitie\3kursas\ISP\Views\Iverciai\Marks.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function deleteConfirmed() {
            // Funkcija iskviecia kai patvirtintas istrynimas, reikia ajax requesto
        }

        function getEntryName(element) {
            return $(element).closest("".isp-item"").attr(""name"");
        }

        function deleteEntry(element) {
            $(""#modalEntryName"").text(getEntryName(element));
            $('#deleteEntryModal').modal();
        }

        function editEntry(element) {
            requestInput(
                ""Redaguoti"",
                getEntryName(element),
                ""PRANESIMO TEKSTAS"",
                ""Redaguoti"",
                function () {
                    // Ajax
                });
        }

        function requestInput(header, initialText1, initialText2, btnText, clickcb) {
            $(""#textModalLabel"").text(header);
            $(""#inputModalConfirm"").text(btnText);
            $(""#inputModalConfirm"").off(""click"");
            $(""#inputModalConfirm"").click(clickcb);
");
                WriteLiteral(@"            $(""#inputModalName"").val(initialText1);
            $(""#inputModalContent"").val(initialText2);
            $('#newEntryModal').modal();
        }

        function newEntry() {
            requestInput(
                ""Naujas atsiskaitymas"",
                """",
                """",
                ""Sukurti"",
                function () {
                    // Cia normalu ajax reikes ideti, cia tik pavyzdinis
");
                WriteLiteral(@"                });
        }

        function selectElement(element) {
            $(""#viewModalName"").val(getEntryName(element));
            $(""#viewModalContent"").val(""PRANESIMO TEKSTAS"");
            $('#viewEntryModal').modal();
        }

        $(document).ready(function () {
            // Don't ask
            $(function () {
                $('[data-toggle=""tooltip""]').tooltip()
            });

            // Ištrinti
            $("".isp-item"").on('click', '.fa-trash', function (event) {
                event.stopPropagation();
                deleteEntry($(this));
            });

            // Redaguoti
            $("".isp-item"").on('click', '.fa-pen', function (event) {
                event.stopPropagation();
                editEntry($(this));
            });

            // Sukurimas
            $(""#CreateAssingment"").click(function (event) {
                event.stopPropagation();
                newEntry();
            });

            // Paspaudimas an");
                WriteLiteral("t elemento\r\n            $(\".isp-item-list\").on(\"click\", \".isp-item\", function (event) {\r\n                event.stopPropagation();\r\n                selectElement($(this));\r\n            });\r\n        })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
