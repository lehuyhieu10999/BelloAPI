using Bello.BAL.Interface;
using Bello.Domain.Request.Board;
using Bello.Domain.Response.Board;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bello.API.Controllers
{
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly IBoardService boardService;

        public BoardController(IBoardService boardService)
        {
            this.boardService = boardService;
        }

        [HttpGet("api/board/gets")]
        public async Task<OkObjectResult> GetsBoard()
        {
            var boards = await boardService.Gets();
            return Ok(boards);
        }
        [HttpGet("api/board/get/{id}")]
        public async Task<OkObjectResult> GetBoard(int id)
        {
            var board = await boardService.Get(id);
            if (board.BoardId == 0)
                return Ok(new ErrorResult()
                {
                    BoardId = 0,
                    Message = "Something went wrong, please try again later!"
                }) ;
            return Ok(board);
        }
        [HttpPost,HttpPatch]
        [Route("api/board/save")]
        public async Task<OkObjectResult> SaveCourse(SaveBoardReq request)
        {
            var result = await boardService.Save(request);
            return Ok(result);
        }
    }
}
