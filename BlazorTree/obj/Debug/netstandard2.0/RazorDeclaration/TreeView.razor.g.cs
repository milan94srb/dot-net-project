#pragma checksum "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTree\TreeView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "753383b9f03be026b0e14f374bc9b8613d6f5d7f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTree
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class TreeView<IItem> : ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 46 "E:\New folder\MilicaProjekat\BlazorTestProjects\BlazorTree\TreeView.razor"
 
  [Parameter] public IEnumerable<INodeItem<IItem>> Dependents { get; set; }
  [Parameter] public RenderFragment<IItem> OpenContent { get; set; }
  [Parameter] public RenderFragment<IItem> OpenSelectedContent { get; set; }
  [Parameter] public RenderFragment<IItem> ClosedContent { get; set; }
  [Parameter] public RenderFragment<IItem> ClosedSelectedContent { get; set; }
  [Parameter] public int Depth { get; set; }

  // This may or may not be provided by the consumer 
  // If it is, we will use it to decide which RenderFragment to display
  [CascadingParameter] ITreeSelection<IItem> TreeSelection { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591