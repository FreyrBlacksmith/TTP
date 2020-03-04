using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Model.FileOperators
{
    public class Loader : IFileOperator
    {
        public async Task perform(HistoryData data, String argument, IPresenter presenter)
        {
            double[] block = null;

            try
            {
                String result;

                using (StreamReader reader = new StreamReader(argument))
                {
                    result = await reader.ReadToEndAsync();
                }
                String[] values = result.Split(' ');
                block = Array.ConvertAll(values, s => double.Parse(s));
                foreach (var item in block)
                {
                    var i = 0;
                    
                    presenter.showStatus((double)(i + 1) / block.Length, "Performing save.");
                    i++;
                }
                
            }
            catch (Exception e)
            {
                presenter.showStatus(0, e.ToString());
                return;
            }

            data.Add(block);
            presenter.showStatus(1, "Done.");
            presenter.showHistory(data);
        }
    }
}
