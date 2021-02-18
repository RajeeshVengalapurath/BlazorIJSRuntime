using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorIJSRuntime.Data
{
    public interface IJsInterop
    {
        public ValueTask<int> CallMyFunction(string data);
    }
}
