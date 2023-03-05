namespace StudentInformationManagement.Models
{
    public class Student
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }

        private string _fullName;

        public string? fullName
        {
            get
            {
                return _fullName = firstName + " " + lastName;
            }
        }

        public string? gender { get; set; }

        public string? race { get; set; }

        public string? mobileNumber { get; set; }

        public string? icNumber { get; set; }

        public string? schoolName { get; set; }

        public string? homeDistrict { get; set; }

        public string? homeState { get; set; }

        public DateTime birthDay { get; set; }

        public DateTime semesterStart { get; set; }

        private DateTime thisDay = DateTime.Today;

        private int _age;

        public int age
        {
            get
            {
                return _age = thisDay.Year - birthDay.Year;
            }
        }

        private int _schoolBatch;

        private string _batchAnswer;

        public string schoolBatch
        {
            get
            {
                if (_age > 6 && _age < 13)
                {
                    _schoolBatch = _age - 6;
                    _batchAnswer = $"Primary : {_schoolBatch}";

                }
                else if (_age > 12 && age < 18)
                {
                    _schoolBatch = _age - 12;
                    _batchAnswer = $"Secondary : {_schoolBatch}";
                }
                else
                {
                    _batchAnswer = $"Age {_age}. Not in school";
                }
                return _batchAnswer;
            }
        }

        public int english { get; set; }

        public int malay { get; set; }

        public int math { get; set; }

        public int science { get; set; }

        private int _overallExamScore;
        public int overallExamScore
        {
            get
            {
                _overallExamScore = (english + malay + math + science) / 4;
                return _overallExamScore;
            }

        }

        private char _examGrade;
        public char examGrade
        {
            get
            {
                if (overallExamScore > 79 && overallExamScore < 101)
                {
                    _examGrade = 'A';
                }
                else if (overallExamScore > 59 && overallExamScore < 80)
                {
                    _examGrade = 'B';
                }
                else if (overallExamScore > 39 && overallExamScore < 60)
                {
                    _examGrade = 'C';
                }
                else if (overallExamScore > 0 && overallExamScore < 40)
                {
                    _examGrade = 'D';
                }

                return _examGrade;
            }
        }

        public int sports { get; set; }

        public int uniforms { get; set; }

        public int clubs { get; set; }

        private int _overallExtracurricularScore;
        public int overallExtracurricularScore
        {
            get
            {
                _overallExtracurricularScore = (sports + uniforms + clubs) / 3;
                return _overallExtracurricularScore;
            }
        }

        private char _extraCurricularGrade;

        public char extraCurricularGrade
        {
            get
            {
                if (overallExtracurricularScore > 79 && overallExtracurricularScore < 101)
                {
                    _extraCurricularGrade = 'A';
                }
                else if (overallExtracurricularScore > 59 && overallExtracurricularScore < 80)
                {
                    _extraCurricularGrade = 'B';
                }
                else if (overallExtracurricularScore > 39 && overallExtracurricularScore < 60)
                {
                    _extraCurricularGrade = 'C';
                }
                else if (overallExtracurricularScore > 0 && overallExtracurricularScore < 40)
                {
                    _extraCurricularGrade = 'D';
                }

                return _extraCurricularGrade;

            }
        }
    }
}
