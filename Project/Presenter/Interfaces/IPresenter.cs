using System.Windows.Forms;
using Persistence;

namespace Presenters
{
    public interface IPresenter
    {
        DataGridViewRow makeTaskRow(Task task);
        DataGridViewRow makeSubtaskRow(Subtask subtask);
        DataGridViewRow makeEmployeeRow(Employee employee);
        DataGridViewRow makeCommentRow(Comment comment);

    }
}
