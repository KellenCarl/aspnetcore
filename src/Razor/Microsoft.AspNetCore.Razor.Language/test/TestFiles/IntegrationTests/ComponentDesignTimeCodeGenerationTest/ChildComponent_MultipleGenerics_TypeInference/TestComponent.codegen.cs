// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Test.TestComponent.TypeInference.CreateMyComponent_0(__builder, -1, -1, 
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                     "hi"

#line default
#line hidden
#nullable disable
            , -1, 
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                    new List<long>()

#line default
#line hidden
#nullable disable
            , -1, (context) => (__builder2) => {
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                __o = context.ToLower();

#line default
#line hidden
#nullable disable
            }
            , -1, (item) => (__builder2) => {
#nullable restore
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = System.Math.Max(0, item.Item);

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(MyComponent<,>);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMyComponent_0<TItem1, TItem2>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TItem1 __arg0, int __seq1, global::System.Collections.Generic.List<TItem2> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem1> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<global::Test.MyComponent<TItem1, TItem2>.Context> __arg3)
        {
        __builder.OpenComponent<global::Test.MyComponent<TItem1, TItem2>>(seq);
        __builder.AddAttribute(__seq0, "Item", __arg0);
        __builder.AddAttribute(__seq1, "Items", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.AddAttribute(__seq3, "AnotherChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591