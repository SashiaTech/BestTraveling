using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Model.CollegeModel
{
    public class CollegeModel
    {
        public Guid CollegeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string DirectorName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public Guid? StateId { get; set; }
        public Guid? DistrictId { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? CityId { get; set; }
        public CollegeDirectorModel CollegeDirector { get; set; }
    }

    public class CollegeDirectorModel
    {
        public Guid DirectorId { get; set; }
        public string FirstName { get; set; }
        public string DirectorName { get; set; }
        public string LastName { get; set; }
        public string Code { get; set; }
        public Guid DirectorCountryId { get; set; }
        public Guid DirectorStateId { get; set; }
        public Guid DirectorCityId { get; set; }
        public Guid DirectorDistrictId { get; set; }
        public Guid DirectorAddressId { get; set; }
        public string Contact { get; set; }
        public Guid GenderId { get; set; }
    }
}
