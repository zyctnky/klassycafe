//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace klassycafe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHEF
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string TITLE { get; set; }
        public string PICTURE { get; set; }
        public string FACEBOOK { get; set; }
        public string TWITTER { get; set; }
        public string INSTAGRAM { get; set; }
        public Nullable<int> STATE_ID { get; set; }
    
        public virtual STATE STATE { get; set; }
    }
}
