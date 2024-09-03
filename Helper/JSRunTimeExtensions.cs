using Microsoft.JSInterop;

namespace LearnBlazor.Helper
{
    public static class JSRunTimeExtensions
    {
        public static async Task ToastrSuccess(this IJSRuntime JsRunTime , string message )
        {
            await JsRunTime.InvokeVoidAsync("showToastr", "success", message);
        }
        public static async Task ToastrEorros(this IJSRuntime JsRunTime, string message)
        {
            await JsRunTime.InvokeVoidAsync("showToastr", "error", message);
        }

    }
}
