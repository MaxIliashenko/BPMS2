namespace BPMS.Shared.Security
{
    public enum PermissionAction
    {
        AdminRole,
        BPMS,
        CartableAdmin,
        CMSAdmin,
        CMSUser,
        Delegation,
        HomeUICustomization,
        NewsManagement,
        SendBpmsMessage,
        ShowTasks,
        Slider,
        TimeSheet,
        UICustomization,
        VacationManagement,
        ViewErrors,
        ViewProcessTracking,
    }

    public static class PermissionsExtensions
    {
        public static bool HasPermission(this PermissionAction action) => true;
    }
}
