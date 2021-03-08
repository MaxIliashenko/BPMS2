using System;

namespace BPMS.Shared.UI
{
    public interface IStateNotificationService
    {
        event Action RefreshRequested;
        void CallRequestRefresh();
    }

    public class StateNotificationService : IStateNotificationService
    {
        public event Action RefreshRequested;
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}
