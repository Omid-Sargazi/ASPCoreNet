using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;


namespace MiddlewareExamples02.Validators
{
    public class ValidationMiddleware<TRequest> : IMiddleware
    {

        private readonly IValidator<TRequest> _validator;

        public ValidationMiddleware(IValidator<TRequest> validator)
        {
            _validator = validator;
        }


        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var request = context.Items["Request"] as TRequest;
            if(request is null) throw new CustomException("Invalid request");

            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
            throw new ValidationException(validationResult.Errors);
            }

            await next(context);

        }
    }
}