﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using DevTrends.MvcDonutCaching;
    using Frapid.Web;
    
    #line 1 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
    using Frapid.WebsiteBuilder;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Backend/Layout/Shared/NewThemeModal.cshtml")]
    public partial class _Views_Backend_Layout_Shared_NewThemeModal_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Backend_Layout_Shared_NewThemeModal_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"ui modal\"");

WriteLiteral(" id=\"NewThemeModal\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"header\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 4 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
   Write(Resources.AddANewTheme);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui basic segment\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"ui two column very relaxed stackable grid\"");

WriteLiteral(">\r\n\r\n                <div");

WriteLiteral(" class=\"eight wide center aligned column\"");

WriteLiteral(">\r\n\r\n                    <i");

WriteLiteral(" class=\"massive cloud upload green icon\"");

WriteLiteral("></i>\r\n                    <div");

WriteLiteral(" class=\"vpad8\"");

WriteLiteral("></div>\r\n\r\n                    <div");

WriteLiteral(" class=\"ui big header\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 16 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                   Write(Resources.UploadATheme);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"vpad8\"");

WriteLiteral("></div>\r\n\r\n\r\n                    <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"UploadThemeInputFile\"");

WriteLiteral(" class=\"ui basic green button\"");

WriteLiteral(">");

            
            #line 23 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                                                                                   Write(Resources.FromLocalHardDrive);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                        <input");

WriteLiteral(" id=\"UploadThemeInputFile\"");

WriteLiteral("\r\n                               data-handler=\"/dashboard/my/website/themes/uploa" +
"d\"");

WriteLiteral("\r\n                               data-loader-id=\"UploaderSegment\"");

WriteLiteral("\r\n                               class=\"file\"");

WriteLiteral("\r\n                               style=\"display: none\"");

WriteLiteral("\r\n                               type=\"file\"");

WriteLiteral(">\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"vpad16\"");

WriteLiteral("></div>\r\n\r\n                    <div");

WriteLiteral(" class=\"ui horizontal divider\"");

WriteLiteral(">");

            
            #line 34 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                                                  Write(Resources.Or);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                    <div");

WriteLiteral(" class=\"vpad16\"");

WriteLiteral("></div>\r\n\r\n                    <div");

WriteLiteral(" class=\"ui small header\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                                            Write(Resources.DownloadThemeFrom);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"ui fluid labeled input\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"ui basic label\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                                               Write(Resources.Url);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <input");

WriteLiteral(" id=\"RemoteUploadUrl\"");

WriteLiteral(" type=\"url\"");

WriteLiteral(" value=\"http://\"");

WriteLiteral(">\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"vpad8\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" class=\"ui left aligned basic green button\"");

WriteLiteral(" onclick=\"remoteUpload();\"");

WriteLiteral(">");

            
            #line 45 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                                                                                                Write(Resources.DownloadAndInstall);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"ui error padded message\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"ui small header\"");

WriteLiteral("></div>\r\n                    </div>\r\n                </div>\r\n\r\n                <d" +
"iv");

WriteLiteral(" class=\"ui vertical divider\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 54 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
               Write(Resources.Or);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n\r\n\r\n                <div");

WriteLiteral(" class=\"eight wide column\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"ui big header\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 60 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                   Write(Resources.CreateABrandNewTheme);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n                    <form");

WriteLiteral(" class=\"ui padded form\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label>");

            
            #line 65 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                              Write(Resources.ThemeName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"ThemeName\"");

WriteLiteral(" required=\"\"");

WriteLiteral("/>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label>");

            
            #line 69 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                              Write(Resources.Author);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"Author\"");

WriteLiteral(" required=\"\"");

WriteLiteral("/>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label>");

            
            #line 73 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                              Write(Resources.AuthorUrl);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <input");

WriteLiteral(" type=\"url\"");

WriteLiteral(" name=\"AuthorUrl\"");

WriteLiteral("/>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label>");

            
            #line 77 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                              Write(Resources.AuthorEmail);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <input");

WriteLiteral(" type=\"email\"");

WriteLiteral(" name=\"AuthorEmail\"");

WriteLiteral(" required=\"\"");

WriteLiteral("/>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label>");

            
            #line 81 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                              Write(Resources.ThemeConvertedBy);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"ConvertedBy\"");

WriteAttribute("title", Tuple.Create("\r\n                                   title=\"", 3555), Tuple.Create("\"", 3631)
            
            #line 83 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
, Tuple.Create(Tuple.Create("", 3599), Tuple.Create<System.Object, System.Int32>(Resources.ThemeConvertedByTitle
            
            #line default
            #line hidden
, 3599), false)
);

WriteLiteral("/>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label>");

            
            #line 86 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                              Write(Resources.ReleasedOn);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <input");

WriteLiteral(" type=\"date\"");

WriteLiteral(" name=\"ReleasedOn\"");

WriteLiteral("/>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label>");

            
            #line 90 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                              Write(Resources.ThemeVersion);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"Version\"");

WriteLiteral("/>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label>");

            
            #line 94 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                              Write(Resources.Category);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"Category\"");

WriteLiteral("/>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label>");

            
            #line 98 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                              Write(Resources.Responsive);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <div");

WriteLiteral(" class=\"ui toggle checkbox vpad8\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" name=\"Responsive\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" checked=\"checked\"");

WriteLiteral(">\r\n                                <label>&nbsp;</label>\r\n                       " +
"     </div>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label>");

            
            #line 105 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                              Write(Resources.CSSFramework);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"Framework\"");

WriteLiteral("/>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label>");

            
            #line 109 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                              Write(Resources.Tags);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"Tags\"");

WriteAttribute("title", Tuple.Create(" title=\"", 5066), Tuple.Create("\"", 5100)
            
            #line 110 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
, Tuple.Create(Tuple.Create("", 5074), Tuple.Create<System.Object, System.Int32>(Resources.TagsDescription
            
            #line default
            #line hidden
, 5074), false)
);

WriteLiteral("/>\r\n                        </div>\r\n\r\n                        <div");

WriteLiteral(" class=\"ui buttons\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" class=\"ui positive button\"");

WriteLiteral(" onclick=\"createTheme();\"");

WriteLiteral(">");

            
            #line 114 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                                                                                   Write(Resources.LetsGo);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                            <button");

WriteLiteral(" class=\"ui negative button\"");

WriteLiteral(" onclick=\'$(\"#NewThemeModal\").modal(\"hide\");\'");

WriteLiteral(">");

            
            #line 115 "..\..\Views\Backend\Layout\Shared\NewThemeModal.cshtml"
                                                                                                       Write(Resources.Cancel);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </div>\r\n                    </form>\r\n         " +
"       </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591