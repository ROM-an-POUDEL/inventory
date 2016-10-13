﻿using Frapid.Dashboard.Controllers;

namespace MixERP.Inventory.Controllers
{
    public class InventoryBackendController:DashboardController
    {
        public InventoryBackendController()
        {
            ViewBag.InventoryLayoutPath = this.GetLayoutPath();
        }

        private string GetLayoutPath()
        {
            return this.GetRazorView<AreaRegistration>("Layout.cshtml", this.Tenant);
        }
    }
}