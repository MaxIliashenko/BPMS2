using BPMS.Shared.Interfaces.Services;
using BPMS.Shared.Layout;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BPMS.Server.Services
{
    public class HomeService : IHomeService
    {
        public async Task<List<HomeItem>> GetHomeItems()
        {
            var res = new List<HomeItem>
            {
                new() {Id = new Guid("5fe8ca42-34b2-4162-a37e-aaf501144632"), Text = "Audit", FAIcon = "fad fa-file-search"}, 
                new() {Id = new Guid("56db5895-4a5b-44b7-9e23-aaf700db4471"), Text = "Audit List", FAIcon = "fas fa-list"}
            };

            return res;
        }

    }
}
