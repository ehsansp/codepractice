﻿using CodePractice.Framework.Dto;
using CodePractice.Framework.Tools;
using CodePractice.Product.ApplicationService.Features.Person.Commands.CreatePerson;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePractice.Service.Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ValidationFilter]
        public async Task<FuncResult> Add([FromBody] CreateProductCommand createProductCommand, CancellationToken token)
        {
            var res = await _mediator.Send(createProductCommand, token);
            return FuncResult.CreateOkResult(res);
        }

        
    }
}
