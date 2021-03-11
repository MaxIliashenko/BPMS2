using BPMS.Shared.Interfaces.Services;
using BPMS.Shared.Layout;
using BPMS.Shared.Localization;
using BPMS.Shared.Security;
using System.Collections.Generic;

namespace BPMS.Server.Services
{
    public class MenuService : IMenuService
    {
        public List<MenuItem> GetMenuItems()
        {
            var items = new List<MenuItem>();

            var rootItem = new MenuItem("Facilities".loc(), isCategory: true);
            var isAdminRole = PermissionAction.AdminRole.HasPermission();
            var isViewProcessTracking = PermissionAction.ViewProcessTracking.HasPermission();
            var isCartableAdmin = PermissionAction.CartableAdmin.HasPermission();
            var isUiCutomization = PermissionAction.UICustomization.HasPermission();
            var isSlider = PermissionAction.Slider.HasPermission();
            var isUiHomeCutomization = PermissionAction.HomeUICustomization.HasPermission();
            var isNews = PermissionAction.NewsManagement.HasPermission();
            var isViewErrors = PermissionAction.ViewErrors.HasPermission();

            if (isAdminRole)
            {
                if (isUiCutomization)
                    rootItem.ChildItems.Add(new MenuItem("UI setup".loc(), "appearance-management"));

                if (isSlider)
                    rootItem.ChildItems.Add(new MenuItem("Slider images".loc(), "slider-managemet"));

                if (isUiHomeCutomization)
                    rootItem.ChildItems.Add(new MenuItem("Home Setup".loc(), "home-management"));

                if (isNews)
                    rootItem.ChildItems.Add(new MenuItem("News Management".loc(), "news-management"));

                if (isCartableAdmin)
                    rootItem.ChildItems.Add(new MenuItem("Task List Management".loc(), "cartable-admin"));

                if (isViewErrors)
                {
                    rootItem.ChildItems.Add(new MenuItem("Error Management".loc(), "logs"));
                    rootItem.ChildItems.Add(new MenuItem("Application Log".loc(), "applogs"));
                }
            }

            //if (StateProvider.IsRegisteredUser)
            {
                if (PermissionAction.Delegation.HasPermission())
                    rootItem.ChildItems.Add(new MenuItem("Delegation Management".loc(), "delegation-management"));

                if (PermissionAction.TimeSheet.HasPermission())
                    rootItem.ChildItems.Add(new MenuItem("Timesheet".loc(), "timesheet"));

                rootItem.ChildItems.Add(new MenuItem("Run Designer".loc(), "https://github.com/MaxIliashenko/BPMS2", isExternalLink: true));
            }

            if (rootItem.ChildItems.Count > 0)
                items.Add(rootItem);

            var cat = new MenuItem("Demo", isCategory: true);
            cat.ChildItems.Add(new MenuItem("Add new document", "form/e44986dd-f4e4-4f3e-98e6-aaea009c161c"));
            cat.ChildItems.Add(new MenuItem("Document Parser", "form/21bf0963-4d13-4cd7-9b12-2c7c1dc99e5a"));
            cat.ChildItems.Add(new MenuItem("Grid Test", "form/8a3db605-e7fa-4c46-a4e6-ab0a0101e349"));
            cat.ChildItems.Add(new MenuItem("List of documents", "form/bdb6d59d-0903-40ea-b4fc-aaea00aa47fa"));
            items.Add(cat);

            cat = new MenuItem("Organization Management", isCategory: true);
            cat.ChildItems.Add(new MenuItem("Organization chart management", "/form/92e11c2c-2ac7-41dd-99c5-aa0400fea8b7"));
            items.Add(cat);

            // language
            cat = new MenuItem("English", isCategory: true) { IconUrl = "/images/lang/en-US.png", CSSClass = "ml-auto" };
            cat.ChildItems.Add(new MenuItem("French") { IconUrl = "/images/lang/fr-CA.png" });
            cat.ChildItems.Add(new MenuItem("German") { IconUrl = "/images/lang/de-DE.png" });
            items.Add(cat);

            items.Add(new MenuItem("Log Out") { Icon = "fas fa-user-circle fa-2x" });
            return items;
        }
    }
}
