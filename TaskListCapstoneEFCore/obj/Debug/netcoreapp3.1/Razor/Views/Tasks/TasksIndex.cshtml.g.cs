#pragma checksum "C:\Users\Nate\Documents\CSharp_april2020\TaskListCapstoneEFCore\TaskListCapstoneEFCore\Views\Tasks\TasksIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b286335a5104a60d5c193e74cce49b9a9c5978ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_TasksIndex), @"mvc.1.0.view", @"/Views/Tasks/TasksIndex.cshtml")]
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
#line 1 "C:\Users\Nate\Documents\CSharp_april2020\TaskListCapstoneEFCore\TaskListCapstoneEFCore\Views\_ViewImports.cshtml"
using TaskListCapstoneEFCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nate\Documents\CSharp_april2020\TaskListCapstoneEFCore\TaskListCapstoneEFCore\Views\_ViewImports.cshtml"
using TaskListCapstoneEFCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b286335a5104a60d5c193e74cce49b9a9c5978ee", @"/Views/Tasks/TasksIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3cf717c8bff91b0fe01f6ce7095890243204d95", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_TasksIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tasks>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Nate\Documents\CSharp_april2020\TaskListCapstoneEFCore\TaskListCapstoneEFCore\Views\Tasks\TasksIndex.cshtml"
  
    ViewData["Title"] = "TasksIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Click <a href=\"/Tasks/AddTask\" class=\"btn-outline-danger\">HERE</a> to add a task.</h4>\r\n<h1>Your Tasks</h1>\r\n\r\n");
            WriteLiteral("\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>User ID</th>\r\n            <th>Task Description</th>\r\n            <th>Due Date</th>\r\n            <th>Completed</th>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\Nate\Documents\CSharp_april2020\TaskListCapstoneEFCore\TaskListCapstoneEFCore\Views\Tasks\TasksIndex.cshtml"
         foreach (var task in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Nate\Documents\CSharp_april2020\TaskListCapstoneEFCore\TaskListCapstoneEFCore\Views\Tasks\TasksIndex.cshtml"
               Write(task.AspNetUsersId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Nate\Documents\CSharp_april2020\TaskListCapstoneEFCore\TaskListCapstoneEFCore\Views\Tasks\TasksIndex.cshtml"
               Write(task.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Nate\Documents\CSharp_april2020\TaskListCapstoneEFCore\TaskListCapstoneEFCore\Views\Tasks\TasksIndex.cshtml"
               Write(task.DueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Nate\Documents\CSharp_april2020\TaskListCapstoneEFCore\TaskListCapstoneEFCore\Views\Tasks\TasksIndex.cshtml"
               Write(task.Completed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 658, "\"", 696, 2);
            WriteAttributeValue("", 665, "/Tasks/MarkComplete?id=", 665, 23, true);
#nullable restore
#line 26 "C:\Users\Nate\Documents\CSharp_april2020\TaskListCapstoneEFCore\TaskListCapstoneEFCore\Views\Tasks\TasksIndex.cshtml"
WriteAttributeValue("", 688, task.Id, 688, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-dark\">Change Status</a>\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 801, "\"", 837, 2);
            WriteAttributeValue("", 808, "/Tasks/DeleteTask?id=", 808, 21, true);
#nullable restore
#line 29 "C:\Users\Nate\Documents\CSharp_april2020\TaskListCapstoneEFCore\TaskListCapstoneEFCore\Views\Tasks\TasksIndex.cshtml"
WriteAttributeValue("", 829, task.Id, 829, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-danger\">Delete Task</a>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Nate\Documents\CSharp_april2020\TaskListCapstoneEFCore\TaskListCapstoneEFCore\Views\Tasks\TasksIndex.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tasks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
