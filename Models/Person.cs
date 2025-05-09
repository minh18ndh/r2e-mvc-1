namespace MyFirstMVC.Models
{
    public class Person
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Gender { get; set; }
        public required DateOnly DateOfBirth { get; set; }
        public required string PhoneNumber { get; set; }
        public required string BirthPlace { get; set; }
        public required string IsGraduated { get; set; }

        public int Age => DateTime.Now.Year - DateOfBirth.Year;
        public string FullName => $"{LastName} {FirstName}";
    }
}