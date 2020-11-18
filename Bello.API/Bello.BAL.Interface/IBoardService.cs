using Bello.Domain.Request.Board;
using Bello.Domain.Response.Board;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bello.BAL.Interface
{
    public interface IBoardService
    {
        Task<IEnumerable<BoardView>> Gets();
        Task<SaveBoardRes> Save(SaveBoardReq request);
        Task<BoardView> Get(int boardId);
        //Task<SaveCourseRes> SaveCourse(SaveCourseReq request);
        //Task<SaveCourseRes> ChangeStatusCourse(int courseId, int status, int modifiedBy = 1);
    }
}
