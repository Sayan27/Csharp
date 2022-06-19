using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CandidateCode.ViewModels
{
    public class AddViewModel
    {
        public string BookName {get;set;}
        public string AuthorName{get;set;}
        public double Price{get;set;}
    }
}