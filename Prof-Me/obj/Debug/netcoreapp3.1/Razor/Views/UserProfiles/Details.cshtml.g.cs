#pragma checksum "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "193322009931ec039598f424cf115014cb755a6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserProfiles_Details), @"mvc.1.0.view", @"/Views/UserProfiles/Details.cshtml")]
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
#line 1 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\_ViewImports.cshtml"
using Prof_Me;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\_ViewImports.cshtml"
using Prof_Me.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"193322009931ec039598f424cf115014cb755a6e", @"/Views/UserProfiles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a40f39b0a18b3a3948b417ecefcb8d4481cb6cc5", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfiles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Prof_Me.Data.Models.UserProfile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <img class=\"cover-img\"");
            BeginWriteAttribute("src", " src=\"", 212, "\"", 273, 1);
#nullable restore
#line 10 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
WriteAttributeValue("", 218, Url.Content(" /images/userimage/" + @Model.CoverImage), 218, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Responsive image\">\r\n        <img class=\"profile-img\"");
            BeginWriteAttribute("src", " src=\"", 332, "\"", 395, 1);
#nullable restore
#line 11 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
WriteAttributeValue("", 338, Url.Content(" /images/userimage/" + @Model.ProfileImage), 338, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Responsive image\">\r\n    </div>\r\n    <div class=\"row usr-dtl\">\r\n        <div class=\"usr-name\">\r\n            ");
#nullable restore
#line 15 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
       Write(Html.DisplayFor(model => model.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.LName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 15 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                                                      Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </div>\r\n        <div class=\"usr-ofc\">\r\n            <p>\r\n                ");
#nullable restore
#line 19 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /> ");
#nullable restore
#line 19 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                        Write(Html.DisplayFor(model => model.Post));

#line default
#line hidden
#nullable disable
            WriteLiteral(" at <b>");
#nullable restore
#line 19 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                                                                    Write(Html.DisplayFor(model => model.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br />\r\n                Studied at <b>");
#nullable restore
#line 20 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Universiy));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br />\r\n                ");
#nullable restore
#line 21 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
           Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                Age : ");
#nullable restore
#line 22 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                 Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
            
        </div>

    </div>
    <div>

        <div class=""card mb-3"">
            <div class=""card-header d-flex justify-content-between"">
                Experience
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""main-timeline4"">
");
#nullable restore
#line 38 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                             foreach (var experience in Model.Experiences)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"timeline\">\r\n                                    <div class=\"timeline-content\">\r\n                                        <span class=\"year\">");
#nullable restore
#line 42 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                      Write(Html.DisplayFor(modelitem => experience.Leave.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <div class=\"inner-content\">\r\n                                            <h3 class=\"title\">");
#nullable restore
#line 44 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                         Write(Html.DisplayFor(modelitem => experience.PostType));

#line default
#line hidden
#nullable disable
            WriteLiteral(" At ");
#nullable restore
#line 44 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                                                                               Write(Html.DisplayFor(modelitem => experience.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Left)</h3>\r\n                                            <p class=\"description\">\r\n                                                ");
#nullable restore
#line 46 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                           Write(Html.DisplayFor(modelitem => experience.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <div class=""timeline"">
                                    <div class=""timeline-content"">
                                        <span class=""year"">");
#nullable restore
#line 53 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                      Write(Html.DisplayFor(modelitem => experience.Join.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <div class=\"inner-content\">\r\n                                            <h3 class=\"title\">");
#nullable restore
#line 55 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                         Write(Html.DisplayFor(modelitem => experience.PostType));

#line default
#line hidden
#nullable disable
            WriteLiteral(" At ");
#nullable restore
#line 55 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                                                                               Write(Html.DisplayFor(modelitem => experience.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Join)</h3>\r\n                                            <p class=\"description\">\r\n                                                ");
#nullable restore
#line 57 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                           Write(Html.DisplayFor(modelitem => experience.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 62 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div>
        <div class=""card mb-3"">
            <div class=""card-header d-flex justify-content-between"">
                Education
            </div>
            <div class=""card-body"">
                <div class=""row"">
");
#nullable restore
#line 79 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                     foreach (var education in Model.Educations)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card  m-4\" style=\"width: 18rem;\">\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
#nullable restore
#line 83 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                  Write(Html.DisplayFor(modelitem => education.Level));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 84 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                                     Write(Html.DisplayFor(modelitem => education.EName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <p class=\"card-text\">Studied from ");
#nullable restore
#line 85 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                             Write(Html.DisplayFor(modelitem => education.Join.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 85 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                                                                                   Write(Html.DisplayFor(modelitem => education.Leave.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 89 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
    <div>
        <div class=""card mb-3"">
            <div class=""card-header d-flex justify-content-between"">
                Skills
            </div>
            <div class=""card-body"">
                <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 101 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                     foreach (var skills in Model.Skills)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">");
#nullable restore
#line 103 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                               Write(Html.DisplayFor(modelitem => skills.SkillName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 104 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
        </div>
    </div>
    <div>
        <div class=""card mb-3"">
            <div class=""card-header d-flex justify-content-between"">
                Accomplishment
            </div>
            <div class=""card-body"">
                <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 116 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                     foreach (var accomplishmet in Model.Accomplishments)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">");
#nullable restore
#line 118 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                               Write(Html.DisplayFor(modelitem => accomplishmet.CertificateName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 118 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                                                                                             Write(Html.DisplayFor(modelitem => accomplishmet.GotDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</li>\r\n");
#nullable restore
#line 119 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
        </div>
    </div>
    <div>
        <div class=""card mb-3"">
            <div class=""card-header d-flex justify-content-between"">
                Language
            </div>
            <div class=""card-body"">
                <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 131 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                     foreach (var language in Model.Languages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">");
#nullable restore
#line 133 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                                               Write(Html.DisplayFor(modelitem => language.LanguageName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 134 "E:\Ashesh\DotNetCore Learining\Prof-Me\Prof-Me\Views\UserProfiles\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Prof_Me.Data.Models.UserProfile> Html { get; private set; }
    }
}
#pragma warning restore 1591
