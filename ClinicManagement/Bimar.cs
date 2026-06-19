namespace ClinicManagement
{
    public class Bimar
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string NationalCode { get; set; }
        public string MobileNumber { get; set; }
    }
}
