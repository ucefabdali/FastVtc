using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FastVtc.Services.Interfaces
{
    public interface IViewToStringRenderer
    {
        Task<string> RenderToStringAsync(string viewPath, object model, CultureInfo cultureInfo);
    }
}
