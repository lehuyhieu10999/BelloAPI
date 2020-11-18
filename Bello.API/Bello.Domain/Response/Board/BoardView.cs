using System;
using System.Collections.Generic;
using System.Text;

namespace Bello.Domain.Response.Board
{
    public class BoardView
    {
        public int BoardId { get; set; }
        public string BoardName { get; set; }
        public string Background { get; set; }
        public bool Star { get; set; }
        public bool Status { get; set; }
    }
}
