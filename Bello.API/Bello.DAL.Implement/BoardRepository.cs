using Bello.DAL.Interface;
using Bello.Domain.Request.Board;
using Bello.Domain.Response;
using Bello.Domain.Response.Board;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Bello.DAL.Implement
{
    public class BoardRepository : BaseRepository,IBoardRepository
    {
        public async Task<BoardView> Get(int boardId)
        {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BoardId", boardId);
                return await SqlMapper.QueryFirstOrDefaultAsync<BoardView>(cnn: connection,
                                                            sql: "GetBoardById",
                                                            param: parameters,
                                                            commandType: CommandType.StoredProcedure);
               
        }

        public async Task<IEnumerable<BoardView>> Gets()
        {
            return await SqlMapper.QueryAsync<BoardView>(cnn: connection,
                                                         sql: "GetsBoard",
                                                         commandType: CommandType.StoredProcedure);
        }

        public async Task<SaveBoardRes> Save(SaveBoardReq request)
        {
            var result = new SaveBoardRes()
            {
                BoardId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BoardId", request.BoardId);
                parameters.Add("@BoardName", request.BoardName);
                parameters.Add("@Background", request.Background);
                parameters.Add("@Star", request.Star);
                

                result = await SqlMapper.QueryFirstOrDefaultAsync<SaveBoardRes>(cnn: connection,
                                                                    sql: "SaveBoard",
                                                                    param: parameters,
                                                                    commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception)
            {

                return result;
            }
        }
    }
}
