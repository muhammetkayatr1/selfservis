#pragma checksum "C:\Users\muhammetkaya\source\repos\SelfServisUI\Views\Person\PersonPasswordStepTwo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91380de22817f69f809afb06c4f2a61dc03ec2f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_PersonPasswordStepTwo), @"mvc.1.0.view", @"/Views/Person/PersonPasswordStepTwo.cshtml")]
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
#line 1 "C:\Users\muhammetkaya\source\repos\SelfServisUI\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muhammetkaya\source\repos\SelfServisUI\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muhammetkaya\source\repos\SelfServisUI\Views\_ViewImports.cshtml"
using SelfServisUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91380de22817f69f809afb06c4f2a61dc03ec2f7", @"/Views/Person/PersonPasswordStepTwo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3045b5b636a3c1f71c8ae83913265152b64e4a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_PersonPasswordStepTwo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\muhammetkaya\source\repos\SelfServisUI\Views\Person\PersonPasswordStepTwo.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""fxt-template-animation fxt-template-layout11 loaded"">
    <div class=""container"">
        <div class=""row align-items-center justify-content-center"">
            <div class=""col-lg-12 fxt-bg-color"">
                <div class=""fxt-content"">
                    <div class=""fxt-header"" style=""margin-bottom: 0px"">
                        <img style=""width: 150px; margin-bottom: 20px; border-radius: 100%"" src=""http://coalise.com/public/assets/base/img/content/team/team16.jpg"">
                        <ul class=""fxt-socials"">
                            <li class=""fxt-google"">
                                <div class=""fxt-transformY-50 fxt-transition-delay-6"">

                                    <a class=""b-link border-left"" href=""#"" title=""google""><span>Bilgilerim</span></a>
                                </div>
                            </li>
                            <li class=""fxt-facebook"">
                                <div class=""fxt-transformY-50 fxt-transition-dela");
            WriteLiteral(@"y-8"">
                                    <a class=""b-link border-right"" href=""#"" title=""Facebook""><span>Şifre Değiştirme</span></a>
                                </div>
                            </li>
                        </ul>
                    </div>

                    <div class=""fxt-form"" style=""width: 100%; margin: auto"">
                        <h3 style=""text-align: center"">Şifre Değiştirme</h3>
                        <div class=""fxt-form row"">
                            <div class=""col-lg-6"" style=""overflow-x: auto"">
                                <table class=""table table-bordered"">
                                    <thead>
                                        <tr>
                                            <th style=""text-align: center"" scope=""col"" colspan=""4"">Kişi Bilgileri</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
   ");
            WriteLiteral(@"                                         <th class=""table-size"" scope=""row"">Adı</th>
                                            <td class=""table-size"">Muhammet</td>
                                        </tr>
                                        <tr>
                                            <th class=""table-size"" scope=""row"">Soyadı</th>
                                            <td class=""table-size"">Kaya</td>
                                        </tr>
                                        <tr>
                                            <th class=""table-size"" scope=""row"">Kullanıcı Adı</th>
                                            <td class=""table-size"">123456789</td>
                                        </tr>
                                        <tr>
                                            <th class=""table-size"" scope=""row"">Mail Adresi</th>
                                            <td class=""table-size"">muhammetkaya@halic.edu.tr</td>
                             ");
            WriteLiteral("           </tr>\r\n                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n                            <div class=\"col-lg-6\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91380de22817f69f809afb06c4f2a61dc03ec2f77477", async() => {
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <div class=""fxt-transformY-50 fxt-transition-delay-1"">
                                            <label>Yeni Şifre</label>
                                            <input type=""text"" class=""form-control"" name=""email"" placeholder=""Şifrenizi giriniz."" required=""required"">
                                        </div>
                                    </div>
                                    <div class=""form-group"">
                                        <div class=""fxt-transformY-50 fxt-transition-delay-1"">
                                            <label>Yeni Şifre Tekrar</label>
                                            <input type=""text"" class=""form-control"" name=""email"" placeholder=""Tekra şifrenizi giriniz."" required=""required"">
                                        </div>
                                    </div>
                                    <div class=""form-group"">
 ");
                WriteLiteral(@"                                       <div class=""fxt-transformY-50 fxt-transition-delay-4"">
                                            <button type=""submit"" class=""fxt-btn-fill"">Devam Et</button>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""social-size"" style=""margin: auto;"">
                                <div class=""fxt-style-line"">
                                    <div class=""fxt-transformY-50 fxt-transition-delay-5"">
                                        <h3>Sosyal Medya Hesaplarımız</h3>
                                    </div>
                                </div>
                                <ul class=""fxt-socials"">
                                    <li class=""fxt-google"">
                                        <div class=""fxt-transformY-50 fxt-transition-delay-6"">
                                            <a href=""#"" title=""google""><i class=""fab fa-google-plus-g""></i><span>Google +</span></a>
                                        </div>
                                    </li>
                                    <li class=""fxt-twitter"">
                                        <div class=""fxt-transformY-50 fxt-transition-delay-7""");
            WriteLiteral(@">
                                            <a href=""#"" title=""twitter""><i class=""fab fa-twitter""></i><span>Twitter</span></a>
                                        </div>
                                    </li>
                                    <li class=""fxt-facebook"">
                                        <div class=""fxt-transformY-50 fxt-transition-delay-8"">
                                            <a href=""#"" title=""Facebook""><i class=""fab fa-facebook-f""></i><span>Facebook</span></a>
                                        </div>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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