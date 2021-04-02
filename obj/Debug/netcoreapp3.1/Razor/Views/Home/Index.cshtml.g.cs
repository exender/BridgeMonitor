#pragma checksum "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d888b3e5044d9a02c2cfebee50efd2a5e2ede59f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\_ViewImports.cshtml"
using BridgeMonitor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\_ViewImports.cshtml"
using BridgeMonitor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d888b3e5044d9a02c2cfebee50efd2a5e2ede59f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e88e5ecd32c6a0a78d0d5ca432174d54e2363791", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
  
    bool detail = ViewData["Detail"] != null;
    ViewData["Title"] = detail ? "Détail" : "Prochaine Fermeture";

    BoatModel boat = ViewData["Boat"] as BoatModel;

    string GetTime(DateTime time)
    {
        TimeSpan timeSpan = time.Subtract(DateTime.Now);
        return GetTimeSpan(timeSpan);
    }

    string GetTimeSpan(TimeSpan timeSpan)
    {
        return string.Format(
            "{0} ,{1} {2} et {3}",
            Pluriel(timeSpan.Days, "jour(s)"),
            Pluriel(timeSpan.Hours, "heure(s)"),
            Pluriel(timeSpan.Minutes, "minute(s)"),
            Pluriel(timeSpan.Seconds, "seconde(s)")
            );
    }

    string Pluriel(int amount, string mot)
    {
        return string.Format("{0} {1}{2}", amount, mot, amount > 1 ? "s" : "");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<script>\n    function getTimeCLose() {\n        var date = new Date(toLocalDate(\"");
#nullable restore
#line 32 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
                                    Write(boat.ClosingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""));
        var d = getTime(date - Date.now());
        return pluriel(d.days, ""jour"") +
            "" ,"" +
            pluriel(d.hours, ""heure"") +
            "" "" +
            pluriel(d.minutes, ""minute"") +
            "" et "" +
            pluriel(d.seconds, ""seconde"");
    }

    function getTimeReopen() {
        var date = new Date(toLocalDate(""");
#nullable restore
#line 44 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
                                    Write(boat.ReopeningDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""));
        var d = getTime(date - Date.now());
        return pluriel(d.days, ""jour"") +
            "" ,"" +
            pluriel(d.hours, ""heure"") +
            "" "" +
            pluriel(d.minutes, ""minute"") +
            "" et "" +
            pluriel(d.seconds, ""seconde"");
    }

    function getTime(d) {
        var delta = d / 1000;
        var days = Math.floor(delta / 86400);
        delta -= days * 86400;
        var hours = Math.floor(delta / 3600) % 24;
        delta -= hours * 3600;
        var minutes = Math.floor(delta / 60) % 60;
        delta -= minutes * 60;
        var seconds = Math.floor(delta);

        return {
            days: days,
            hours: hours,
            minutes: minutes,
            seconds: seconds
        };
    }

    function toLocalDate(date) {
        var res = date.split(""/"");
        return res[1] + ""/"" + res[0] + ""/"" + res[2];
    }

    function pluriel(amount, mot) {
        return amount + "" "" + mot + (amount > 1 ? ""s"" : """");
    }
</script>

<h4 class=""m-3"">");
#nullable restore
#line 83 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
            Write(detail ? "Détail" : "Prochaine fermeture");

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n<div class=\"container-md shadow m-3\">\n    <div class=\"card\">\n        \n        <div class=\"card-body\">\n            <div");
            BeginWriteAttribute("class", " class=\"", 2444, "\"", 2452, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"w-25\">\n                    <span>Fermeture :</span>\n                    <p>");
#nullable restore
#line 91 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
                  Write(boat.ClosingDate.ToString("dddd, dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n                <div class=\"w-75 d-flex justify-content-end align-items-center\">\n                    <span>Temps avant fermeture :</span>\n");
#nullable restore
#line 95 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
                     if (boat.ClosingDate.CompareTo(DateTime.Now) > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h6 id=\"CloseCountDown\" class=\"ml-3\">");
#nullable restore
#line 97 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
                                                        Write(GetTime(boat.ClosingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                        <script>
                            setInterval(() => {
                                var countDown = document.getElementById(""CloseCountDown"");
                                countDown.innerText = getTimeCLose();
                            }, 1000);
                        </script>
");
#nullable restore
#line 104 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h6");
            BeginWriteAttribute("class", " class=\"", 3374, "\"", 3382, 0);
            EndWriteAttribute();
            WriteLiteral(">Evenement déjà passé.</h6>\n");
#nullable restore
#line 108 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n            <div>\n                <span>Temps de fermeture :</span>\n                <p>");
#nullable restore
#line 113 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
              Write(GetTimeSpan(boat.ReopeningDate.Subtract(boat.ClosingDate)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n            <div class=\"d-flex justify-content-around\">\n                <div class=\"w-25\">\n                    <span>Réouverture :</span>\n                    <p>");
#nullable restore
#line 118 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
                  Write(boat.ReopeningDate.ToString("dddd, dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n                <div class=\"w-75 d-flex justify-content-end  align-items-center\">\n                    <span>Temps avant réouverture :</span>\n");
#nullable restore
#line 122 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
                     if (boat.ClosingDate.CompareTo(DateTime.Now) > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h6 id=\"ReOpenCountDown\" class=\"ml-3\">");
#nullable restore
#line 124 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
                                                         Write(GetTime(boat.ReopeningDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                        <script>
                            setInterval(() => {
                                var countDown = document.getElementById(""ReOpenCountDown"");
                                countDown.innerText = getTimeReopen();
                            }, 1000);
                        </script>
");
#nullable restore
#line 131 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h6");
            BeginWriteAttribute("class", " class=\"", 4632, "\"", 4640, 0);
            EndWriteAttribute();
            WriteLiteral(">Evenement déjà passé.</h6>\n");
#nullable restore
#line 135 "D:\Telechargement\BridgeMonitor-master\BridgeMonitor-master\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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