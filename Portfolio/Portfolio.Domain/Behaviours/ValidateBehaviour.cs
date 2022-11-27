using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//namespace Portfolio.Domain.Behaviours
//{
//    public class ValidateBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
//         where TRequest : IRequest<TResponse>
//    {
//        private readonly IValidator<TRequest> validator;

//        public ValidateBehaviour(IValidator<TRequest> validator)
//        {
//            this.validator = validator;
//        }
//        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
//        {
//            var validationResult = await validator.ValidateAsync(request, cancellationToken);

//            if (!validationResult.IsValid)
//            {
//                throw new ValidationException("not implemented");
//            }
//            var response = await next();
//            return response;
//        }
//    }
//}
