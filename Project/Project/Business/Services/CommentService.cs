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
    internal class CommentService : ICommentService
    {
        private CommentRepository commentRepository;

        public CommentService(CommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public (bool, Exception) AddComment(string title, string description, int timeReported, int subtaskId)
        {
            // create the subtask model
            Comment comment = new Comment(0, title, description, timeReported, subtaskId);

            // store subtask in db
            Exception exception = this.commentRepository.AddComment(comment);
            if (exception != null)
            {
                return (false, exception);
            }

            return (true, null);
        }
        public (Comment, Exception) GetCommentkById(int commentId)
        {
            (Comment comment, Exception exception) = commentRepository.GetCommentkById(commentId);

            if (exception != null)
            {
                return (null, exception);
            }

            return (comment, null);
        }

        public (IList<Comment>, Exception) GetCommentBySubask(int subtaskId)
        {
            (IList<Comment> comments, Exception exception) = commentRepository.GetCommentsBySubtask(subtaskId);

            if (exception != null)
            {
                return (null, exception);
            }

            return (comments, null);
        }
    }
}
