#pragma checksum "E:\SVN\Other\demo\wxBusinessBot\wxBot\wxBot\Views\Home\wxBotSendMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06052ee4a668a580c1f4813ea03b66b96232e333"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_wxBotSendMessage), @"mvc.1.0.view", @"/Views/Home/wxBotSendMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/wxBotSendMessage.cshtml", typeof(AspNetCore.Views_Home_wxBotSendMessage))]
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
#line 1 "E:\SVN\Other\demo\wxBusinessBot\wxBot\wxBot\Views\_ViewImports.cshtml"
using wxBot;

#line default
#line hidden
#line 2 "E:\SVN\Other\demo\wxBusinessBot\wxBot\wxBot\Views\_ViewImports.cshtml"
using wxBot.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06052ee4a668a580c1f4813ea03b66b96232e333", @"/Views/Home/wxBotSendMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39f9915a9401930d977f4afd9673cf89733a0678", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_wxBotSendMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/SendText"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("uploadForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\SVN\Other\demo\wxBusinessBot\wxBot\wxBot\Views\Home\wxBotSendMessage.cshtml"
  
    ViewData["Title"] = "wxBotSendMessage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(101, 1726, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12""></div>
</div>
<div class=""row text-center"">
    <div class=""col-md-2"">
    </div>
    <div class=""col-md-3"">
        <h1>消息类型</h1>
    </div>
    <div class=""col-md-3"">
        <div class=""btn-group"">
            <button class=""btn btn-info btn-lg dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                选择消息类型 <span class=""caret""></span>
            </button>
            <ul class=""dropdown-menu"">
                <li>
                    <h2>
                        <strong>
                            <a href=""javascript:void(0);"" data-secID=""Text"" class=""showSection"">Text</a>
                        </strong>
                    </h2>
                </li>
                <li>
                    <h2>
                        <strong>
                            <a href=""javascript:void(0);"" data-secID=""Markdown"" class=""showSection"">Markdown</a>
                        </strong>");
            WriteLiteral(@"
                    </h2>
                </li>
                <li>
                    <h2>
                        <strong>
                            <a href=""javascript:void(0);"" data-secID=""Image"" class=""showSection"">Image</a>
                        </strong>
                    </h2>
                </li>
                <li>
                    <h2>
                        <strong>
                            <a href=""javascript:void(0);"" data-secID=""News"" class=""showSection"">News</a>
                        </strong>
                    </h2>
                </li>
            </ul>
        </div>
    </div>
</div>
<div class=""row  sectionModel"" id=""Text"">
    ");
            EndContext();
            BeginContext(1827, 487, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06052ee4a668a580c1f4813ea03b66b96232e3336821", async() => {
                BeginContext(1877, 44, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"BotUrl\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1921, "\"", 1944, 1);
#line 57 "E:\SVN\Other\demo\wxBusinessBot\wxBot\wxBot\Views\Home\wxBotSendMessage.cshtml"
WriteAttributeValue("", 1929, ViewData["id"], 1929, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1945, 362, true);
                WriteLiteral(@" />
        <div class=""col-md-3"">
            <label>文本内容：</label>
        </div>
        <div class=""col-md-9"">
            <textarea name=""content"" class=""form-control"" style=""width:100%;""></textarea>
        </div>
        <div class=""col-md-12"">
            <button type=""submit"" class=""form-control btn btn-info""  >发送</button>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2314, 589, true);
            WriteLiteral(@"
</div>
<div class=""row  sectionModel"" id=""Markdown"">
   暂不支持
</div>
<div class=""row  sectionModel"" id=""Image"">
    <div class=""col-md-12"" style=""min-height:300px; border:1px solid #808080; border-radius:4px;"" id=""ImgList"">
        <div class="""" style=""border-top:1px solid #808080; position:absolute; bottom:0px;"">
            <div class=""col-md-1 right"">
                submit
            </div>
            <div class=""col-md-1 right"">
                select
            </div>
        </div>
    </div>
    <div class=""col-md-12"">
        <div class="""">
            ");
            EndContext();
            BeginContext(2903, 197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06052ee4a668a580c1f4813ea03b66b96232e33310096", async() => {
                BeginContext(2925, 168, true);
                WriteLiteral("\r\n                上传图片（只支持jpg 和 png ）： <input type=\"file\" name=\"file\" multiple />\r\n                <input type=\"button\" value=\"上传\" onclick=\"doUpload()\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3100, 91, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row  sectionModel\" id=\"News\">\r\n\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3210, 1170, true);
                WriteLiteral(@"
    <script>
        $("".showSection"").click(function () {
            var secID =$(this).attr('data-secID');
          
            //Text  Markdown    Image   News
            $('.sectionModel').hide();
            $('#' + secID).show();
        });


          function doUpload() {
            var formData = new FormData($(""#uploadForm"")[0]);
            $.ajax({
                  url: ""/UploadImages"",
                //beforeSend: function (xhr) {
                //    xhr.setRequestHeader(""XSRF-TOKEN"",
                //        $('input:hidden[name=""__RequestVerificationToken""]').val());
                //},
                type: 'POST',
                data: formData,
                async: false,
                cache: false,
                contentType: false,
                processData: false,
                success: function (returndata) {
                    alert(returndata);
                },
                error: function (returndata) {
                    alert");
                WriteLiteral("(returndata);\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n<style>\r\n    .sectionModel{\r\n        display:none;\r\n    }\r\n</style>\r\n");
                EndContext();
            }
            );
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
