﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Dnn.vNext.Data
{
    public class Module
    {
        [Key]
/*PK*/  public int ModuleID { get; set; }
/*FK*/  public int ModuleDefID { get; set; }
        public bool AllTabs { get; set; }
        public bool IsDeleted { get; set; }
        public bool? InheritViewPermissions { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PortalID { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public DateTime? LastContentModifiedOnDate { get; set; }
        public int? ContentItemID { get; set; }
        public bool? IsShareable { get; set; }
        public bool? IsShareableViewOnly { get; set; }

        // DNN vNext columns
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public virtual int ModuleDef { get; set; }

        public virtual ContentItem ContentItem { get; set; }
        public virtual ICollection<TabModule> TabModule { get; set; }
        public virtual ICollection<ModulePermission> ModulePermission { get; set; }
        public virtual ICollection<CoreMessaging_Subscription> CoreMessaging_Subscription { get; set; }
        public virtual ICollection<HtmlText> HtmlText { get; set; }
        public virtual ICollection<ModuleSetting> ModuleSetting { get; set; }

        
    }
}
