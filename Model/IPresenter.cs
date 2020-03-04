using System;

namespace Model
{
    public interface IPresenter
    {
        void showStatus(double percent, String status);
        void showHistory(HistoryData data);
    }
}
