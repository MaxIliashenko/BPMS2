using DevExpress.Blazor.Base;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BPMS.Client.Shared
{
    public class DxScrollViewBase : DxComponentBase
    {
        protected ElementReference InputElement;

        [Inject] IJSRuntime JsRuntime { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        public DxScrollViewBase() { }

        protected override Task InitClientSide(bool firstRender) => JsRuntime.InvokeAsync<string>("ScrollViewInit", InputElement).AsTask();
    }
}