using Microsoft.AspNetCore.Mvc.Filters;


namespace WebApplication1.Filters
{
    public class SampleActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var data = context.ActionArguments.Select(x => x.ToString()).ToArray();
            // Do something before the action executes.
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var response = context.Result;
            // Do something after the action executes.
        }

    }

    public class SampleAuthActionFilter : IAuthorizationFilter
    {
 
        public void OnAuthorization(AuthorizationFilterContext context)
        {
             var k = context.HttpContext.User.Identity;
        }
    }

    public class SampleExceptionActionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            throw new NotImplementedException();
        }
    }

    public class SampleResultActionFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }

}