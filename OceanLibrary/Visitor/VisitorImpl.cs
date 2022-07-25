using Ocean.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Visitor
{
    internal class VisitorImpl : IVisitor
    {
        private List<int> cells = new List<int>();

        public VisitorImpl()
        {

        }

        public void Visit(Cell cell)
        {
            if (cells.Contains(cell.GetHashCode()))
            {
                return;
            }

            cells.Add(cell.GetHashCode());

            cell.Process();
        }

    }
}
