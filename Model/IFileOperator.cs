using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    interface IFileOperator
    {
        Task perform(HistoryData data, String argument, IPresenter presenter);
    }
}
