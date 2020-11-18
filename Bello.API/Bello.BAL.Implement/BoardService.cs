using Bello.BAL.Interface;
using Bello.DAL.Interface;
using Bello.Domain.Request.Board;
using Bello.Domain.Response;
using Bello.Domain.Response.Board;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bello.BAL.Implement
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository boardRepository;
        public BoardService(IBoardRepository boardRepository)
        {
            this.boardRepository = boardRepository;
        }

        public async Task<BoardView> Get(int boardId)
        {
           
            return await boardRepository.Get(boardId);
        }

        public async Task<IEnumerable<BoardView>> Gets()
        {
            return await boardRepository.Gets();
        }

        public async Task<SaveBoardRes> Save(SaveBoardReq request)
        {
            return await boardRepository.Save(request);
        }
    }
}
