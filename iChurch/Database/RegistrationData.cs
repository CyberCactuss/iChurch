using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchSystem.Database
{
    
    public class MemberDetails
    {

        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Age { get; set; } = string.Empty;
        public string Sex { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public DateTime Birthday { get; set; } = DateTime.MinValue;
        public string Address { get; set; } = string.Empty;

    }

    
    internal static class RegistrationData
    {

        public static MemberDetails Member { get; set; } = new MemberDetails();
    }
}
