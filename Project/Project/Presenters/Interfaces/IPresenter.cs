using Project.Models;
using System.Windows.Forms;

namespace Project.Presenters.Interfaces
{
    public interface IPresenter
    {
        DataGridViewRow makeTaskRow(Task task);
        DataGridViewRow makeSubtaskRow(Subtask subtask);
        DataGridViewRow makeEmployeeRow(Employee employee);

        DataGridViewRow makeCommentRow(Comment comment);

    }
}
