#pragma checksum "C:\Users\admin\Desktop\eProject\eProject1\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f8aaaee27bc4c26734f0484bab2c4922d8d61d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\eProject\eProject1\Views\_ViewImports.cshtml"
using eProject1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\eProject\eProject1\Views\_ViewImports.cshtml"
using eProject1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f8aaaee27bc4c26734f0484bab2c4922d8d61d0", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a7a27d3f1a9f42311cb2ad468419c354f16dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("body-wrapper"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!DOCTYPE html>
<html lang=""en"">

<!-- Mirrored from themes.iamabdus.com/royal/1.3/index.html by HTTrack Website Copier/3.x [XR&CO'2014], Wed, 25 Sep 2019 12:12:09 GMT -->
<!-- Added by HTTrack -->
<meta http-equiv=""content-type"" content=""text/html;charset=utf-8"" /><!-- /Added by HTTrack -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f8aaaee27bc4c26734f0484bab2c4922d8d61d05055", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Home</title>

    <!-- PLUGINS CSS STYLE -->
    <link rel=""icon"" type=""image/png"" href=""/home/img/download.png"">
    <link href=""/home/plugins/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""/home/plugins/selectbox/select_option1.css"">
    <link rel=""stylesheet"" href=""/home/plugins/font-awesome/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""/home/plugins/flexslider/flexslider.css"" type=""text/css"" media=""screen"" />
    <link rel=""stylesheet"" href=""/home/plugins/calender/fullcalendar.min.css"">
    <link rel=""stylesheet"" href=""/home/plugins/animate.css"">
    <link rel=""stylesheet"" href=""/home/plugins/pop-up/magnific-popup.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/home/plugins/rs-plugin/css/settings.css"" media=""screen"">
    <link rel=""stylesheet"" type=""text/css"" href=");
                WriteLiteral(@"""/home/plugins/owl-carousel/owl.carousel.css"" media=""screen"">

    <!-- GOOGLE FONT -->
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,600,600italic,400italic,700' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,700' rel='stylesheet' type='text/css'>

    <!-- CUSTOM CSS -->
    <link rel=""stylesheet"" href=""/home/css/style.css"">
    <link rel=""stylesheet"" href=""/home/css/default.css"" id=""option_color"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1f8aaaee27bc4c26734f0484bab2c4922d8d61d06944", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1f8aaaee27bc4c26734f0484bab2c4922d8d61d08122", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src=""https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js""></script>
    <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
    <![endif]-->

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f8aaaee27bc4c26734f0484bab2c4922d8d61d010388", async() => {
                WriteLiteral(@"

    <div class=""main_wrapper"">

        <header class=""header-wrapper"">

            <div class=""header clearfix"">
                <nav class=""navbar navbar-main navbar-default"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-xs-12"">
                                <div class=""header_inner"">

                                    <!-- Brand and toggle get grouped for better mobile display -->
                                    <div class=""navbar-header"">
                                        <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#main-nav"" aria-expanded=""false"">
                                            <span class=""sr-only"">Toggle navigation</span>
                                            <span class=""icon-bar""></span>
                                            <span class=""icon-bar""></span>
                                            <span class=""");
                WriteLiteral("icon-bar\"></span>\r\n                                        </button>\r\n                                        <a class=\"navbar-brand logo clearfix\" href=\"/\"><img src=\"/home/img/download.png\" style=\"width:100px\"");
                BeginWriteAttribute("alt", " alt=\"", 3580, "\"", 3586, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-responsive"" /></a>
                                    </div>

                                    <!-- Collect the nav links, forms, and other content for toggling -->
                                    <div class=""collapse navbar-collapse"" id=""main-nav"">
                                        <ul class=""nav navbar-nav navbar-right"">
                                            <li class=""active dropdown"">
                                                <a href=""/"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Home</a>

                                            </li>
                                            <li class="" dropdown"">
                                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">News</a>
                                                <ul class=""dropdown-menu"">
                                                ");
                WriteLiteral(@"    <li class=""dropdown"">
                                                        <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Events</a>
                                                        <ul class=""dropdown-menu"">
                                                            <li><a href=""#"">Meetings</a></li>
                                                            <li><a href=""#"">Games</a></li>
                                                            <li><a href=""#"">Competitions</a></li>
                                                        </ul>
                                                    </li>
                                                    <li class=""dropdown"">
                                                        <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Events Upcoming</a>
                                                     ");
                WriteLiteral(@"   <ul class=""dropdown-menu"">
                                                            <li><a href=""#"">Meetings</a></li>
                                                            <li><a href=""#"">Games</a></li>
                                                            <li><a href=""#"">Competitions</a></li>
                                                        </ul>
                                                    </li>

                                                    <li class=""dropdown"">
                                                        <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Recent Events </a>
                                                        <ul class=""dropdown-menu"">
                                                            <li><a href=""#"">Meetings</a></li>
                                                            <li><a href=""#"">Games</a></li>
                                             ");
                WriteLiteral(@"               <li><a href=""#"">Competitions</a></li>
                                                        </ul>
                                                    </li>

                                                </ul>
                                            </li>

                                            <li class="" dropdown"">
                                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Contact Us</a>

                                            </li>
                                            <li class="" dropdown"">
                                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">FAQ</a>

                                            </li>
                                            <li class=""apply_now""><a href=""#"">Login</a></li>
                                        </ul>
  ");
                WriteLiteral(@"                                  </div><!-- navbar-collapse -->

                                </div>
                            </div>
                        </div>
                    </div><!-- /.container -->
                </nav><!-- navbar -->
            </div>
        </header>






        <div class=""mainContent clearfix"">
            <div class=""container"">
                <div class=""row clearfix"">

                    <div class=""col-sm-8 col-xs-12"">
                        ");
#nullable restore
#line 135 "C:\Users\admin\Desktop\eProject\eProject1\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div><!-- col-sm-8 col-xs-12 -->



                </div><!-- row clearfix -->
            </div><!-- container -->
        </div><!-- mainContent -->
        <!--FOOTER-->
        <footer class=""footer-v1"">
            <div class=""menuFooter clearfix"">
                <div class=""container"">
                    <div class=""row clearfix"">

                        <div class=""col-sm-3 col-xs-6"">
                            <ul class=""menuLink"">
                                <li><a href=""#"">About M E E</a></li>

                                <li><a href=""#"">Staff Members</a></li>
                                <li><a href=""#"">Why Choose Us?</a></li>
                            </ul>
                        </div><!-- col-sm-3 col-xs-6 -->

                        <div class=""col-sm-3 col-xs-6 borderLeft"">
                            <ul class=""menuLink"">
                                <li><a href=""course-fullwidth.html"">All Courses</a></li>
                ");
                WriteLiteral(@"                <li><a href=""buying-steps.html"">Admission</a></li>
                                <li><a href=""photo-gallery3col.html"">Photo Gallery</a></li>
                                <li><a href=""international_students.html"">International Students</a></li>
                            </ul>
                        </div><!-- col-sm-3 col-xs-6 -->

                        <div class=""col-sm-3 col-xs-6 borderLeft"">
                            <div class=""footer-address"">
                                <h5>Location:</h5>
                                <address>
                                    FPT Aptech<br>
                                    590 Cach Mang Thang 8 St.<br>
                                    Ho Chi Minh City
                                </address>
                                <a href=""#""><span class=""place""><i class=""fa fa-map-marker""></i>Main Location</span></a>
                            </div>
                        </div><!-- col-sm-3 col-xs-6 -->

     ");
                WriteLiteral(@"                   <div class=""col-sm-3 col-xs-6 borderLeft"">
                            <div class=""socialArea"">
                                <h5>Find us on:</h5>
                                <ul class=""list-inline "">
                                    <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-pinterest-p""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-flickr""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-youtube-play""></i></a></li>
                                </ul>
                            </div><!-- social -->
                            <div class=""contactNo"">
                                <h5>Call us on:</h5>
                                ");
                WriteLiteral(@"<h3>012-3434-456768</h3>
                            </div><!-- contactNo -->
                        </div><!-- col-sm-3 col-xs-6 -->

                    </div><!-- row -->
                </div><!-- container -->
            </div><!-- menuFooter -->

            <div class=""footer clearfix"">
                <div class=""container"">
                    <div class=""row clearfix"">
                        <div class=""col-sm-6 col-xs-12 copyRight"">
                            <p>© 2016 Copyright Royal College Bootstrap Template by <a href=""http://www.iamabdus.com/"">Abdus</a></p>
                        </div><!-- col-sm-6 col-xs-12 -->
                        <div class=""col-sm-6 col-xs-12 privacy_policy"">
                            <a href=""contact-us.html"">Contact us</a>
                            <a href=""privacy-policy.html"">Privacy Policy</a>
                        </div><!-- col-sm-6 col-xs-12 -->
                    </div><!-- row clearfix -->
                </div><!-- container --");
                WriteLiteral(@">
            </div><!-- footer -->
        </footer>

    </div> 

    <!-- JQUERY SCRIPTS -->
    <script src=""/home/plugins/jquery/jquery-1.11.1.min.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugins/bootstrap/js/bootstrap.min.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugins/flexslider/jquery.flexslider.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugins/rs-plugin/js/jquery.themepunch.tools.min.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugins/rs-plugin/js/jquery.themepunch.revolution.min.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugins/selectbox/jquery.selectbox-0.1.3.min.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugins/pop-up/jquery.magnific-popup.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugin");
                WriteLiteral(@"s/animation/waypoints.min.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugins/count-up/jquery.counterup.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugins/animation/wow.min.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugins/animation/moment.min.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugins/calender/fullcalendar.min.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugins/owl-carousel/owl.carousel.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugins/timer/jquery.syotimer.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/plugins/smoothscroll/SmoothScroll.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""/home/js/custom.js"" type=""97518310829943113b39ce84-text/javascript""></script>

    <link href");
                WriteLiteral(@"=""/home/options/optionswitch.css"" rel=""stylesheet"">
    <script src=""/home/options/optionswitcher.js"" type=""97518310829943113b39ce84-text/javascript""></script>
    <script src=""../../../ajax.cloudflare.com/cdn-cgi/scripts/95c75768/cloudflare-static/rocket-loader.min.js"" data-cf-settings=""97518310829943113b39ce84-|49""");
                BeginWriteAttribute("defer", " defer=\"", 14679, "\"", 14687, 0);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- Mirrored from themes.iamabdus.com/royal/1.3/index.html by HTTrack Website Copier/3.x [XR&CO\'2014], Wed, 25 Sep 2019 12:12:33 GMT -->\r\n</html>\r\n\r\n");
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
