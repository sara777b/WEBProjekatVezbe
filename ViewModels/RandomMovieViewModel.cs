using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBProjekatVezbe.Models; //da bi mogao da pokupi odavde

namespace WEBProjekatVezbe.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; } //get set kao i za svaki properti
        public List<Customer> Customers { get; set; }
    }
}