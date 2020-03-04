using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Performers
{
    class Add : IPerformer
    {
        public void perform(HistoryData data, double input, IPresenter presenter)
        {

            if (data.list.Count == 0)
            {
                double[] block = new double[1] { input };

                data.Add(block);
                presenter.showStatus(1, "Готово.");
                return;
            }
            else
            {

                double[] old = data.Current();
                double[] block = new double[old.Length + 1];
                for (uint i = 0; i < old.Length; ++i) block[i] = old[i];
                block[old.Length] = input;
                data.Add(block);
                presenter.showStatus(1, "Готово.");
            }
        }
    }
}
