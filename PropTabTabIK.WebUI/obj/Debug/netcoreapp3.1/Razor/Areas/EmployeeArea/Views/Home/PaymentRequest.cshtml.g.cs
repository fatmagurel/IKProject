#pragma checksum "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2addcac18ffa126daf17b88e9082bfcf65221a69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_EmployeeArea_Views_Home_PaymentRequest), @"mvc.1.0.view", @"/Areas/EmployeeArea/Views/Home/PaymentRequest.cshtml")]
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
#line 1 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\_ViewImports.cshtml"
using PropTabTabIK;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\_ViewImports.cshtml"
using PropTabTabIK.Entities.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\_ViewImports.cshtml"
using PropTabTabIK.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\_ViewImports.cshtml"
using PropTabTabIK.WebUI.Areas.EmployeeArea;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\_ViewImports.cshtml"
using PropTabTabIK.Entities.SideEntities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2addcac18ffa126daf17b88e9082bfcf65221a69", @"/Areas/EmployeeArea/Views/Home/PaymentRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c287190ed0e76a93a07cd20f4b75b799c89d24", @"/Areas/EmployeeArea/Views/_ViewImports.cshtml")]
    public class Areas_EmployeeArea_Views_Home_PaymentRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PropTabTabIK.Entities.SideEntities.AdvancePayment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control  select2-single"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("min", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("step", new global::Microsoft.AspNetCore.Html.HtmlString("0.25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "250", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("exampleInputAmount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Price"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("request-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PaymentRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
  
    ViewData["Title"] = "Requests";
    //List<AllowRequest> allowRequests = ViewBag.AllowRequest;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>İzinler</h1>

<main>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <h1>Anasayfa</h1>

                <div class=""separator mb-5""></div>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""AllowRequest"">
                            <button class=""prop-button primary float-right "" color=""primary"" data-toggle=""modal"" data-target=""#exampleModal"">AVANS TALEP ET</button>
");
#nullable restore
#line 22 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
                             if (TempData["Hata"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""alert alert-danger alert-dismissible"" role=""alert"">
                                    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                    <strong>");
#nullable restore
#line 28 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
                                       Write(TempData["Hata"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                </div>\r\n");
#nullable restore
#line 30 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 32 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
                         if (TempData["Hata"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""alert alert-danger alert-dismissible"" role=""alert"">
                                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                                <strong>");
#nullable restore
#line 38 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
                                   Write(TempData["Hata"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                            </div>\r\n");
#nullable restore
#line 40 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
                         if (TempData["DateInclude"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""alert alert-danger alert-dismissible"" role=""alert"">
                                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                                <strong>");
#nullable restore
#line 48 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
                                   Write(TempData["DateInclude"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                            </div>\r\n");
#nullable restore
#line 50 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</main>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""exampleModal"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""><i class=""simple-icon-plane""></i>&nbsp;İzin günü</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2addcac18ffa126daf17b88e9082bfcf65221a6914455", async() => {
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n                    <span>İzin Türü</span>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2addcac18ffa126daf17b88e9082bfcf65221a6914826", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 70 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AdvancePaymentType);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 70 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<PropTabTabIK.Core.Enum.AdvancePaymentType>();

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div class=""input-group-addon mt-3"">Avans Miktarı</div>
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <div class=""form-group"">
                                <label class=""sr-only"" for=""exampleInputAmount"">Amount (in Swiss Francs)</label>
                                <div class=""input-group"">
                                    
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2addcac18ffa126daf17b88e9082bfcf65221a6917524", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 78 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Amount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("&nbsp;₺\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-lg-6 d-none\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2addcac18ffa126daf17b88e9082bfcf65221a6920130", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 83 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.State);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
                                              WriteLiteral(PropTabTabIK.Core.Enum.State.Pending);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2addcac18ffa126daf17b88e9082bfcf65221a6922463", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 84 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CompanyDescription);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2addcac18ffa126daf17b88e9082bfcf65221a6924041", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 85 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EmployeeID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
                                                   WriteLiteral(ViewBag.EmployeeID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"row\">\r\n\r\n                    </div>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2addcac18ffa126daf17b88e9082bfcf65221a6926503", async() => {
                    WriteLiteral("<span>Açıklama<br /></span>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 92 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2addcac18ffa126daf17b88e9082bfcf65221a6928225", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 93 "C:\Users\user\Source\Workspaces\IK Project Last\PropTabTabIK\PropTabTabIK.WebUI\Areas\EmployeeArea\Views\Home\PaymentRequest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                </div>
                <div class=""modal-footer"">
                    <button color=""dark-outlined"" type=""button"" class=""prop-button dark-outlined close"" data-dismiss=""modal"" aria-label=""Close""> İptal</button>
                    <button color=""primary"" type=""submit"" class=""prop-button primary""> Kaydet</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PropTabTabIK.Entities.SideEntities.AdvancePayment> Html { get; private set; }
    }
}
#pragma warning restore 1591