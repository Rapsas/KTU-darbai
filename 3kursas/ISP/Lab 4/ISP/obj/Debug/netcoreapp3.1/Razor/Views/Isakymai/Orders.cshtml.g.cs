#pragma checksum "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Isakymai\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6b2538862b369c5d330a1d2fe7ae22b027407ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Isakymai_Orders), @"mvc.1.0.view", @"/Views/Isakymai/Orders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b2538862b369c5d330a1d2fe7ae22b027407ed", @"/Views/Isakymai/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12aad888534da250386b83b9fba5283636c4f66c", @"/Views/_ViewImports.cshtml")]
    public class Views_Isakymai_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Isakymai", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contracts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Payments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6b2538862b369c5d330a1d2fe7ae22b027407ed5006", async() => {
                    WriteLiteral("Įsakymai");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6b2538862b369c5d330a1d2fe7ae22b027407ed6740", async() => {
                    WriteLiteral("Sutartys");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6b2538862b369c5d330a1d2fe7ae22b027407ed8387", async() => {
                    WriteLiteral("Įmokos");
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
                        <input id=""inputModalName"" type=""text"" class=""form-control"" placeholder=""Numeris"" aria-label=""Įsakymo numeris"" aria-describedby=""basic-addon1"">
                    </div>

                    <div class");
                WriteLiteral(@"=""input-group mb-3"">
                        <textarea id=""inputModalText"" type=""text"" class=""form-control"" placeholder=""Pavadinimas"" aria-label=""Įsakymo pavadinimas"" aria-describedby=""basic-addon1""></textarea>
                    </div>

                    <div class=""input-group mb-3"">
                        <input id=""inputModalTime"" type=""date"" class=""form-control"" placeholder=""Data"" aria-label=""Priskyrimo data"" aria-describedby=""basic-addon1""></input>
                    </div>

                    <div class=""input-group mb-3"">
                        <input id=""inputModalTimeFrom"" type=""date"" class=""form-control"" placeholder=""Nuo"" aria-label=""Galioja nuo"" aria-describedby=""basic-addon1""></input>
                    </div>

                    <div class=""input-group mb-3"">
                        <input id=""inputModalTimeUntil"" type=""date"" class=""form-control"" placeholder=""Iki"" aria-label=""Galioja iki"" aria-describedby=""basic-addon1""></input>
                    </div>
                ");
                WriteLiteral(@"</div>

                <div class=""modal-footer"">
                    <button id=""inputModalConfirm"" type=""button"" class=""btn btn-success"" data-dismiss=""modal"">Redaguoti</button>
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
                    <!-- CIA VISI LAUKAI TOKIE ");
                WriteLiteral(@"PATYS KAIP PRAITAM TIK VISI TURI disabled -->
                    <div class=""input-group mb-3"">
                        <input disabled id=""viewModalName"" type=""text"" class=""form-control"" placeholder=""Numeris"" aria-label=""Įsakymo numeris"" aria-describedby=""basic-addon1"">
                    </div>

                    <div class=""input-group mb-3"">
                        <textarea disabled id=""viewModalText"" type=""text"" class=""form-control"" placeholder=""Pavadinimas"" aria-label=""Įsakymo pavadinimas"" aria-describedby=""basic-addon1""></textarea>
                    </div>

                    <div class=""input-group mb-3"">
                        <input disabled id=""viewModalTime"" type=""date"" class=""form-control"" placeholder=""Data"" aria-label=""Priskyrimo data"" aria-describedby=""basic-addon1""></input>
                    </div>

                    <div class=""input-group mb-3"">
                        <input disabled id=""viewModalTimeFrom"" type=""date"" class=""form-control"" placeholder=""Nuo"" aria-la");
                WriteLiteral(@"bel=""Galioja nuo"" aria-describedby=""basic-addon1""></input>
                    </div>

                    <div class=""input-group mb-3"">
                        <input disabled id=""viewModalTimeUntil"" type=""date"" class=""form-control"" placeholder=""Iki"" aria-label=""Galioja iki"" aria-describedby=""basic-addon1""></input>
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
            WriteLiteral("\r\n<div class=\"isp-item-list\">\r\n");
#nullable restore
#line 97 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Isakymai\Orders.cshtml"
      
        List<SelectListItem> listItems = new List<SelectListItem>();
        listItems.Add(new SelectListItem
        {
            Text = "Einamojo semestro įsakymai",
            Value = "Einamojo semestro įsakymai",
            Selected = true

        });
        listItems.Add(new SelectListItem
        {
            Text = "Visi įsakymai",
            Value = "Visi įsakymai"
        });
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"isp\" style=\"margin-bottom: 15px;\">\r\n        <i class=\"fas fa\" style=\"color: #3c5c4a;\"></i>\r\n        <span class=\"name\">\r\n            ");
#nullable restore
#line 116 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Isakymai\Orders.cshtml"
       Write(Html.DropDownList("yourDropName", listItems, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n    </div>\r\n");
#nullable restore
#line 119 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Isakymai\Orders.cshtml"
     if (ViewBag.Admin)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"isp-item\" id=\"CreateOrder\" style=\"margin-bottom: 15px;\">\r\n            <i class=\"fas fa-plus\" style=\"color: #3c5c4a;\"></i>\r\n            <span class=\"name\">Naujas įsakymas</span>\r\n        </div>\r\n");
#nullable restore
#line 125 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Isakymai\Orders.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 127 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Isakymai\Orders.cshtml"
     for (int i = 0; i < 10; i++)
    {
        string tooltipDirection = i == 0 ? "bottom" : "top";


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"isp-item\"");
            BeginWriteAttribute("name", " name=\"", 6223, "\"", 6232, 1);
#nullable restore
#line 131 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Isakymai\Orders.cshtml"
WriteAttributeValue("", 6230, i, 6230, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <span class=\"name\">Pranešimas ");
#nullable restore
#line 132 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Isakymai\Orders.cshtml"
                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n");
#nullable restore
#line 134 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Isakymai\Orders.cshtml"
             if (ViewBag.Admin)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"vertical-line\"></div>\r\n");
            WriteLiteral("                <div class=\"icons icons-count-2\">\r\n                    <i class=\"fas fa-pen\" data-toggle=\"tooltip\" data-placement=\"");
#nullable restore
#line 139 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Isakymai\Orders.cshtml"
                                                                           Write(tooltipDirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Redaguoti\"></i>\r\n\r\n                    <i class=\"fas\"></i>\r\n\r\n                    <i class=\"fas fa-trash\" data-toggle=\"tooltip\" data-placement=\"");
#nullable restore
#line 143 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Isakymai\Orders.cshtml"
                                                                             Write(tooltipDirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Ištrinti\"></i>\r\n                </div>\r\n");
#nullable restore
#line 145 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Isakymai\Orders.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 147 "D:\KTU-darbai\Universitie\3kursas\ISP\Lab 4\ISP\Views\Isakymai\Orders.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
                ""ĮSAKYMO TEKSTAS"",
                ""2020-11-05"",
                ""2020-11-06"",
                ""2020-11-30"",
                ""Redaguoti"",
                function () {
                    // Ajax
                });
        }

        function requestInput(header, initialText1, initialText2, initialText3, initialText4, initialText5, btnText, clickcb) {
            $(""#textModalLabel"").text(header);
            $(""#inputMo");
                WriteLiteral(@"dalConfirm"").text(btnText);
            $(""#inputModalConfirm"").off(""click"");
            $(""#inputModalConfirm"").click(clickcb);
            $(""#inputModalName"").val(initialText1);
            $(""#inputModalText"").val(initialText2);
            $(""#inputModalTime"").val(initialText3);
            $(""#inputModalTimeFrom"").val(initialText4);
            $(""#inputModalTimeUntil"").val(initialText5);
            $('#newEntryModal').modal();
        }

        function newEntry() {
            requestInput(
                ""Naujas įsakymas"",
                """",
                """",
                """",
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
            $(""#viewModalText"").val(""ĮSAKYMO TEKSTAS"");
            $(""#viewModalTime"").val(""2020-11-05"");
            $(""#viewModalTimeFrom"").val(""2020-11-06"");
            $(""#viewModalTimeUntil"").val(""2020-11-30"");
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
            $(""#Crea");
                WriteLiteral(@"teOrder"").click(function (event) {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
