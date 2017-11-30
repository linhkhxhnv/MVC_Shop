using System;
using System.ComponentModel.DataAnnotations;
namespace Shop.Model.Abstrack
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [StringLength(256)]
        public string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime? UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [StringLength(256)]
        public string UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [StringLength(256)]
        public string MetaKeyWord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [StringLength(256)]
        public string MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}