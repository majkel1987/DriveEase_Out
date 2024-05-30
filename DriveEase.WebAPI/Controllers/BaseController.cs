using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DriveEase.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BaseController : ControllerBase
	{
		private ISender _mediator;
		public ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
	}
}
