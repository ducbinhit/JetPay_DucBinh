#pragma checksum "C:\Users\ndbinh\Source\Repos\MISA.Jetpay-Sourecode\MISA.JETPAY.DemoPaymentDateway\MISA.JETPAY.DemoPaymentDateway\Views\Home\gateway.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed13a9f4de58e9ac39cb937dd80a706a861b52b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_gateway), @"mvc.1.0.view", @"/Views/Home/gateway.cshtml")]
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
#line 1 "C:\Users\ndbinh\Source\Repos\MISA.Jetpay-Sourecode\MISA.JETPAY.DemoPaymentDateway\MISA.JETPAY.DemoPaymentDateway\Views\_ViewImports.cshtml"
using MISA.JETPAY.DemoPaymentDateway;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ndbinh\Source\Repos\MISA.Jetpay-Sourecode\MISA.JETPAY.DemoPaymentDateway\MISA.JETPAY.DemoPaymentDateway\Views\_ViewImports.cshtml"
using MISA.JETPAY.DemoPaymentDateway.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed13a9f4de58e9ac39cb937dd80a706a861b52b9", @"/Views/Home/gateway.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd01a0558851cdc09ea03fad0f308da12b7d0ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_gateway : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "D1133", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed13a9f4de58e9ac39cb937dd80a706a861b52b93888", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>Cổng thanh toán JETPAY</title>
    <link href=""/css/common.css"" rel=""stylesheet"" />
    <link href=""/css/input.css"" rel=""stylesheet"" />
    <link href=""/css/button.css"" rel=""stylesheet"" />
    <script src=""/lib/crawler.js""></script>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed13a9f4de58e9ac39cb937dd80a706a861b52b95230", async() => {
                WriteLiteral(@"
    <div class=""main"">
        <div class=""g-row""></div>
        <div class=""g-center"">
            <div class=""g-content"">
                <div class=""g-header"">
                    <div class=""g-banner""></div>
                </div>
                <div class=""order"">
                    <div class=""order-left"">
                        <div class=""g-logo""></div>
                    </div>
                    <div class=""order-center"">
                        <fieldset class=""order-info"">
                            <legend>Thông tin đơn hàng</legend>
                            <div class=""g-same-row"">
                                <div class=""g-lable"">Đơn hàng ::</div>
                                <div class=""form-input""><input type=""text""");
                BeginWriteAttribute("name", " name=\"", 1180, "\"", 1187, 0);
                EndWriteAttribute();
                WriteLiteral(@" readonly value=""Giao dich thang toan"" id=""txtDonHang"" /></div>
                            </div>
                            <div class=""g-same-row"">
                                <div class=""g-lable"">Giá trị đơn hàng ::</div>
                                <div class=""form-input""><input type=""text""");
                BeginWriteAttribute("name", " name=\"", 1497, "\"", 1504, 0);
                EndWriteAttribute();
                WriteLiteral(@" readonly value=""40,000.00 VND"" id=""txtGiaTriDonHang"" /></div>
                            </div>
                            <div class=""g-same-row"">
                                <div class=""g-lable"">Nhà cung cấp dịch vụ ::</div>
                                <div class=""form-input""><input type=""text""");
                BeginWriteAttribute("name", " name=\"", 1817, "\"", 1824, 0);
                EndWriteAttribute();
                WriteLiteral(@" readonly value=""CTY TNHH VI FPT"" id=""txtNhaCungCap"" /></div>
                            </div>
                        </fieldset>
                    </div>
                    <div class=""order-right""></div>
                </div>
                <div class=""g-line""></div>
                <!-- payment method -->
                <div class=""payment-method"">
                    <div class=""method-left""></div>
                    <div class=""method-center"">
                        <div class=""error-message"">
                            <!--<img style=""margin-right:6px; margin-top:2px;"" src=""/content/icon/error_icon.gif"" />
                            <div>Qúy khách vui lòng nhập đầy đủ thông tin.</div>-->
                        </div>
                        <fieldset class=""method-info"">
                            <legend>Chọn phương thức thanh toán</legend>
                            <div class=""g-same-row"">
                                <input type=""radio"" name=""payment"" id=""napaspa");
                WriteLiteral(@"y"" />
                                <p>Thanh toán qua NAPAS</p>
                            </div>
                            <div class=""g-same-row"">
                                <input type=""radio"" name=""payment"" />
                                <p>Thẻ ATM, tài khoản mở tại ngân hàng Việt Nam</p>
                            </div>
                        </fieldset>
                        <div class=""method-input"">
                            <div class=""g-same-row"">
                                <div class=""g-lable"">Chọn ngân hàng ::</div>
                                <div class=""form-input"">
                                    <select name=""selectBank"" id=""SelectBank"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed13a9f4de58e9ac39cb937dd80a706a861b52b99251", async() => {
                    WriteLiteral("VPBank");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <div class=""g-same-row"">
                                <div class=""g-lable"">Nhập tên chủ thẻ ::</div>
                                <div class=""form-input""><input type=""text"" name=""Tên chủ thẻ"" id=""txtTenChuThe"" required /></div>
                            </div>
                            <div class=""g-same-row"">
                                <div class=""g-lable"">Nhập số thẻ ::</div>
                                <div class=""form-input""><input type=""text"" name=""Số thẻ"" id=""txtSoThe"" required /></div>
                            </div>
                            <div class=""g-same-row"">
                                <div class=""g-lable"">Nhập hiệu lực thẻ ::</div>
                                <div class=""form-input"">
                                    <select class=""cardExpDate"" style=""width:50px; background-color:#ffffff"" name=""Car");
                WriteLiteral(@"dMonth"" id=""cardMonth""></select>
                                    (mm)
                                </div>
                                <div class=""form-input"">
                                    <select class=""cardExpDate"" style=""width:50px; background-color:#ffffff"" name=""CardYear"" id=""cardYear""></select>
                                    (yy)
                                </div>
                            </div>
                        </div>
                        <div class=""g-row""></div>
                        <div class=""g-same-row group-button"">
                            <div class=""g-lable""></div>
                            <button id=""g-btn-cancel"" title=""Hủy"">Hủy</button>
                            <button id=""g-btn-pay"" class=""g-btn-pay-napas"" title=""Thanh toán""><a style=""text-decoration:none; color:#084067;"">Thanh toán</a></button>
                        </div>
                        <div class=""g-same-row"">
                            <div class=""align-righ");
                WriteLiteral(@"t tutorial-security""><a style=""color:blue;"" href=""#"">Hướng dẫn giao dịch thanh toán an toàn</a></div>
                        </div>
                        <div class=""g-row""></div>
                    </div>
                    <div class=""method-right"">
                        <div class=""method-logo"">
                            <img style=""padding-bottom:10px;"" src=""/content/img/VPB_Large.jpg"" />
                            <img id=""imgCardLogo"" src=""/content/img/default.jpg"" />
                            <div class=""logo-desc""></div>
                        </div>
                    </div>
                </div>
                <!-- end payment method -->
                <div class=""g-note"">
                    <span style=""text-decoration:underline"" class=""font-bold"">Lưu ý: </span>Bạn phải đăng ký thanh toán trực tuyến cho thẻ ghi nợ nội địa để tiếp tục thực hiện giao dịch. Trường hợp
                    chưa đăng ký, vui lòng liên hệ theo số điện thoại VPB 0243.9288880/ 1900 545415 ho");
                WriteLiteral(@"ặc tham khảo <span style=""color:black;"" class=""font-bold"">Tại đây</span> để biết thêm chi tiết
                </div>
                <div class=""g-scroll"">
                    <div id=""bankscroll"">
                        <img src=""/content/img/VCB.png""");
                BeginWriteAttribute("alt", " alt=\"", 6965, "\"", 6971, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/TCB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7032, "\"", 7038, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/VIB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7099, "\"", 7105, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/EIB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7166, "\"", 7172, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/CTG.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7233, "\"", 7239, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/MB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7299, "\"", 7305, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/HDB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7366, "\"", 7372, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/ACB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7433, "\"", 7439, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/VAB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7500, "\"", 7506, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/STB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7567, "\"", 7573, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/MSB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7634, "\"", 7640, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/VPB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7701, "\"", 7707, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/DAB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7768, "\"", 7774, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/LPB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7835, "\"", 7841, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/TPB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7902, "\"", 7908, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/OCB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7969, "\"", 7975, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/OJB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8036, "\"", 8042, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/ABB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8103, "\"", 8109, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/NASB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8171, "\"", 8177, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/BVB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8238, "\"", 8244, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/GPB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8305, "\"", 8311, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/NCB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8372, "\"", 8378, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/VARB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8440, "\"", 8446, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/BIDV.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8508, "\"", 8514, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/SEAB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8576, "\"", 8582, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <img src=\"/content/img/KLB.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8643, "\"", 8649, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""g-footer"">
                    <div class=""footer-center"">Copyright © 2019 JETPAY, All rights reserved</div>
                    <div class=""footer-right"">
                        <img src=""/content/img/trustVN.jpg"" />
                        <img src=""/content/img/verisign.jpg"" />
                        <img src=""/content/img/trustwave.jpg"" />
                    </div>
                </div>
            </div>
        </div>
        <div class=""g-row""></div>
        <div class=""payment-napas""></div>
    </div>
    <script src=""/lib/jquery-3.5.1.min.js""></script>
    <script src=""/js/gateway.js""></script>
    <script src=""/js/common/common.js""></script>
");
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
            WriteLiteral("\r\n</html>");
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
