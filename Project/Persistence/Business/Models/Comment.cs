namespace Persistence
{
    public class Comment
    {
        /// <summary>
        /// The class contains the fields stored inside the db so it is easier to build the model inside the application.
        /// </summary>
        #region fields
        private int _id;
        private string _title;
        private string _description;
        private int _timeReported;
        private int _subtaskId;
        #endregion

        /// <summary>
        /// Getters and setters for the fields.
        /// </summary>
        #region getters/setters
        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public int TimeReported { get => _timeReported; set => _timeReported = value; }
        public int SubtaskId { get => _subtaskId; set => _subtaskId = value; }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="timeReported"></param>
        /// <param name="subtaskId"></param>
        public Comment(int id, string title, string description, int timeReported, int subtaskId)
        {
            this._id = id;
            this._title = title;
            this._description = description;
            this._timeReported = timeReported;
            this._subtaskId = subtaskId;
        }
    }
}
