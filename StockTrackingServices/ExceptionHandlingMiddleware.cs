using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Mail;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.InteropServices;
using System.Text.Json;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Validation;
using System.Data;
using System.Data.Entity.Core;

namespace StockTrackingServices
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _requestDelegate;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;
        public ExceptionHandlingMiddleware(RequestDelegate requestDelegate, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _requestDelegate = requestDelegate; 
            _logger = logger;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _requestDelegate.Invoke(httpContext);
            }            
            catch (DbUpdateException exception)
            {
                _logger.LogError(
                exception, "Exception occurred: {Message}", exception.Message);

                var problemDetails = new ProblemDetails
                {
                    Status = StatusCodes.Status400BadRequest,
                    Title = "Database Update Error"
                };
                httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                await httpContext.Response.WriteAsJsonAsync(problemDetails);
            }
            catch (InvalidOperationException exception)
            {
                _logger.LogError(
                exception, "Exception occurred: {Message}", exception.Message);

                var problemDetails = new ProblemDetails
                {
                    Status = StatusCodes.Status400BadRequest,
                    Title = "Invalid Operation"
                };
                httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                await httpContext.Response.WriteAsJsonAsync(problemDetails);
            }
            catch (DbEntityValidationException exception)
            {
                _logger.LogError(
                exception, "Exception occurred: {Message}", exception.Message);

                var problemDetails = new ProblemDetails
                {
                    Status = StatusCodes.Status400BadRequest,
                    Title = "Entity Validation Error"
                };
                httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                await httpContext.Response.WriteAsJsonAsync(problemDetails);
            }
            catch (DBConcurrencyException exception)
            {
                _logger.LogError(
                exception, "Exception occurred: {Message}", exception.Message);

                var problemDetails = new ProblemDetails
                {
                    Status = StatusCodes.Status409Conflict,
                    Title = "Database Concurrency Error"
                };
                httpContext.Response.StatusCode = StatusCodes.Status409Conflict;
                await httpContext.Response.WriteAsJsonAsync(problemDetails);
            }
            catch (NotSupportedException exception)
            {
                _logger.LogError(
                exception, "Exception occurred: {Message}", exception.Message);

                var problemDetails = new ProblemDetails
                {
                    Status = StatusCodes.Status501NotImplemented,
                    Title = "Not Supported"
                };
                httpContext.Response.StatusCode = StatusCodes.Status501NotImplemented;
                await httpContext.Response.WriteAsJsonAsync(problemDetails);
            }
            catch (EntityCommandExecutionException exception)
            {
                _logger.LogError(
                exception, "Exception occurred: {Message}", exception.Message);

                var problemDetails = new ProblemDetails
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Title = "Server Error"
                };
                httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await httpContext.Response.WriteAsJsonAsync(problemDetails);
            }
            catch (Exception exception)
            {
                _logger.LogError(
                exception, "Exception occurred: {Message}", exception.Message);

                var problemDetails = new ProblemDetails
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Title = "Entity Command Execution Error"
                };
                httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await httpContext.Response.WriteAsJsonAsync(problemDetails);
            }
        }
    }
}


//var response = httpContext.Response;
//response.ContentType = "application/json";
//var responseModel = ApiResponse<string>.Fail(exception.Message);
//switch (exception)
//{
//    case SomeException e:
//        // custom application error
//        response.StatusCode = (int)HttpStatusCode.BadRequest;
//        break;
//    case KeyNotFoundException e:
//        // not found error
//        response.StatusCode = (int)HttpStatusCode.NotFound;
//        break;
//    default:
//        // unhandled error
//        response.StatusCode = (int)HttpStatusCode.InternalServerError;
//        break;
//}
//var result = JsonSerializer.Serialize(responseModel);
//await response.WriteAsync(result);
