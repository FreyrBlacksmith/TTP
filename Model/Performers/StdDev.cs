using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Performers
{
    class StdDev : IPerformer
    {
        public void perform(HistoryData data, double input, IPresenter presenter)
        {
            if (data.list.Count == 0)
            {
                presenter.showStatus(0, "");
                return;
            }

            double[] old = data.Current();
            double[] block = new double[1] { 0 };
            double m2 = 0;
            double mean = 0;

            for(uint i=0;i<old.Length;++i)
            {
                mean =+ old[i];
            }
            mean /= old.Length;

            for (uint i = 0; i < old.Length; ++i)
            {
                
                m2 += (old[i] - mean) * (old[i] - mean);

                if ((i + 1) % 100 == 0 || i + 1 == block.Length)
                    presenter.showStatus((double)(i + 1) / block.Length, "Performing stddev.");
            }

            if (old.Length > 0)
            {
               
                m2 /= old.Length;

                block[0] = Math.Sqrt(m2);
            }

            data.Add(block);
            presenter.showStatus(1, "Done.");
        }
    }
}
