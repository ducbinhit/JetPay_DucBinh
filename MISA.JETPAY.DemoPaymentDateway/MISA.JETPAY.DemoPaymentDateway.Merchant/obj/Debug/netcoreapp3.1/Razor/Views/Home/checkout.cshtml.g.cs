#pragma checksum "C:\Users\ndbinh\source\repos\JetPay_DucBinh\MISA.JETPAY.DemoPaymentDateway\MISA.JETPAY.DemoPaymentDateway.Merchant\Views\Home\checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "515312385f5f38ed25fb45fcbb21b219af04ea9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_checkout), @"mvc.1.0.view", @"/Views/Home/checkout.cshtml")]
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
#line 1 "C:\Users\ndbinh\source\repos\JetPay_DucBinh\MISA.JETPAY.DemoPaymentDateway\MISA.JETPAY.DemoPaymentDateway.Merchant\Views\_ViewImports.cshtml"
using MISA.JETPAY.DemoPaymentDateway.Merchant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ndbinh\source\repos\JetPay_DucBinh\MISA.JETPAY.DemoPaymentDateway\MISA.JETPAY.DemoPaymentDateway.Merchant\Views\_ViewImports.cshtml"
using MISA.JETPAY.DemoPaymentDateway.Merchant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"515312385f5f38ed25fb45fcbb21b219af04ea9e", @"/Views/Home/checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7b062b4a1eb8182c91a947bef721327cdb35c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "515312385f5f38ed25fb45fcbb21b219af04ea9e3506", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>Sen &#x110;&#x1ECF; - MISA.JETPAY.DemoPaymentDateway.Merchant</title>
    <link href=""/css/page/checkout/checkout.css"" rel=""stylesheet"" />
    <link href=""/css/page/checkout/main.css"" rel=""stylesheet"" />
    <link href=""/css/page/checkout/orderSuccessful.css"" rel=""stylesheet"" />
    <link href=""/css/page/checkout/payment.css"" rel=""stylesheet"" />
    <link href=""/lib/icon/fontawesome-free-5.15.2-web/css/all.css"" rel=""stylesheet"" />
    <link href=""/css/page/checkout/orderSuccessful.css"" rel=""stylesheet"" />
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "515312385f5f38ed25fb45fcbb21b219af04ea9e5138", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <main role=""main"" class=""pb-3"">


            <!--Header-->
            <div class=""header"">
                <div class=""logo"">
                    <div class=""icon-sendo""></div>
                </div>

            </div>
            <!--Content-->
            <div class=""content"">
                <div class=""title"">
                    <div class=""text-confirm"">Xác Nhận Thanh Toán</div>
                    <!-- <h1>Xác nhận thanh toán</h1>-->
                </div>
                <!--Layout left-->
                <div class=""content-left"">
                    <!--Panel địa chỉ nhận hàng-->
                    <div class=""panel"">
                        <div class=""panel-header"">
                            <i class=""fas fa-map-marker-alt"" style=""color: #4a90e2;""></i>
                            <span><b>Địa chỉ nhận hàng</b></span>
                        </div>
                        <div class=""panel-content"">
                            <d");
                WriteLiteral(@"iv class=""delivery-address"">
                                <span><b>Vũ Dương</b></span> |<span style=""color: #828282""> 0984138953</span>
                                <br />
                                <span style=""color: #828282"">Nhà riêng: Liên quan, Thạch Thất, Hà Nội</span>
                            </div>
                        </div>
                    </div>
                    <!--Phương thức thanh toán-->
                    <div class=""panel"">
                        <div class=""panel-header"">
                            <i class=""fas fa-truck"" style=""color: #4a90e2;""></i>
                            <span><b>Phương thức giao hàng</b></span>
                        </div>
                        <div class=""panel-content"">
                            <div class=""delivery-methods"">
                                <div class=""item-delivery"">
                                    <input type=""radio"" class=""custom-radio"" name=""deliveryMethod"" />
                               ");
                WriteLiteral(@"     <span>Chỉ giao trong giờ hành chính</span>
                                </div>
                                <br />
                                <div class=""item-delivery"">
                                    <input type=""radio"" class=""custom-radio"" name=""deliveryMethod"" />
                                    <span>Giao cả tuần (trừ CN và ngày lễ)</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--Phương thức giao hàng-->
                    <div class=""panel"">
                        <div class=""panel-header"">
                            <i class=""fas fa-file-invoice-dollar"" style=""color: #4a90e2;""></i>
                            <span><b>Phương thức thanh toán</b></span>
                        </div>
                        <div class=""panel-content"">

                            <ul>
                                <li>
                                    <div c");
                WriteLiteral(@"lass=""option"">
                                        <input type=""radio"" class=""custom-radio"" id=""a1"" name=""paymentMethod"" value=""b1dbd"" />
                                    </div>
                                    <div class=""content-payment"">
                                        <ul>
                                            <li>Tiền mặt khi nhận hàng</li>
                                            <li>
                                                <span style=""color: #828282;"">Phí thu hộ : <span style=""font-weight: 500; color: #55ba78;"">Miễn phí</span></span>
                                            </li>
                                        </ul>
                                    </div>

                                </li>
                                <li>
                                    <div class=""option"">
                                        <input type=""radio"" class=""custom-radio"" name=""paymentMethod"" disabled />
                                    </d");
                WriteLiteral(@"iv>
                                    <div class=""content-payment disable-item"">
                                        <ul>
                                            <li>Thanh toán kết hợp</li>
                                            <li>
                                                <span style=""color: #828282;"">Ví Senpay thanh toán nhanh hơn và nhận nhiều ưu đãi hơn</span>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
                                <li>
                                    <div class=""option"">
                                        <input type=""radio"" class=""custom-radio"" name=""paymentMethod"" disabled />
                                    </div>
                                    <div class=""content-payment disable-item"">
                                        <ul>
                                            <li>Ví SenPay</li>
  ");
                WriteLiteral(@"                                          <li>
                                                <span style=""color: #828282;"">Ví Senpay thanh toán nhanh hơn và nhận nhiều ưu đãi hơn</span>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
                                <li>
                                    <div class=""option"">
                                        <input type=""radio"" class=""custom-radio"" id=""a2"" name=""paymentMethod"" value=""JetPay"" />
                                    </div>
                                    <div class=""content-payment "">
                                        <ul>
                                            <li>Thanh toán online qua JetPay</li>

                                        </ul>
                                    </div>
                                </li>
                                <li>
                 ");
                WriteLiteral(@"                   <div class=""option"">
                                        <input type=""radio"" class=""custom-radio"" id=""ecom-payment"" name=""paymentMethod"" value=""ecom-payment"" />
                                    </div>
                                    <div class=""content-payment"">
                                        <ul>
                                            <li>Thẻ ATM đã đăng kí InternetBanking</li>
                                            <li>
                                                <div class=""option-bank"">
                                                    <span>Qua thẻ : <b id=""nameBank""></b></span>
                                                    <span id=""ecom-paymentChange"" style=""float: right; color: #4a90e2"">Thay đổi</span>
                                                </div>
                                            </li>
                                        </ul>
                                    </div>
                                </l");
                WriteLiteral(@"i>
                                <li>
                                    <div class=""option"">
                                        <input type=""radio"" class=""custom-radio"" disabled />
                                    </div>
                                    <div class=""content-payment disable-item"" style=""border-bottom: none"">
                                        <ul>
                                            <li>Ngân hàng liên kết trực tiếp</li>
                                            <li>
                                                <span style=""color: #828282;"">Ví Senpay thanh toán nhanh hơn và nhận nhiều ưu đãi hơn</span>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!--Layout right-->
                <div");
                WriteLiteral(@" class=""content-right"">
                    <!--Mã ưu đãi-->
                    <div class=""panel"">
                        <div class=""panel-header"">
                            <i class=""fab fa-centercode"" style=""color: #4a90e2;""></i>

                            <span><b>Mã ưu đãi Sendo</b></span>
                        </div>
                        <div class=""panel-content"">
                            <div class=""btn-select"">
                                Chọn/nhập mã
                            </div>
                        </div>
                    </div>
                    <!--Thông tin đơn hàng-->
                    <div class=""panel"">
                        <div class=""panel-header"">
                            <i class=""fas fa-cart-plus"" style=""color: #4a90e2;""></i>
                            <span><b>Thông tin đơn hàng</b></span>
                        </div>
                        <div class=""panel-content"">
                            <div class=""information-sh");
                WriteLiteral(@"op"">
                                <span>Bán bởi shop: Phan Nguyên Lâm </span>
                            </div>
                            <div class=""items-product"">
                                <div class=""img-product"">
                                    <img src=""https://inhuyhoang.com/wp-content/uploads/2020/08/in-hop-khau-trang-y-te-1024x1024.jpg"" alt=""product"" />
                                </div>
                                <div class=""info-product"">
                                    <div class=""name-product"">
                                        <span>Hộp 50 cái khẩu trang 4 lớp </span>
                                    </div>
                                    <div class=""price-product"">
                                        <span style=""color: red;"">25.000đ</span>
                                    </div>
                                </div>
                            </div>
                            <div class=""note"">
                               ");
                WriteLiteral(@" <textarea class=""input-note"" placeholder=""Ghi chú cho shop""></textarea>
                            </div>
                        </div>
                    </div>
                    <!--Tổng tiền-->
                    <div class=""panel"">
                        <div class=""panel-content"">
                            <div class=""s-row"">
                                <span>Tạm tính</span>
                                <span class=""s-price"">25.000đ</span>
                            </div>
                            <div class=""s-row"" style=""margin-top: 16px"">
                                <span>Phí vận chuyển</span>
                                <span class=""s-price"">47.000đ</span>
                            </div>
                            <hr />
                            <div class=""s-row"">
                                <span style=""line-height: 31px"">Mã hóa đơn </span>
                                <input class=""s-price"" id=""txtMaHoaDon"" type=""text"" style=""color:red;h");
                WriteLiteral(@"eight: 31px; width: 65%;"" value=""ORD_001"" />
                            </div>
                            <div class=""s-row"">
                                <span style=""line-height: 31px"">Tổng thanh toán </span>
                                <input class=""s-price"" id=""txtTongTien"" type=""text"" style=""color:red;height: 31px; width: 65%;"" value=""12000"" />
                            </div>
                            <div class=""btn-pay"">
                                <a>
                                    <div class=""txt-pay"">
                                        <span style=""color: #fff;font-weight:bold"">Thanh toán</span>

                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
            <!--Footer-->
            <div style=""clear:both;""></div>
            <div class=""footer""></div>
            <!--Popup-->
       ");
                WriteLiteral(@"     <!-- <div class=""popup-modal""></div>-->
            <div id=""payment"" class=""payment"">
                <div class=""popup-modal""></div>
                <div class=""payment-modal"">
                    <div class=""title-bar"">
                        <h2 class=""title"">Ngân hàng hỗ trợ</h2>
                        <i class="" icon-close fa fa-times fa-1.5x"" id=""btn-close""></i>
                    </div>
                    <!--Danh sách ngân hàng-->
                    <div class=""payment-company"">
                        <ul class=""payment-list"">
                            <li class=""payment-search"">
                                <input class=""search-input"" type=""text"" name=""search"" id=""search"" placeholder=""Tìm kiếm"">
                            </li>
                            <li class=""payment-item"">
                                <div id=""ACB"" class=""payment-item-image"">
                                    <img src=""/image/ACB.jpg"" alt=""ACB"">
                                </div>
 ");
                WriteLiteral(@"                               <h3 class=""payment-item-name"">ACB</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""Agribank"" class=""payment-item-image"">
                                    <img src=""/image/agribank.jpg"" alt=""Agribank"">
                                </div>
                                <h3 class=""payment-item-name"">Agribank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""AnBinhBank"" class=""payment-item-image"">
                                    <img src=""/image/anbinhbank.jpg"" alt=""AnBinhBank"">
                                </div>
                                <h3 class=""payment-item-name"">AnBinhBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""BIDV"" class=""payment-item-image"">
                                    <");
                WriteLiteral(@"img src=""/image/bidv.jpg"" alt=""BIDV"">
                                </div>
                                <h3 class=""payment-item-name"">BIDV</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""BacABank"" class=""payment-item-image"">
                                    <img src=""/image/BacABank.jpg"" alt=""BacABank"">
                                </div>
                                <h3 class=""payment-item-name"">Bac A Bank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""BaovietBank"" class=""payment-item-image"">
                                    <img src=""/image/BaovietBank.jpg"" alt=""BaovietBank"">
                                </div>
                                <h3 class=""payment-item-name"">BaovietBank</h3>
                            </li>
                            <li class=""payment-item"">
                          ");
                WriteLiteral(@"      <div id=""EximBank"" class=""payment-item-image"">
                                    <img src=""/image/EximBank.jpg"" alt=""EximBank"">
                                </div>
                                <h3 class=""payment-item-name"">EximBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""GPBank"" class=""payment-item-image"">
                                    <img src=""/image/GPBank.jpg"" alt=""GPBank"">
                                </div>
                                <h3 class=""payment-item-name"">GPBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""HDBank"" class=""payment-item-image"">
                                    <img src=""/image/HDBank.jpg"" alt=""HDBank"">
                                </div>
                                <h3 class=""payment-item-name"">HDBank</h3>
                            </li>
        ");
                WriteLiteral(@"                    <li class=""payment-item"">
                                <div id=""KienLongBank"" class=""payment-item-image"">
                                    <img src=""/image/KienLongBank.jpg"" alt=""KienLongBank"">
                                </div>
                                <h3 class=""payment-item-name"">KienLongBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""LienVietPostBank"" class=""payment-item-image"">
                                    <img src=""/image/LienVietPostBank.jpg"" alt=""LienVietPostBank"">
                                </div>
                                <h3 class=""payment-item-name"">LienVietPostBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""MBBank"" class=""payment-item-image"">
                                    <img src=""/image/MBBank.jpg"" alt=""MBBank"">
                             ");
                WriteLiteral(@"   </div>
                                <h3 class=""payment-item-name"">MBBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""MaritimeBank"" class=""payment-item-image"">
                                    <img src=""/image/maritimebank2.jpg"" alt=""MaritimeBank"">
                                </div>
                                <h3 class=""payment-item-name"">MaritimeBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""NamABank"" class=""payment-item-image"">
                                    <img src=""/image/NamABank.jpg"" alt=""NamABank"">
                                </div>
                                <h3 class=""payment-item-name"">NamABank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""NamVietBank"" class=""payment-item-image"">
      ");
                WriteLiteral(@"                              <img src=""/image/NamVietBank.jpg"" alt=""NamVietBank"">
                                </div>
                                <h3 class=""payment-item-name"">NamVietBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""OceanBank"" class=""payment-item-image"">
                                    <img src=""/image/OceanBank.jpg"" alt=""OceanBank"">
                                </div>
                                <h3 class=""payment-item-name"">OceanBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""PhuongDong"" class=""payment-item-image"">
                                    <img src=""/image/PhuongDong.jpg"" alt=""PhuongDong"">
                                </div>
                                <h3 class=""payment-item-name"">PhuongDong</h3>
                            </li>
                            <li");
                WriteLiteral(@" class=""payment-item"">
                                <div id=""PublicBank"" class=""payment-item-image"">
                                    <img src=""/image/PublicBank.jpg"" alt=""PublicBank"">
                                </div>
                                <h3 class=""payment-item-name"">PublicBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""SCB"" class=""payment-item-image"">
                                    <img src=""/image/SCB.jpg"" alt=""SCB"">
                                </div>
                                <h3 class=""payment-item-name"">SCB</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""SHB"" class=""payment-item-image"">
                                    <img src=""/image/SHB.jpg"" alt=""SHB"">
                                </div>
                                <h3 class=""payment-item-name"">SHB</h3>
         ");
                WriteLiteral(@"                   </li>
                            <li class=""payment-item"">
                                <div id=""SacomBank"" class=""payment-item-image"">
                                    <img src=""/image/SacomBank.jpg"" alt=""SacomBank"">
                                </div>
                                <h3 class=""payment-item-name"">SacomBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""SeaBank"" class=""payment-item-image"">
                                    <img src=""/image/SeaBank.jpg"" alt=""SeaBank"">
                                </div>
                                <h3 class=""payment-item-name"">SeaBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""TPBank"" class=""payment-item-image"">
                                    <img src=""/image/TPBank.jpg"" alt=""TPBank"">
                                </div>
   ");
                WriteLiteral(@"                             <h3 class=""payment-item-name"">TPBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""Techcombank"" class=""payment-item-image"">
                                    <img src=""/image/Techcombank.jpg"" alt=""Techcombank"">
                                </div>
                                <h3 class=""payment-item-name"">Techcombank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""VIB"" class=""payment-item-image"">
                                    <img src=""/image/VIB.jpg"" alt=""VIB"">
                                </div>
                                <h3 class=""payment-item-name"">VIB</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""VPBank"" class=""payment-item-image"">
                                    <img src=""/ima");
                WriteLiteral(@"ge/VPBank.jpg"" alt=""VPBank"">
                                </div>
                                <h3 class=""payment-item-name"">VPBank</h3>
                            </li>
                            <li class=""payment-item"">
                                <div id=""VRB"" class=""payment-item-image"">
                                    <img src=""/image/VRB.jpg"" alt=""VRB"">
                                </div>
                                <h3 class=""payment-item-name"">VRB</h3>
                            </li>

                        </ul>
                    </div>
                    <div class=""btn-payment"">
                        <div class=""btn btn-access"">
                            <h3>Xác nhận</h3>
                        </div>
                    </div>
                </div>
            </div>

        </main>
    </div>
    <script src=""/lib/jquery-3.5.1.min.js""></script>
    <script src=""/js/page/checkout.js""></script>
    <script src=""/js/page/payment.js""></scrip");
                WriteLiteral("t>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
