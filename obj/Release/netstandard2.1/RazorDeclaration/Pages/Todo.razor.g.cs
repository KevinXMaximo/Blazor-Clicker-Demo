// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_Clicker_Demo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kevin\source\repos\Blazor-Clicker-Demo\Blazor-Clicker-Demo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kevin\source\repos\Blazor-Clicker-Demo\Blazor-Clicker-Demo\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kevin\source\repos\Blazor-Clicker-Demo\Blazor-Clicker-Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kevin\source\repos\Blazor-Clicker-Demo\Blazor-Clicker-Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kevin\source\repos\Blazor-Clicker-Demo\Blazor-Clicker-Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kevin\source\repos\Blazor-Clicker-Demo\Blazor-Clicker-Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kevin\source\repos\Blazor-Clicker-Demo\Blazor-Clicker-Demo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kevin\source\repos\Blazor-Clicker-Demo\Blazor-Clicker-Demo\_Imports.razor"
using Blazor_Clicker_Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kevin\source\repos\Blazor-Clicker-Demo\Blazor-Clicker-Demo\_Imports.razor"
using Blazor_Clicker_Demo.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\kevin\source\repos\Blazor-Clicker-Demo\Blazor-Clicker-Demo\Pages\Todo.razor"
        // starts the place to input c# code to be exectued
    private List<TodoItem> todos = new(); // initializes field todos using class TodoItem, the instance is initialized empty through the function new()
    private string newTodo; // creates a string variable named newTodo

    private void AddTodo() // creates a void function to be triggered every time the user clicks the button to add a todo item
    { // opens contents of the function
        if (!string.IsNullOrWhiteSpace(newTodo)) // triggers code if the contents typed on the textbox are not empty or null
        { // opens content of if loop
            todos.Add(new TodoItem { Title = newTodo }); // makes typed string newTodo into the field Title, which will then be added as a todo item as described in line 10
            newTodo = string.Empty; // empties the string newTodo so that the user can type a new string should they want to
        } // closes if loop
    } // closes function to add items

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
