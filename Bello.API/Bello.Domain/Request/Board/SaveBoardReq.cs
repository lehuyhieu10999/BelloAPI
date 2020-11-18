using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bello.Domain.Request.Board
{
    public class SaveBoardReq
    {
        public int BoardId { get; set; }
        [Required]
        public string BoardName { get; set; }
        [Required]
        public string Background { get; set; }
        public bool Star { get; set; }
    }
}
