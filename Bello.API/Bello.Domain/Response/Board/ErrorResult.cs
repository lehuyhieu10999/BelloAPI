using System;
using System.Collections.Generic;
using System.Text;

namespace Bello.Domain.Response.Board
{
    public class ErrorResult : ResResult
    {
        public int BoardId { get; set; }
    }
}
