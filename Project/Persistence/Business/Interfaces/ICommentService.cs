using System;
using System.Collections.Generic;

namespace Persistence
{
    public interface ICommentService
    {
        (bool, Exception) AddComment(string title, string description, int timeReported, int subtaskId);

        (Comment, Exception) GetCommentkById(int commentId);

        (IList<Comment>, Exception) GetCommentBySubask(int subtaskId);
    }
}