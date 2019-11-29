#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\FetchLabel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0db802031ad772b10ec632df6e5b44efdfa8fff6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FetchLabel), @"mvc.1.0.view", @"/Views/Shared/FetchLabel.cshtml")]
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
#line 1 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Infrastructure.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Web.Framework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db802031ad772b10ec632df6e5b44efdfa8fff6", @"/Views/Shared/FetchLabel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b0011d9a8909cdacaf42363c4ba3a5683bc0ece", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FetchLabel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\FetchLabel.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>

    if (typeof Xms === 'undefined') {
        Xms = {};

    }
    if (typeof Xms.Fetch === 'undefined') {
        Xms.Fetch = {};
    }
    Xms.Fetch.ConditionOperatorLabel = $.extend({}, Xms.Fetch,{
        Equal: '等于',
        NotEqual: '不等于',
        GreaterThan: '大于',
        LessThan: '小于',
        GreaterEqual: '大于等于',
        LessEqual: '小于等于',
        Like: '包含',
        NotLike: '不包含',
        In: '包含',
        NotIn: '不包含',
        Between: '介于',
        NotBetween: '不介于',
        Null: '不包含数据',
        NotNull: '包含数据',
        Yesterday: '昨天',
        Today: '今天',
        Tomorrow: '',
        Last7Days: '往前7天',
        Next7Days: '往后7天',
        LastWeek: '上周',
        ThisWeek: '本周',
        NextWeek: '下周',
        LastMonth: '上个月',
        ThisMonth: '本月',
        NextMonth: '下个月',
        On: '等于',
        OnOrBefore: '早于(包含当天)',
        OnOrAfter: '晚于(包含当天)',
        LastYear: '去年',
        ThisYear: '今年',
        NextYear: '明年',
        Last");
            WriteLiteral(@"XHours: '最近X小时',
        NextXHours: '往后X小时',
        LastXDays: '最近X天',
        NextXDays: '往后X天',
        LastXWeeks: '最近X周',
        NextXWeeks: '往后X周',
        LastXMonths: '最近X个月',
        NextXMonths: '往后X个月',
        LastXYears: '最近X年',
        NextXYears: '往后X年',
        EqualUserId: '等于当前用户',
        NotEqualUserId: '不等于当前用户',
        EqualBusinessId: '等于当前部门',
        NotEqualBusinessId: '不等于当前部门',
        ChildOf: '下属',
        Mask: '',
        NotMask: '',
        MasksSelect: '',
        Contains: '包含',
        DoesNotContain: '不包含',
        EqualUserLanguage: '等于当前用户语言',
        NotOn: '不等于',
        OlderThanXYears: 'X年以前',
        OlderThanXMonths: 'X个月以前',
        OlderThanXDays: 'X天以前',
        AfterXYears: 'X年以后',
        AfterXMonths: 'X个月以后',
        AfterXDays: 'X天以后',
        BeginsWith: '开头等于',
        DoesNotBeginWith: '开头不等于',
        EndsWith: '结尾等于',
        DoesNotEndWith: '结尾不等于',
        ThisFiscalYear: '当前会计年度',
        ThisFiscalPeriod: '当前会计期");
            WriteLiteral(@"间',
        NextFiscalYear: '下一会计年度',
        NextFiscalPeriod: '下一会计期间',
        LastFiscalYear: '上一会计年度',
        LastFiscalPeriod: '上一会计期间',
        LastXFiscalYears: '过去X个会计年度',
        LastXFiscalPeriods: '过去X个会计期间',
        NextXFiscalYears: '往后X个会计期间',
        NextXFiscalPeriods: '往后X个会计期间',
        InFiscalYear: '在会计年度内',
        InFiscalPeriod: '在会计期间内',
        InFiscalPeriodAndYear: '在会计期间及年度内',
        InOrBeforeFiscalPeriodAndYear: '在会计期间及年度之前',
        InOrAfterFiscalPeriodAndYear: '在会计期间及年度之后',
        EqualUserTeams: '当前用户团队'
    });
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Xms.Web.Framework.Context.IWebAppContext app { get; private set; }
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