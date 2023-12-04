using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace TAgent.Models
{
    public class VisaApp
    {
        public int Id { get; set; }
        public string PassportType { get; set; }
        public string Country { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string PassportPhoto { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Status
    }
}
