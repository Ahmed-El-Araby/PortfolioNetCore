using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class EntityBase
    {
        public Guid Id { set; get; }
    }
    public class Owner: EntityBase
    {
        public string FullName { get; set; }
        public string Profil { get; set; }
        public string Avatar { get; set; }
    }
    public  class Address: EntityBase
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Coutry { get; set; }
    }
    public class PortfolioItem : EntityBase
    {
        public string ProjectName { set; get; }
        public string Desctiption { set; get; }
        public int ImageUrl { set; get; }
        public Address address { get; set; }
        
    }
    
}
