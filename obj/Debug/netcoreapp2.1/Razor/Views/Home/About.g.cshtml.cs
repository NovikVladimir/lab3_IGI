#pragma checksum "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c142123a6363e6fa51ab4d27a0109d112ff2d99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\_ViewImports.cshtml"
using lab3;

#line default
#line hidden
#line 2 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\_ViewImports.cshtml"
using lab3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c142123a6363e6fa51ab4d27a0109d112ff2d99", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f221d4f4fa292e12340e1c358a13d1b8ff796fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lab3.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(79, 92, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div>\r\n        <label>Болезни и симптомы</label>\r\n        <table>\r\n");
            EndContext();
#line 10 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
              
                foreach (Disease i in Model.Diseases)
                {

#line default
#line hidden
            BeginContext(261, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(316, 13, false);
#line 14 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
                       Write(i.DiseaseName);

#line default
#line hidden
            EndContext();
            BeginContext(329, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(365, 17, false);
#line 15 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
                       Write(i.DiseaseSymptoms);

#line default
#line hidden
            EndContext();
            BeginContext(382, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 17 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
                }
            

#line default
#line hidden
            BeginContext(450, 102, true);
            WriteLiteral("        </table>\r\n    </div>\r\n    <div>\r\n        <label>Болезнь и лекарство</label>\r\n        <table>\r\n");
            EndContext();
#line 24 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
              
                foreach (Treatment i in Model.Treatmens)
                {

#line default
#line hidden
            BeginContext(645, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(700, 18, false);
#line 28 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
                       Write(i.TreatmentDisease);

#line default
#line hidden
            EndContext();
            BeginContext(718, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(754, 21, false);
#line 29 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
                       Write(i.TreatmentMedication);

#line default
#line hidden
            EndContext();
            BeginContext(775, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 31 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
                }
            

#line default
#line hidden
            BeginContext(843, 99, true);
            WriteLiteral("        </table>\r\n    </div>\r\n    <div>\r\n        <label>Лекарство и доза</label>\r\n        <table>\r\n");
            EndContext();
#line 38 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
              
                foreach (Medicine i in Model.Medicines)
                {

#line default
#line hidden
            BeginContext(1034, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1089, 14, false);
#line 42 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
                       Write(i.MedicineName);

#line default
#line hidden
            EndContext();
            BeginContext(1103, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1139, 16, false);
#line 43 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
                       Write(i.MedicineDosage);

#line default
#line hidden
            EndContext();
            BeginContext(1155, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 45 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1223, 91, true);
            WriteLiteral("        </table>\r\n    </div>\r\n    <div>\r\n        <label>Пациенты</label>\r\n        <table>\r\n");
            EndContext();
#line 52 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
              
                foreach (Patient i in Model.Patients)
                {

#line default
#line hidden
            BeginContext(1404, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1459, 13, false);
#line 56 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
                       Write(i.PatientName);

#line default
#line hidden
            EndContext();
            BeginContext(1472, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1508, 16, false);
#line 57 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
                       Write(i.PatientDisease);

#line default
#line hidden
            EndContext();
            BeginContext(1524, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 59 "Z:\Универ\ИГИ\lab3\lab3(2)\lab3(2)\Views\Home\About.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1592, 38, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lab3.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
