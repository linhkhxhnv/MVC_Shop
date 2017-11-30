﻿using System;

namespace Shop.Model.Abstrack
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
        bool Status { get; set; }
        string MetaKeyWord { get; set; }
        string MetaDescription { get; set; }
    }
}