using System;
using Project.Models;
using Project.Business.Interfaces;
using Project.Persistence.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.Services
{
    public class CommentService : ICommentService
    {
        private CommentRepository _commentRepository;

        public CommentService()
        {
            this._commentRepository = new CommentRepository();
        }

        public (bool, Exception) AddComment(string title, string description, int timeReported, int subtaskId)
        {
            // create the comment model
            Comment comment = new Comment(0, title, description, timeReported, subtaskId);

            // store comment in db
            Exception exception = this._commentRepository.AddComment(comment);
            if (exception != null)
            {
                return (false, exception);
            }

            return (true, null);
        }
        public (Comment, Exception) GetCommentkById(int commentId)
        {
            (Comment comment, Exception exception) = _commentRepository.GetCommentkById(commentId);

            if (exception != null)
            {
                return (null, exception);
            }

            return (comment, null);
        }

        public (IList<Comment>, Exception) GetCommentBySubask(int subtaskId)
        {
            (IList<Comment> comments, Exception exception) = _commentRepository.GetCommentsBySubtask(subtaskId);

            if (exception != null)
            {
                return (null, exception);
            }

            return (comments, null);
        }
    }
}
