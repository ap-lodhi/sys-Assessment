#pragma checksum "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22df1c055ec746c569829eca0b1650389f1ce794"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_EditCompany), @"mvc.1.0.view", @"/Views/Dashboard/EditCompany.cshtml")]
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
#line 1 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\_ViewImports.cshtml"
using Final_Assessment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\_ViewImports.cshtml"
using Final_Assessment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22df1c055ec746c569829eca0b1650389f1ce794", @"/Views/Dashboard/EditCompany.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efec093ad830ef2ceea790690e4ffedc3e8e283a", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_EditCompany : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Final_Assessment.Models.CompanyModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("signupForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22df1c055ec746c569829eca0b1650389f1ce7944355", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>EditCompany</title>
    <link href=""
https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css""
          rel=""stylesheet""
          integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">


    <script src=""
https://code.jquery.com/jquery-3.6.4.min.js""></script>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            align-items: center;
            justify-content: center;
        }

        nav {
            background-color: #0c4da2;
        }

        .nav-link {
            color: white;
        }

            .nav-link:hover {
                color: darkorange;
            }





        button:hover {
            background-color: darkorange;
        }

        span {
            color: red;
        }

        .navbarCenter {
         ");
                WriteLiteral("   display: flex;\r\n            align-items: center;\r\n            justify-content: space-between;\r\n            margin-left: 90px;\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22df1c055ec746c569829eca0b1650389f1ce7946558", async() => {
                WriteLiteral(@"

    <nav class=""navbar navbar-expand-lg "">
        <div class=""container-fluid"">

            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse navbarCenter"">
                <ul class=""navbar-nav "">
                    <li class=""nav-item"">
                        <a class=""nav-link active fs-4"" aria-current=""page"" href=""/Dashboard/Index"">Home</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link fs-4"" href=""#"">Add Company</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link fs-4"" href=""/Dashboard/GetCompanyList"">Company List</a>
                    </li>
                </ul>
          ");
                WriteLiteral("  </div>\r\n            <div>\r\n\r\n            </div>\r\n            <ul class=\"navbar-nav \">\r\n                <li class=\"nav-item\">\r\n                    <p class=\"fs-3 text-white\">");
#nullable restore
#line 87 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
                                          Write(ViewBag.sess);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </li>\r\n            </ul>\r\n\r\n        </div>\r\n    </nav>\r\n\r\n    <div class=\"container w-50 m-auto \">\r\n        <div class=\"w-50 m-auto shadow p-5\">\r\n            <h2 class=\"mt-5\"> Add Company Information </h2>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22df1c055ec746c569829eca0b1650389f1ce7948653", async() => {
                    WriteLiteral("\r\n\r\n                    <input type=\"text\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 2839, "\"", 2864, 1);
#nullable restore
#line 99 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
WriteAttributeValue("", 2847, Model.Company_Id, 2847, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" id=\"companyId\" name=\"companyName\" required>\r\n\r\n                <div class=\"form-group  \">\r\n                    <label for=\"companyName\">Company Name:</label>\r\n                    <input type=\"text\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 3084, "\"", 3110, 1);
#nullable restore
#line 103 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
WriteAttributeValue("", 3092, Model.CompanyName, 3092, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" id=""companyName"" name=""companyName"" required>
                </div>
                <br />
                <div class=""form-group"">
                    <label for=""companyEmail"">Company Email:</label>
                    <input type=""email"" class=""form-control""");
                    BeginWriteAttribute("value", " value=\"", 3379, "\"", 3406, 1);
#nullable restore
#line 108 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
WriteAttributeValue("", 3387, Model.CompanyEmail, 3387, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" id=""companyEmail"" name=""companyEmail"" required>
                </div>
                <br />
                <div class=""form-group"">
                    <label for=""companyURL"">Company URL:</label>
                    <input type=""text"" class=""form-control""");
                    BeginWriteAttribute("value", " value=\"", 3672, "\"", 3697, 1);
#nullable restore
#line 113 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
WriteAttributeValue("", 3680, Model.CompanyURL, 3680, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" id=\"companyURL\" name=\"companyURL\"><br />\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"remark\">Remark:</label>\r\n                    <textarea id=\"remark\" class=\"form-control\" name=\"remark\"> ");
#nullable restore
#line 118 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
                                                                         Write(Model.Remark);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</textarea><br />\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n\r\n                    <label for=\"companyLocation\">Company Location:</label>\r\n                    <input type=\"text\"");
                    BeginWriteAttribute("value", " value=\"", 4160, "\"", 4190, 1);
#nullable restore
#line 124 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
WriteAttributeValue("", 4168, Model.CompanyLocation, 4168, 22, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" id=\"companyLocation\" class=\"form-control\" name=\"companyLocation\"><br />\r\n\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"userId\">User ID:</label>\r\n                    <input type=\"text\" id=\"userId\"");
                    BeginWriteAttribute("value", " value=\"", 4443, "\"", 4464, 1);
#nullable restore
#line 130 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
WriteAttributeValue("", 4451, Model.UserId, 4451, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" name=\"userId\"><br />\r\n\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"phoneNumber\">Phone Number:</label>\r\n                    <input type=\"tel\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 4705, "\"", 4732, 1);
#nullable restore
#line 136 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
WriteAttributeValue("", 4713, Model.Phone_Number, 4713, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" id=""phoneNumber"" name=""phoneNumber""><br />
                    
                </div>

                <div class=""form-group"">

                    <label for=""numberOfEmployees"">Number of Employees:</label>
                    <input type=""number""");
                    BeginWriteAttribute("value", " value=\"", 4991, "\"", 5023, 1);
#nullable restore
#line 143 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
WriteAttributeValue("", 4999, Model.Number_of_Employe, 4999, 24, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" id=\"numberOfEmployees\" name=\"numberOfEmployees\"><br />\r\n\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n\r\n\r\n                    <label for=\"timezone\">Timezone:</label>\r\n                    <input type=\"text\"");
                    BeginWriteAttribute("value", " value=\"", 5275, "\"", 5298, 1);
#nullable restore
#line 151 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
WriteAttributeValue("", 5283, Model.Timezone, 5283, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" id=\"timezone\" name=\"timezone\"><br />\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n\r\n\r\n                    <label for=\"country\">Country:</label>\r\n                    ");
#nullable restore
#line 158 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
               Write(Html.DropDownList("Country", ViewBag.roleDes as SelectList, Model.Country,   new { @class = "form-control", id = "CountryId", onchange = "get_tbl(this.value)" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\r\n\r\n\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n\r\n\r\n                    <label for=\"state\">State:</label>\r\n");
                    WriteLiteral("\r\n                    <select id=\"category\"   class=\"form-select\" onchange=\"get_city(this.value)\">\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22df1c055ec746c569829eca0b1650389f1ce79416367", async() => {
                        WriteLiteral("Select");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 171 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
                           WriteLiteral(Model.State);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\r\n");
#nullable restore
#line 173 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
                         foreach (var item in ViewBag.Statelist)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22df1c055ec746c569829eca0b1650389f1ce79418489", async() => {
                        WriteLiteral(" ");
#nullable restore
#line 175 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
                                                    Write(item.Text);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 175 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
                               WriteLiteral(item.Value);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 176 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </select>\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n\r\n                    <label for=\"city\">City:</label>\r\n");
                    WriteLiteral("\r\n                    <select id=\"city\"  class=\"form-select\">\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22df1c055ec746c569829eca0b1650389f1ce79421065", async() => {
                        WriteLiteral("Select");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 186 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
                           WriteLiteral(Model.City);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\r\n");
#nullable restore
#line 188 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
                         foreach (var item in ViewBag.roleDes2)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22df1c055ec746c569829eca0b1650389f1ce79423185", async() => {
                        WriteLiteral(" ");
#nullable restore
#line 190 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
                                                    Write(item.Text);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 190 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
                               WriteLiteral(item.Value);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 191 "C:\Users\mrapl\source\repos\Final_Assessment\Final_Assessment\Views\Dashboard\EditCompany.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                    </select>

                </div>
                <br />


                <button type=""submit"" id=""submit"" class=""btn btn-primary"">Update</button>
                <p> visit to Compnay <a href=""/Dashboard/GetCompanyList"">List</a> </p>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
    </div>

    <script>
        function get_city(id) {
            console.log(id)
            //debugger;
            $.ajax({
                url: ""/Dashboard/cityfilter?id="" + id,
                type: ""POST"",
                success: function (data) {
                    console.log(""data "", data);
                    var categ = $(""#city"").html("""");
                    categ.append('<option value=""""> Select </option>')
                    if (data != null && data != undefined) {
                        for (var i = 0; i < data.length; i++) {
                            categ.append(""<option value='"" + data[i].cityId + ""'>"" + data[i].cityName + ""</option>"");
                        }
                    }
                },
                error: function (err) {
                    console.error(err.message);
                    return;
                },
            });
        }

    </script>



    <script>
        function get_tbl(id) {
          /");
                WriteLiteral(@"/  console.log(id)
            
            $.ajax({
                url: ""/Dashboard/statefilter?id="" + id,
                type: ""POST"",
                success: function (data) {
                    console.log(""data "", data);
                    var categ = $(""#category"").html("""");
                    categ.append('<option value=""""> Select </option>')
                    if (data != null && data != undefined) {
                        for (var i = 0; i < data.length; i++) {
                            categ.append(""<option value='"" + data[i].stateId + ""'>"" + data[i].stateName + ""</option>"");
                        }
                    }
                },
                error: function (err) {
                    console.error(err.message);
                    return;
                },
            });
        }
    </script>
    <script>


        $(document).ready(function () {

            $(""#submit"").click(function (event) {
                event.preventDefault();
    ");
                WriteLiteral(@"    debugger;
                let obj = {
                    Company_Id: $(""#companyId"").val(),
                    CompanyName: $(""#companyName"").val(),
                    CompanyEmail: $(""#companyEmail"").val(),
                    CompanyURL: $(""#companyURL"").val(),
                    Remark: $(""#remark"").val(),
                    CompanyLocation: $(""#companyLocation"").val(),
                    UserId: $(""#userId"").val(),
                    Phone_Number: $(""#phoneNumber"").val(),
                    Number_of_Employe: $(""#numberOfEmployees"").val(),
                    Timezone: $(""#timezone"").val(),
                    Country: $(""#CountryId"").val(),
                    State: $(""#category"").val(),
                    City: $(""#city"").val(),
                }

                $.ajax({
                    url: ""/Dashboard/UpdateCompany"",
                    type: ""POST"",
                    data: obj,
                    success: function (result) {        

                      ");
                WriteLiteral(@"  if (result.status) {
                            alert(result.message);
                            document.getElementById(""sucmsg"").innerHTML = result['message'];
                            document.getElementById(""signupForm"").reset();
                        } else {
                            alert(result.message);
                            document.getElementById(""sucmsg"").innerHTML = result['message'];
                        }
                    },
                    error: function (err) {
                        console.error(err.message);
                    },
                })
            });


        });

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Final_Assessment.Models.CompanyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
