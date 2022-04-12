using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace ApiKeyExample.Attributes
{
    [AttributeUsage(validOn: AttributeTargets.Class)]
    public class ApiKeyAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {

        }
    }
}