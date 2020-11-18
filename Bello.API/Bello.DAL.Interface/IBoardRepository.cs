using Bello.Domain.Request.Board;
using Bello.Domain.Response.Board;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bello.DAL.Interface
{
    public interface IBoardRepository
    {
        Task<IEnumerable<BoardView>> Gets();
        Task<BoardView> Get(int boardId);
        Task<SaveBoardRes> Save(SaveBoardReq request);

        //Task<CourseView> GetCourseById(int courseId);
        //Task<SaveCourseRes> SaveCourse(SaveCourseReq request);
        //Task<SaveCourseRes> ChangeStatusCourse(int courseId, int status, int modifiedBy = 1);
    }
}
