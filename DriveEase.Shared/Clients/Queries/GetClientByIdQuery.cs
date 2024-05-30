using DriveEase.Shared.Clients.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveEase.Shared.Clients.Queries
{
	public class GetClientByIdQuery : IRequest<ClientDto>
	{
        public int Id { get; set; }
    }
}
