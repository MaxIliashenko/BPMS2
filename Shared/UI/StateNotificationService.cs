using System;

namespace BPMS.Shared.UI
{
    public class StateNotificationService
    {
        public event Action RefreshRequested;
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}
