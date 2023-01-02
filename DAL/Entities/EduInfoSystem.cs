using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DAL.Entities
{
    class EduInfoSystem
    {
        public List<Desk> InformationDesks { get; set; }
        public List<Group> UserGroups { get; set; }
    }
}