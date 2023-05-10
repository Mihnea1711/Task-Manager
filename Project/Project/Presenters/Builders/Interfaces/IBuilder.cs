using System.Windows.Forms;

namespace Project.Presenters.Interfaces
{
    public interface IBuilder
    {
        void Reset();
        DataGridViewRow GetResult();
    }
}
