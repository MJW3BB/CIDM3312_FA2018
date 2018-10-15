using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment04

{
    public class Orginization
    {
        [Key]
        public int OrgID{ get; set; }
        public string OrgName { get; set; }
        public string OrgDescription { get; set; }
        public override string ToString()
        {
            return $"{OrgName} - {OrgDescription}";
        }
    }
}