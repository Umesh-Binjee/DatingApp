namespace API.DTOs
{
    public class MemberUpdateDto
    {
        public string UserName { get; set; }

        public string Introduction { get; set; }

        public string LookingFor { get; set; }

        public string Interests { get; set; }

        public string City { get; set; }
        
        public string Country { get; set; }
    }
}