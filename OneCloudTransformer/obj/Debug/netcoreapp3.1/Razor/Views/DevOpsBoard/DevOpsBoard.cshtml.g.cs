#pragma checksum "C:\Users\basvm3\source\repos\CloudTransformer\OneCloudTransformer\Views\DevOpsBoard\DevOpsBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89fe692aaeeb03287ea271e583ff2561bd51300b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DevOpsBoard_DevOpsBoard), @"mvc.1.0.view", @"/Views/DevOpsBoard/DevOpsBoard.cshtml")]
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
#line 1 "C:\Users\basvm3\source\repos\CloudTransformer\OneCloudTransformer\Views\_ViewImports.cshtml"
using OneCloudTransformer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\basvm3\source\repos\CloudTransformer\OneCloudTransformer\Views\_ViewImports.cshtml"
using OneCloudTransformer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89fe692aaeeb03287ea271e583ff2561bd51300b", @"/Views/DevOpsBoard/DevOpsBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b911fba751b71aced80c9652ab89274c53d28d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_DevOpsBoard_DevOpsBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\basvm3\source\repos\CloudTransformer\OneCloudTransformer\Views\DevOpsBoard\DevOpsBoard.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to Azure DevOps DashBoard</h1>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89fe692aaeeb03287ea271e583ff2561bd51300b5229", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
<script type=""text/javascript"">
    jQuery(document).ready(function () {

        $(""#divProjectList"").hide();
        $("".process"").hide();
        $("".divoption"").hide();
        $("".newproject"").hide();
        $("".nextsection"").hide();
        $(""#divExistingProjectList"").hide();
        $("".divresult"").hide();
        $(""#btnprocess"").prop('disabled', true);
        $("".divprojectcreationoptionmain"").hide();
        $("".divAddWorkItems"").hide();
        $("".divSectionExistingWorkItems"").hide();


        function GetToken() {
            jQuery.ajax({
                url: ""https://localhost:44362/api/v1/GetToken"",
                type: ""get"",
                contentType: ""application/json"",
                success: function (result, status, xhr) {
                    $("".divtoken"").html(result);
                },
                error: function (xhr, status, error) {
                    console.log(xhr)
                }
            });
        }

        function GetWork");
            WriteLiteral(@"ItemList(projectName) {
            $(""#divSectionExistingWorkItems"").hide();
            var org = $(""#txtOrg"").val();
            var pat = $(""#txtpat"").val();
            var url = ""https://localhost:44362/api/v1/GetWorkItemList?org="" + org + ""&pat1="" + pat + ""&projectName="" + projectName;
            jQuery.ajax({
                url: url,
                type: ""get"",
                contentType: ""application/json"",
                success: function (result, status, xhr) {
                    //$("".divtoken"").html(result);
                    if (result.length >= 0) {

                        // Display the Project List in Table
                        $(""#divSectionExistingWorkItems"").show();
                        $('#tblexistingWorkItems').html('');

                        $("".divSectionExistingWorkItems"").show();

                        var headerrow = ""<tr style='background-color: lightgray;'>"" +
                            ""<td>Id  </td>"" +
                            ""<td> T");
            WriteLiteral(@"itle</td>"" +
                            ""<td> Type</td>"" +
                            ""<td> Status</td>"" +
                            ""</tr>"";
                        $('#tblexistingWorkItems').append(headerrow);

                        for (var i = 0; i < result.length; i++) {

                            var linkUrl = ""https://dev.azure.com/Benefactor-Clairvoyant/"" + projectName + ""/_workitems/edit/"" + result[i].id;
                            var datarow = ""<tr>"" +
                                ""<td> "" + result[i].id + ""</td > "" +
                                ""<td> <a href="" + linkUrl + "" target='_blank'> "" + result[i].fields.title+"" </a></td > "" +
                                ""<td> "" + result[i].fields.workItemType + ""</td > "" +
                                ""<td> "" + result[i].fields.state + ""</td > "" +
                                ""</tr>"";
                            $('#tblexistingWorkItems').append(datarow);
                        }
                       
         ");
            WriteLiteral(@"           }
                    // $("".divstatus"").append('<br> Project List received !');
                },
                error: function (xhr, status, error) {
                    console.log(xhr)
                }
            });
        }
        function ProjectList() {
            var org = $(""#txtOrg"").val();
            var pat = $(""#txtpat"").val();
            var url = ""https://localhost:44362/api/v1/GetProjectList?org="" + org + ""&pat1="" + pat;
            jQuery.ajax({
                url: url,
                type: ""get"",
                contentType: ""application/json"",
                success: function (result, status, xhr) {
                    //$("".divtoken"").html(result);
                    if (result.azprojectList.length >= 0) {

                        // Display the Project List in Table
                        $(""#divExistingProjectList"").show();
                        $('#tblexistingProjects').html('');

                        $("".divprojectcreationoptionma");
            WriteLiteral(@"in"").show();

                        var headerrow = ""<tr style='background-color: lightgray;'>"" +
                            ""<td>  </td>"" +
                            ""<td> Project Name</td>"" +
                            ""<td> URL</td>"" +
                            ""<td> Pipeline</td>"" +
                            ""</tr>"";
                        $('#tblexistingProjects').append(headerrow);


                        $("".getproject"").hide();
                        $("".process"").show();
                        $("".divoption"").show();
                        $(""#ddlprojectList"").empty();
                        for (var i = 0; i < result.azprojectList.length; i++) {
                            var spanshow = result.azprojectList[i].azPipelineList.length > 0 ? ""span-shown"" : ""span-show"";
                            var datarow = ""<tr>"" +
                                ""<td> <span class='"" + spanshow +
                                "" span-select'>"" +
                                ");
            WriteLiteral(@"""<input type='button' class='btnselectproject  btn-blue' data="" + result.azprojectList[i].id + "" value='select' /></span></td > "" +
                                ""<td> "" + result.azprojectList[i].name + ""</td>"" +
                                ""<td> "" + result.azprojectList[i].url + ""</td>"" +
                                ""<td> "" + result.azprojectList[i].azPipelineList.length + ""</td>"" +
                                ""</tr>"";
                            $('#tblexistingProjects').append(datarow);
                        }
                        $(""input[name=projectoption][value='0']"").prop(""checked"", true);
                        $("".connect"").hide();
                        registerbuttonEvent();
                        //checkprojectoption();
                        checkProcessButton();
                    }
                    // $("".divstatus"").append('<br> Project List received !');
                },
                error: function (xhr, status, error) {
                    co");
            WriteLiteral(@"nsole.log(xhr)
                }
            });
        }

        function CreateProject() {
            var existingProject = $('input[name=""projectoption""]:checked').val() == ""0"";
            var org = $(""#txtOrg"").val();
            var pat = $(""#txtpat"").val();
            var projectName = $(""#txtnewProject"").val();
            var desc = 'CreateNewProject';
            var projectType = $(""#dlltechnology option:selected"").val();

            // Send Work Item List
            var workItemList = [{}];

            $('.divWorkItemRow').each(function () {
                if ($(this).find(""div > textarea"").val().trim().length > 0) {
                    workItemList.push({ 'title': $(this).find(""div > textarea"").val(), 'type': $(this).find(""div > select"").val() });
                }
            });
            workItemList = workItemList.splice(1);
            var url = ""https://localhost:44362/api/v1/CreateProject?projectName="" + projectName + ""&description="" + desc + ""&org="" + org + ""&pa");
            WriteLiteral(@"t1="" + pat + ""&type="" + projectType + ""&isexist="" + existingProject + ""&numberOfTask="" + workItemList.length;

            $("".projectcreationmessage"").html('<br> Project creation, yaml upload and pipeline is in progress...');
            jQuery.ajax({
                url: url,
                type: ""get"",
                contentType: ""application/json"",
                success: function (result, status, xhr) {
                    if (result.length > 0 && result.toString().indexOf('Error') > 0) {
                        console.log(result);
                    }
                    $("".projectcreationmessage"").html('');
                    $("".newsectionmessage"").html('');
                    $("".divresult"").show();
                    $(""#divExistingProjectList"").hide();
                    $("".divprojectcreationoptionmain"").hide();
                    $("".newsectionmessage"").append('New Project ' + projectName + '   Created Successfully....<br> Project Link:-  ' + result);
                 ");
            WriteLiteral(@"   $("".newsectionmessage"").append(""<br>Pipeline also created for the project "" + projectName);
                },
                error: function (xhr, status, error) {
                    console.log(xhr)
                }
            });
        }

        function DeleteProject() {
            var org = $(""#txtOrg"").val();
            var pat = $(""#txtpat"").val();
            var projectName = $(""#txtdelProject"").val();
            var url = ""https://localhost:44362/api/v1/DeleteProject?projectName="" + projectName + ""&org="" + org + ""&pat1="" + pat;;

            jQuery.ajax({
                url: url,
                type: ""get"",
                contentType: ""application/json"",
                success: function (result, status, xhr) {
                    $("".divstatus"").append(result);
                },
                error: function (xhr, status, error) {
                    console.log(xhr)
                }
            });
        }
        function checkprojectoption() {
   ");
            WriteLiteral(@"         var optionval = $('input[name=""projectoption""]:checked').val();
            if (optionval == ""0"") {
                // Show Existing Section
                $("".span-select"").addClass(""span-show"");
                $("".span-select"").removeClass(""span-hidden"");
                $("".divpipelinecaption"").html('Create Pipeline from Existing Project');
                $(""#txtnewProject"").prop('disabled', true);
                $(""#txtnewProject"").val('');
                $("".divAddWorkItems"").hide();
               // $("".divSectionExistingWorkItems"").show();
            }
            if (optionval == ""1"") {
                // Show Create New Project Seaction
                $("".span-select"").removeClass(""span-show"");
                $("".span-select"").addClass(""span-hidden"");
                $("".divpipelinecaption"").html('Create Pipeline with New Project');
                $(""#txtnewProject"").prop('disabled', false);
                $(""#txtnewProject"").val('');
                $("".divAddWo");
            WriteLiteral(@"rkItems"").show();
                addDefaultWorkItems();
                $("".divSectionExistingWorkItems"").hide();
            }
        }

        $('input[type=radio][name=projectoption]').change(function () {
            checkprojectoption();
            checkProcessButton();
        });
        function registerbuttonEvent() {
            $("".btnselectproject"").click(function () {
                // alert($(this).attr(""data""));
                $(""#txtnewProject"").val($(this).attr(""data""));
                // Get WorkItem details as per Project Name
                var projectName = $(this).closest('td').next('td').text().trim();
                GetWorkItemList(projectName);
                
                checkProcessButton();
            });
        }

        $("".getproject"").click(function (e) {
            //GetToken();
            ProjectList();
        });

        $("".showList"").click(function (e) {
            //Hide result Section Message
            $("".divresult"").");
            WriteLiteral(@"hide();
            //clear projectname text box
            $(""#txtnewProject"").val('');
            ProjectList();
        });

        $(""#txtnewProject"").keyup(function () {
            checkProcessButton();

        });
        function checkProcessButton() {
            var isvalid = $(""#txtnewProject"").val().length > 0;
            if (isvalid) {
                $(""#btnprocess"").prop('disabled', false);
                $(""#btnprocess"").removeClass('disablebutton');
                $(""#btnprocess"").addClass('btn-blue');
            }
            else {
                $(""#btnprocess"").prop('disabled', true);
                $(""#btnprocess"").addClass('disablebutton');
                $(""#btnprocess"").removeClass('btn-blue');
            }
        }

        $(""#ddlprojectList"").change(function () {

            var selectedVal = $(this).find(':selected').val();
            var selectedText = $(this).find(':selected').text();

            $("".divstatus"").html('<br> You have sc");
            WriteLiteral(@"lected ' + selectedText);

        });

        $("".process"").click(function (e) {
            CreateProject();
        });

        $("".delete"").click(function (e) {
            DeleteProject();
        });

        function addDefaultWorkItems() {
            // If its First Task, then Add Below.
            if ($("".divWorkItemRow"").length == 1) {
                $("".divWorkItemRow:last .txtTaskTtile"").val('Create Resources for the Project');
            }
        }

        // Add new work Item
        $("".addworkitem"").click(function (e) {

            if ($("".divWorkItemRow"").length < 5) {
                //Clone the row Item
                var t = $("".divWorkItemRow:last"").clone()
                $(t).insertAfter("".divWorkItemRow:last"");

                // Clear the Text Area for the recent added 
                $("".divWorkItemRow:last .txtTaskTtile"").val('');
                $("".divWorkItemRow:last #ddlTaskType"").val(""0"")


                if ($("".divWorkItemRow"").len");
            WriteLiteral(@"gth == 2) {
                    $("".divWorkItemRow:last .txtTaskTtile"").val('Create Economics for the Project');
                }

                if ($("".divWorkItemRow"").length == 3) {
                    $("".divWorkItemRow:last .txtTaskTtile"").val('Develop application as per Project');
                }

                if ($("".divWorkItemRow"").length == 4) {
                    $("".divWorkItemRow:last .txtTaskTtile"").val('Create CI /CD for the Application');
                }

                // Register the delete event
                $("".delworkitemrow"").click(function (e) {

                    $(this).closest("".divWorkItemRow"").remove();

                    // If there is only row then no need show the delete button.
                    if ($("".divWorkItemRow"").length == 1) {
                        // Hide the Delete button for all.
                        $("".divWorkItemRow .delworkitemrow"").hide()
                    }
                });

                // If there is o");
            WriteLiteral(@"nly one row then no need show the delete button.
                if ($("".divWorkItemRow"").length > 1) {
                    // Show the Delete button for all.
                    $("".divWorkItemRow .delworkitemrow"").show()
                }
            }
        });

         // If there is only row then no need show the delete button.
        if ($("".divWorkItemRow"").length == 1) {
            // Hide the Delete button for all.
            $("".divWorkItemRow .delworkitemrow"").hide()
        }

    });
</script>

<script type=""text/javascript"">
    ShowModelPopUp = function () {
        var left = (screen.width);
        var top = (screen.height);
        window.open('/Pricing/Products', ""WindowPopup"", 'width=' + (screen.width) * 35 / 40 + ',height=400px, top= 100px, left = 100px');
    }
</script>

<br />
<div class=""headerinfo"">
    <div class=""connect"">
        <div class=""projectdivsection"">
            <div class=""row-header""> Connect to Organisation</div>
            <div c");
            WriteLiteral(@"lass=""divsectioncontent"">
                <div class=""rowdiv"">
                    <span>Organisation Name</span>
                    <span><input type=""text"" class=""inputtext"" id=""txtOrg"" value=""Benefactor-Clairvoyant"" /></span>
                </div>
                <div class=""rowdiv"">
                    <span>
                        Organisation PAT
                    </span>
                    <span style="" margin-left: 25px;""><input type=""password"" class=""inputtext"" id=""txtpat"" value=""nh6emfd3kbcveqxxrpzsdjizsiwlqmfgsr7nznttg6xx3yvsnvqq"" /></span>
                </div>
                <div class=""rowdiv marginbuttom-10"">
                    <span><input type=""button"" class=""getproject  btn-blue"" value=""Connect"" /></span>
                </div>
            </div>
        </div>
    </div>

");
            WriteLiteral(@"    <div class=""projectdivsection divprojectcreationoptionmain"">
        <div class=""row-header""> Create DevOps pipeline </div>
        <span class=""spaninfo"">Choose one option to create pipeline</span>
        <div class=""divoptioncontent"">
            <label>
                <input type=""radio"" name=""projectoption"" value=""0"" /> For Existing Project
            </label>
            <label class=""marginleft-50"">
                <input type=""radio"" name=""projectoption"" value=""1"" /> Create New Project
            </label>
        </div>
    </div>

    <div id=""divExistingProjectList""");
            BeginWriteAttribute("class", " class=\"", 17078, "\"", 17086, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 17102, "\"", 17110, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""projectdivsection"">
                <div class=""row-header""> Project List: </div>
                <span class=""spaninfo""> Click on the select button to Select project to add pipeline</span>
                <table id=""tblexistingProjects""></table>
            </div>


            <div class=""projectdivsection"">
                <div class=""row-header divpipelinecaption""> Create Pipeline from Existing Project </div>
                <span class=""spaninfo""> Enter Project Name and select Technology to create Project and Pipeline</span>
                <div class=""divsectioncontent marginleft-10"">

                    <div style="" display: inline-flex; width:100%"">
                        <div class=""divProjectName "">
                            ProjectName:
                            <input type=""text"" class=""inputtext"" id=""txtnewProject"" />
                        </div>
                        <div style=""margin-left:90px;margin-top:4px;"">
                            ");
            WriteLiteral("Technology:\r\n                            <select id=\"dlltechnology\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89fe692aaeeb03287ea271e583ff2561bd51300b25540", async() => {
                WriteLiteral(".net");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89fe692aaeeb03287ea271e583ff2561bd51300b26730", async() => {
                WriteLiteral("Java");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89fe692aaeeb03287ea271e583ff2561bd51300b27920", async() => {
                WriteLiteral("Python");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral(@"                </div>
            </div>

            <div class=""projectdivsection divAddWorkItems"">
                <div class=""row-header""> Work Item</div>
                <span class=""spaninfo"">Add Work Item into the Project</span>

                <div class=""divWokItemContainer"" style=""margin-top:10px;"">
                    <div style="" display: inline-flex; width:100%; margin-left: 20px; margin-bottom:10px;"" class=""divWorkItemRow"">
                        <div class=""taskTitle "" style="" text-align: center; vertical-align: middle; display: inline-flex; "">
                            <div style=""vertical-align: middle;margin-top: 13px;margin-right: 20px;""> Title</div>
                            <textarea name=""Text1"" class=""txtTaskTtile"" disabled=""disabled"" cols=""60"" rows=""1""></textarea>
                        </div>
                        <div style=""margin-left:90px;margin-top:13px;"">
                            TaskType:
                            <select id=""ddlTaskType"">
       ");
            WriteLiteral("                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89fe692aaeeb03287ea271e583ff2561bd51300b30331", async() => {
                WriteLiteral("Task");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89fe692aaeeb03287ea271e583ff2561bd51300b31521", async() => {
                WriteLiteral("Bug");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89fe692aaeeb03287ea271e583ff2561bd51300b32710", async() => {
                WriteLiteral("Epic");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89fe692aaeeb03287ea271e583ff2561bd51300b33900", async() => {
                WriteLiteral("Feature");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>
                        </div>
                        <div style="" margin-left: 20px; margin-top: 10px; "">
                            <input type=""button"" id=""btndelworkitemrow"" class="" delworkitemrow ui-icon ui-icon-closethick"" value=""Delete"" />
                        </div>
                    </div>
                    <div class=""divBtnWorkItem"">
                        <input type=""button"" id=""btnAddWorkItem"" class=""addworkitem btn-blue"" value=""Add New Work Item"" />
                    </div>
                </div>
            </div>


            <div class=""projectdivsection divSectionExistingWorkItems"">
                <div class=""row-header""> Work Items </div>
                <span class=""spaninfo""> Work Items list for the project</span>
                <table id=""tblexistingWorkItems""></table>
            </div>

            <div class=""divProcess"">
                <input type=""button"" id=""btnprocess"" class=""process  disablebutton"" value");
            WriteLiteral("=\"Process\" />\r\n            </div>\r\n            <div class=\"projectcreationmessage\"></div>\r\n        </div>\r\n");
            WriteLiteral(@"

        <br />
        <div class=""deletedv"" hidden>
            <span>Enter ProjectName to Delete</span>
            <span><input type=""text"" id=""txtdelProject"" /></span>
            <input type=""button"" class=""delete"" value=""Delete"" />
        </div>

    </div>

    <div class=""divresult"">
        <div class=""projectdivsection"">
            <div class=""row-header"">Success</div>
            <div class=""newsectionmessage""></div>
            <input type=""button"" class=""showList btn-blue"" value=""Show List"" />
        </div>
    </div>

    <div id=""status"" class=""divstatus""></div>
    <div id=""divToken"" class=""divtoken""></div>

");
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
