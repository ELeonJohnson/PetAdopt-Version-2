#pragma checksum "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c3f216827bb683b523ebceb37f7ebdcf48813c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dogs_Delete), @"mvc.1.0.view", @"/Views/Dogs/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dogs/Delete.cshtml", typeof(AspNetCore.Views_Dogs_Delete))]
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
#line 1 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\_ViewImports.cshtml"
using PetAdopt;

#line default
#line hidden
#line 2 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\_ViewImports.cshtml"
using PetAdopt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c3f216827bb683b523ebceb37f7ebdcf48813c6", @"/Views/Dogs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ead564819bb3f119d0c0c2dad59db942a70379", @"/Views/_ViewImports.cshtml")]
    public class Views_Dogs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PetAdopt.Models.Dog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles/Dog/DeleteStyling.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/back.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/dog-ad-1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/dog-ad-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/dog-ad-3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(69, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(73, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c3f216827bb683b523ebceb37f7ebdcf48813c67102", async() => {
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
            EndContext();
            BeginContext(140, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(145, 53, true);
            WriteLiteral("\r\n\r\n<h3>Are you sure you want to <span>delete</span> ");
            EndContext();
            BeginContext(199, 10, false);
#line 9 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                            Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(209, 101, true);
            WriteLiteral("?</h3>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-9\">\r\n        <div id=\"back-link\">\r\n            ");
            EndContext();
            BeginContext(310, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c3f216827bb683b523ebceb37f7ebdcf48813c68996", async() => {
                BeginContext(332, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c3f216827bb683b523ebceb37f7ebdcf48813c69259", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(363, 16, true);
                WriteLiteral(" Back To Results");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(383, 143, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <div id=\"dogs-img\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 526, "\"", 591, 2);
            WriteAttributeValue("", 532, "data:image/jpeg;base64,", 532, 23, true);
#line 20 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
WriteAttributeValue("", 555, Convert.ToBase64String(Model.Image), 555, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(592, 253, true);
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <h2 class=\"pet-h\">Facts About Me</h2>\r\n\r\n        <div id=\"pet-facts\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <h4>Breed - <span>");
            EndContext();
            BeginContext(846, 36, false);
#line 29 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                 Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(882, 52, true);
            WriteLiteral("</span></h4>\r\n                    <h4>Color - <span>");
            EndContext();
            BeginContext(935, 37, false);
#line 30 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                 Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
            EndContext();
            BeginContext(972, 50, true);
            WriteLiteral("</span></h4>\r\n                    <h4>Age - <span>");
            EndContext();
            BeginContext(1023, 35, false);
#line 31 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 115, true);
            WriteLiteral("</span></h4>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <h4>Size - <span>");
            EndContext();
            BeginContext(1174, 36, false);
#line 34 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 53, true);
            WriteLiteral("</span></h4>\r\n                    <h4>Gender - <span>");
            EndContext();
            BeginContext(1264, 38, false);
#line 35 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                  Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 232, true);
            WriteLiteral("</span></h4>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <h2 class=\"pet-h\" id=\"info-h\">My Info</h2>\r\n\r\n        <div id=\"pet-info\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n");
            EndContext();
#line 46 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                     if (Model.RecentCheckup == true)
                    {

#line default
#line hidden
            BeginContext(1610, 31, true);
            WriteLiteral("<h4 class=\"text-success\"><span>");
            EndContext();
            BeginContext(1642, 45, false);
#line 47 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                               Write(Html.DisplayFor(model => model.RecentCheckup));

#line default
#line hidden
            EndContext();
            BeginContext(1687, 29, true);
            WriteLiteral("</span> - Recent Checkup</h4>");
            EndContext();
#line 47 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                                               }
                else
                {

#line default
#line hidden
            BeginContext(1758, 30, true);
            WriteLiteral("<h4 class=\"text-danger\"><span>");
            EndContext();
            BeginContext(1789, 45, false);
#line 49 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                          Write(Html.DisplayFor(model => model.RecentCheckup));

#line default
#line hidden
            EndContext();
            BeginContext(1834, 29, true);
            WriteLiteral("</span> - Recent Checkup</h4>");
            EndContext();
#line 49 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                                          }

#line default
#line hidden
            BeginContext(1866, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                     if (Model.Trained == true)
                    {

#line default
#line hidden
            BeginContext(1938, 31, true);
            WriteLiteral("<h4 class=\"text-success\"><span>");
            EndContext();
            BeginContext(1970, 39, false);
#line 52 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                               Write(Html.DisplayFor(model => model.Trained));

#line default
#line hidden
            EndContext();
            BeginContext(2009, 22, true);
            WriteLiteral("</span> - Trained</h4>");
            EndContext();
#line 52 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                                  }
                else
                {

#line default
#line hidden
            BeginContext(2073, 30, true);
            WriteLiteral("<h4 class=\"text-danger\"><span>");
            EndContext();
            BeginContext(2104, 39, false);
#line 54 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                          Write(Html.DisplayFor(model => model.Trained));

#line default
#line hidden
            EndContext();
            BeginContext(2143, 22, true);
            WriteLiteral("</span> - Trained</h4>");
            EndContext();
#line 54 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                             }

#line default
#line hidden
            BeginContext(2168, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 56 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                     if (Model.Neutered == true)
                    {

#line default
#line hidden
            BeginContext(2241, 31, true);
            WriteLiteral("<h4 class=\"text-success\"><span>");
            EndContext();
            BeginContext(2273, 40, false);
#line 57 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                               Write(Html.DisplayFor(model => model.Neutered));

#line default
#line hidden
            EndContext();
            BeginContext(2313, 23, true);
            WriteLiteral("</span> - Neutered</h4>");
            EndContext();
#line 57 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                                    }
                else
                {

#line default
#line hidden
            BeginContext(2378, 30, true);
            WriteLiteral("<h4 class=\"text-danger\"><span>");
            EndContext();
            BeginContext(2409, 40, false);
#line 59 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                          Write(Html.DisplayFor(model => model.Neutered));

#line default
#line hidden
            EndContext();
            BeginContext(2449, 23, true);
            WriteLiteral("</span> - Neutered</h4>");
            EndContext();
#line 59 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                               }

#line default
#line hidden
            BeginContext(2475, 64, true);
            WriteLiteral("                </div>\r\n                <div class=\"col-md-6\">\r\n");
            EndContext();
#line 62 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                     if (Model.Declawed == true)
                    {

#line default
#line hidden
            BeginContext(2610, 31, true);
            WriteLiteral("<h4 class=\"text-success\"><span>");
            EndContext();
            BeginContext(2642, 40, false);
#line 63 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                               Write(Html.DisplayFor(model => model.Declawed));

#line default
#line hidden
            EndContext();
            BeginContext(2682, 23, true);
            WriteLiteral("</span> - Declawed</h4>");
            EndContext();
#line 63 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                                    }
                else
                {

#line default
#line hidden
            BeginContext(2747, 30, true);
            WriteLiteral("<h4 class=\"text-danger\"><span>");
            EndContext();
            BeginContext(2778, 40, false);
#line 65 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                          Write(Html.DisplayFor(model => model.Declawed));

#line default
#line hidden
            EndContext();
            BeginContext(2818, 23, true);
            WriteLiteral("</span> - Declawed</h4>");
            EndContext();
#line 65 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                               }

#line default
#line hidden
            BeginContext(2844, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 67 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                     if (Model.GoodWithDogs == true)
                    {

#line default
#line hidden
            BeginContext(2921, 31, true);
            WriteLiteral("<h4 class=\"text-success\"><span>");
            EndContext();
            BeginContext(2953, 44, false);
#line 68 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                               Write(Html.DisplayFor(model => model.GoodWithDogs));

#line default
#line hidden
            EndContext();
            BeginContext(2997, 35, true);
            WriteLiteral("</span> - Good With Other Dogs</h4>");
            EndContext();
#line 68 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                                                    }
                else
                {

#line default
#line hidden
            BeginContext(3074, 30, true);
            WriteLiteral("<h4 class=\"text-danger\"><span>");
            EndContext();
            BeginContext(3105, 44, false);
#line 70 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                          Write(Html.DisplayFor(model => model.GoodWithDogs));

#line default
#line hidden
            EndContext();
            BeginContext(3149, 35, true);
            WriteLiteral("</span> - Good With Other Dogs</h4>");
            EndContext();
#line 70 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                                               }

#line default
#line hidden
            BeginContext(3187, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 71 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                     if (Model.GoodWithCats == true)
                    {

#line default
#line hidden
            BeginContext(3262, 31, true);
            WriteLiteral("<h4 class=\"text-success\"><span>");
            EndContext();
            BeginContext(3294, 44, false);
#line 72 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                               Write(Html.DisplayFor(model => model.GoodWithCats));

#line default
#line hidden
            EndContext();
            BeginContext(3338, 29, true);
            WriteLiteral("</span> - Good With Cats</h4>");
            EndContext();
#line 72 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                                              }
                else
                {

#line default
#line hidden
            BeginContext(3409, 30, true);
            WriteLiteral("<h4 class=\"text-danger\"><span>");
            EndContext();
            BeginContext(3440, 44, false);
#line 74 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                          Write(Html.DisplayFor(model => model.GoodWithCats));

#line default
#line hidden
            EndContext();
            BeginContext(3484, 29, true);
            WriteLiteral("</span> - Good With Cats</h4>");
            EndContext();
#line 74 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                                         }

#line default
#line hidden
            BeginContext(3516, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 76 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                     if (Model.GoodWithKids == true)
                    {

#line default
#line hidden
            BeginContext(3593, 31, true);
            WriteLiteral("<h4 class=\"text-success\"><span>");
            EndContext();
            BeginContext(3625, 44, false);
#line 77 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                               Write(Html.DisplayFor(model => model.GoodWithKids));

#line default
#line hidden
            EndContext();
            BeginContext(3669, 35, true);
            WriteLiteral("</span> - Good With Other Kids</h4>");
            EndContext();
#line 77 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                                                    }
                else
                {

#line default
#line hidden
            BeginContext(3746, 30, true);
            WriteLiteral("<h4 class=\"text-danger\"><span>");
            EndContext();
            BeginContext(3777, 44, false);
#line 79 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                          Write(Html.DisplayFor(model => model.GoodWithKids));

#line default
#line hidden
            EndContext();
            BeginContext(3821, 35, true);
            WriteLiteral("</span> - Good With Other Kids</h4>");
            EndContext();
#line 79 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
                                                                                                                               }

#line default
#line hidden
            BeginContext(3859, 174, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <h2 class=\"pet-h\">Food Requirements</h2>\r\n        <div id=\"food-req\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(4034, 39, false);
#line 87 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.FoodReq));

#line default
#line hidden
            EndContext();
            BeginContext(4073, 156, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n\r\n        <h2 class=\"pet-h\">Habitat Requirements</h2>\r\n        <div id=\"habitat-req\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(4230, 42, false);
#line 94 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.HabitatReq));

#line default
#line hidden
            EndContext();
            BeginContext(4272, 216, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-3\">\r\n        <div id=\"img-1\" class=\"dog-ad\">\r\n            <a href=\"https://www.amazon.in/Pedigree-Biscrok-Biscuits-Treats-Chicken/dp/B07SCDWNP7\">");
            EndContext();
            BeginContext(4488, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c3f216827bb683b523ebceb37f7ebdcf48813c630242", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4523, 179, true);
            WriteLiteral("</a>\r\n        </div>\r\n\r\n        <div id=\"img-2\" class=\"dog-ad\">\r\n            <a href=\"http://www.havesippywilltravel.com/2015/10/best-ways-to-pamper-your-pup-furryfoodie-ad.html\">");
            EndContext();
            BeginContext(4702, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c3f216827bb683b523ebceb37f7ebdcf48813c631604", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4737, 115, true);
            WriteLiteral("</a>\r\n        </div>\r\n\r\n        <div id=\"img-3\" class=\"dog-ad\">\r\n            <a href=\"https://www.petpremium.com/\">");
            EndContext();
            BeginContext(4852, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c3f216827bb683b523ebceb37f7ebdcf48813c632902", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4887, 46, true);
            WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(4933, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c3f216827bb683b523ebceb37f7ebdcf48813c634129", async() => {
                BeginContext(4959, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4965, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c3f216827bb683b523ebceb37f7ebdcf48813c634517", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 115 "C:\Users\Enoch\Desktop\Projects For Portfolio\PetAdopt\PetAdopt\Views\Dogs\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DogId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5004, 88, true);
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> <span>|</span>\r\n    ");
                EndContext();
                BeginContext(5092, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c3f216827bb683b523ebceb37f7ebdcf48813c636441", async() => {
                    BeginContext(5114, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5130, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5139, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PetAdopt.Models.Dog> Html { get; private set; }
    }
}
#pragma warning restore 1591
