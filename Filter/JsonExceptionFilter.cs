using Microsoft.AspNetCore.Mvc.Filters;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace API.Filter;

public class JsonExceptionFilter :IExceptionFilter
{
    private readonly IWebHostEnvironment _env ;
    public JsonExceptionFilter(IWebHostEnvironment env){
        _env = env;
    }


    public void OnException(ExceptionContext context){
        var error = new APIErrors();

        if(_env.IsDevelopment()){

            error.Message = context.Exception.Message;
            error.Details = context.Exception.StackTrace;
        }
        else{
            error.Message = "An error ocurred";
            error.Details = context.Exception.Message;
        }
        context.Result = new ObjectResult(error)
        {
            StatusCode = 500
        };
    }
}
    
