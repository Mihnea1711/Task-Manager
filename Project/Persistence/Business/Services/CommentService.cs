using System;
using System.Collections.Generic;


namespace Persistence
{
    public class CommentService : ICommentService
    {
        /// <summary>
        /// Instance of the CommentRepository class that handles the database operations.
        /// </summary>
        private CommentRepository _commentRepository;

        /// <summary>
        /// Constructor. Initializes the comment repository instance.
        /// </summary>
        public CommentService()
        {
            this._commentRepository = new CommentRepository();
        }

        /// <summary>
        /// Calls the comment repository class to add a comment.
        /// </summary>
        /// <param name="title">Comment title</param>
        /// <param name="description">Comment description</param>
        /// <param name="timeReported">Comment time reported</param>
        /// <param name="subtaskId">Comment's parent(subtask) id</param>
        /// <returns>>Returns true if the comment was added successfully , otherwise false. 
        /// Also returns an exception if an error happened while executing the statement.</returns>
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

        /// <summary>
        /// Method to retrieve a comment data model based on its id.
        /// </summary>
        /// <param name="commentId"></param>
        /// <returns>Returns the comment data object if found, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public (Comment, Exception) GetCommentkById(int commentId)
        {
            (Comment comment, Exception exception) = _commentRepository.GetCommentkById(commentId);

            if (exception != null)
            {
                return (null, exception);
            }

            return (comment, null);
        }

        /// <summary>
        /// Method to retrieve all the comment data models based on its (parent)subtask id.
        /// </summary>
        /// <param name="subtaskId"></param>
        /// <returns>Returns a list of comment data objects if found, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
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
