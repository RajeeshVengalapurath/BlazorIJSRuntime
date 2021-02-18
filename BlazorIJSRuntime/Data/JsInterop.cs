using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorIJSRuntime.Data
{
    public class JsInterop : IJsInterop
    {
        private readonly IJSRuntime js;
        public JsInterop(IJSRuntime js)
        {
            this.js = js;
        }
        public ValueTask<int> CallMyFunction(string data)
        {
            return js.InvokeAsync<int>(
                "myFunction",data);
        }

    }
}
