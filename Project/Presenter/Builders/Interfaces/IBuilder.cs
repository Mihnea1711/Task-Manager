using System.Windows.Forms;

namespace Presenters
{
    public interface IBuilder
    {
        void Reset();
        DataGridViewRow GetResult();
    }
}
