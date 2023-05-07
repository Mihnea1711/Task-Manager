using System;
using System.Collections.Generic;
using Project.Models;

namespace Project.Business.Interfaces
{
    internal interface ICommentService
    {
        (bool, Exception) AddComment(string title, string description, int timeReported, int subtaskId);

        (Comment, Exception) GetCommentkById(int commentId);

        (IList<Comment>, Exception) GetCommentBySubask(int subtaskId);
    }
}