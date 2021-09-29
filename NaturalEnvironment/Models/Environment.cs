using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesEnvironment.Models
{
    public class Environment
    {
        public int ID {get; set;}
        public string Country {get; set;}
        public decimal Pollutionrate {get; set;}
        public string Currentstatus {get; set;}
        public string Effectonpeople {get; set;}
    }
}