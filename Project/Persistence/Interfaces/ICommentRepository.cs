using System;

using System.Collections.Generic;

namespace Persistence
{
    public interface ICommentRepository
    {
        Exception CreateCommentTable();
        Exception AddComment(Comment subtask);
        (Comment, Exception) GetCommentkById(int id);
        (IList<Comment>, Exception) GetCommentsBySubtask(int id);
    }
}
