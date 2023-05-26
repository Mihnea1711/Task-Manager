using Project.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Persistence.Interfaces
{
    internal class CommentRepository : ICommentRepository
    {
        /// <summary>
        /// Class constructor. Checks the connection to the db and creates the comments table if it does not exist.
        /// </summary>
        public CommentRepository()
        {
            CheckConnection();

            CreateCommentTable();
        }
        /// <summary>
        /// Method to check the connection to the database. If the connection is not running, it opens the connection.
        /// </summary>
        private void CheckConnection()
        {
            if (Program.DbConnection == null)
            {
                Program.Connect();
            }
        }
        /// <summary>
        /// Method to create the comments table in the database, in case it is not created yet.
        /// </summary>
        /// <returns>Returns an exception if the statement did not execute properly.</returns>
        public Exception CreateCommentTable()
        {
            string stmt = "" +
                "CREATE TABLE IF NOT EXISTS comments (" +
                    "commentid           INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "commenttitle        VARCHAR2(50) NOT NULL," +
                    "commentdescription  VARCHAR2(100) NOT NULL," +
                    "timereported        NUMBER(2) NOT NULL," +
                    "subtaskid           INTEGER NOT NULL," +
                    "CONSTRAINT          comments_subtasks_fk FOREIGN KEY(subtaskid ) REFERENCES subtasks(subtaskid ) ON DELETE CASCADE" +
                ");";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Method to add a comment to the database.
        /// </summary>
        /// <param name="comment">Comment data model.</param>
        /// <returns>Returns an exception if an error happened while executing the statement.</returns>
        public Exception AddComment(Comment comment)
        {
            string stmt = $"INSERT INTO comments(commenttitle, commentdescription, timereported, subtaskid) " +
                $"VALUES ('{comment.Title}'," +
                $" '{comment.Description}'," +
                $" '{comment.TimeReported}'," +
                $" '{comment.SubtaskId}')";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);

            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Method to retrieve a comment data based on its id.
        /// </summary>
        /// <param name="id">Subtask id.</param>
        /// <returns>Returns the comment data if it was found, otherwise null. 
        /// Also returns an exception in case an error happened while executing the statement.</returns>
        public (Comment, Exception) GetCommentkById(int id)
        {
            string stmt = $"SELECT * FROM comments WHERE commentid = '{id}'";

            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            using (cmd)
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        Comment comment = null;
                        while (dataReader.Read())
                        {
                            int commentId = dataReader.GetInt32(0);
                            string commentTitle = dataReader.GetString(1);
                            string commentDescription = dataReader.GetString(2);
                            int timeReported = dataReader.GetInt32(3);
                            int subtaskId = dataReader.GetInt32(4);

                            comment = new Comment(commentId, commentTitle, commentDescription, timeReported, subtaskId);
                        }
                        if (comment == null) throw new Exception("comment is null");
                        return (comment, null);
                    }
                }
                catch (Exception ex)
                {
                    return (null, new Exception(ex.Message));
                }
            }
        }
        /// <summary>
        /// Method to retrieve all comments based on a taskId.
        /// </summary>
        /// <param name="id">SubtaskId id.</param>
        /// <returns>Returns all the comments if they were found, otherwise null. 
        /// Also returns an exception in case an error happened while executing the statement.</returns>
        public (IList<Comment>, Exception) GetCommentsBySubtask(int id)
        {
            List<Comment> comments = new List<Comment>();

            string stmt = $"SELECT commentid FROM comments WHERE subtaskid = '{id}'";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            using (cmd)
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        int i = 0;
                        while (dataReader.Read())
                        {
                            int subtaskId;
                            if (int.TryParse(dataReader.GetValue(i).ToString(), out subtaskId))
                            {
                                comments.Add(GetCommentkById(subtaskId).Item1);
                            }
                        }
                        if (comments == null) throw new Exception("comments is null");
                        return (comments, null);
                    }
                }
                catch (Exception ex)
                {
                    return (null, new Exception(ex.Message));
                }
            }
        }
    }
}
