namespace StudentInformationManagement.ModelsDTO
{
    public class StudentDTO
    {
        public string? fullName { get; set; }

        public string? gender { get; set; }

        public string? race { get; set; }

        public string? mobileNumber { get; set; }

        public string? icNumber { get; set; }

        public string? schoolName { get; set; }

        public string? homeDistrict { get; set; }

        public string? homeState { get; set; }
        public string? birthDate { get; set; }
        public int age { get; set; }

        public string? schoolBatch { get; set; }

        public string? schoolFeePaid { get; set; }

        public string? expectedToComplete { get; set; }

        public char? overallExamGrade { get; set; }

        public char? overallExtracurricularGrade { get; set; }
    }
}
