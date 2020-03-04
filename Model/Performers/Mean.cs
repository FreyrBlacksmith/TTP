using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Performers
{
    class Mean : IPerformer
    {
        public void perform(HistoryData data, double input, IPresenter presenter)
        {
            if (data.list.Count == 0)
            {
                presenter.showStatus(0, "");
                return;
            }

            double[] old = data.Current();
            double[] block = new double[1]{ 0 };

            for (uint i = 0; i < old.Length; ++i)
            {
                block[0] += old[i];

                if ((i + 1) % 100 == 0 || i + 1 == old.Length)
                    presenter.showStatus((double)(i + 1) / old.Length, "Performing mean.");
            }

            if(old.Length > 0)
                block[0] /= old.Length;

            data.Add(block);
            presenter.showStatus(1, "Done.");
        }
    }
}
