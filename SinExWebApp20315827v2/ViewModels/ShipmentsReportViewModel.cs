using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using X.PagedList;

namespace SinExWebApp20315827v2.ViewModels
{
    public class ShipmentsReportViewModel
    {
        public virtual ShipmentsSearchViewModel Shipment { get; set; }
        public virtual IPagedList<ShipmentsListViewModel> Shipments { get; set; }

    }
}