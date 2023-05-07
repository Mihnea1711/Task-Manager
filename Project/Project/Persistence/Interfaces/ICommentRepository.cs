using System;
using Project.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Persistence.Interfaces
{
    internal interface ICommentRepository
    {
        Exception CreateCommentTable();
        Exception AddComment(Comment subtask);
        (Comment, Exception) GetCommentkById(int id);
        (IList<Comment>, Exception) GetCommentsBySubtask(int id);
    }
}
