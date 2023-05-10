using Project.Business.Interfaces;
using Project.Business.Services;
using Project.Models;
using Project.Presenters.Builders;
using Project.Presenters.Interfaces;
using System.Windows.Forms;

namespace Project.Presenters
{
    public class Presenter : IPresenter
    {
        private IBuilder builder;
        private ITaskService taskService;
        private ISubtaskService subtaskService;
        private IEmployeeService employeeService;
        private ICommentService commentService;

        public Presenter() {
            this.taskService = new TaskService();
            this.subtaskService = new SubtaskService();
            this.employeeService = new EmployeeService();
            this.commentService = new CommentService();
        }

        public DataGridViewRow makeCommentRow(Comment comment)
        {
            this.builder = new CommentBuilder();
            throw new System.NotImplementedException();
        }

        public DataGridViewRow makeEmployeeRow(Employee employee)
        {
            this.builder = new EmployeeBuilder();

            return null;
        }

        public DataGridViewRow makeSubtaskRow(Subtask subtask)
        {
            this.builder = new SubtaskBuilder();
            SubtaskBuilder subtaskBuilder = (SubtaskBuilder)builder;

            subtaskBuilder.SetDescription("ceva");

            return subtaskBuilder.GetResult();
        }

        public DataGridViewRow makeTaskRow(Task task)
        {
            this.builder = new EmployeeBuilder();

            return null;
        }
    }
}
