//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiCarSharing.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Onay
    {
        public int OnayId { get; set; }
        public int UserId { get; set; }
        public string EhliyetResimYoluOn { get; set; }
        public string EhliyetResimYoluArka { get; set; }
        public string AdminOnay { get; set; }
    
        public virtual UyeBilgi UyeBilgi { get; set; }
    }
}
