using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentInformationManagement.Models;
using StudentInformationManagement.ModelsDTO;

namespace StudentInformationManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailsController : ControllerBase
    {
        [HttpGet, Route("get-details/{inputName}")]
        public ActionResult GetDetails(string inputName)

        //[HttpGet]
        //public ActionResult GetDetails([FromBody] Student student, string inputName)

        {
            List<Student> students = new List<Student>()
            {
                new Student () {firstName = "Nickolas", lastName = "Saputra", gender = "Male", race = "Iban", mobileNumber = "019-876 2345", icNumber = "960210-13-6239",
                    schoolName = "SMK Meradong", homeDistrict = "Julau", homeState = "Sarawak", birthDay = new DateTime(2011, 1, 13, 2, 15, 10), semesterStart = new DateTime(2023, 1, 7),
                    english = 80, malay = 70, math = 75, science = 70, sports = 67, uniforms = 56, clubs = 75},

                new Student () {firstName = "Peter", lastName = "Davidson", gender = "Male", race = "Bidayuh", mobileNumber = "019-876 2345", icNumber = "960210-13-6239",
                    schoolName = "SMK Sarikei", homeDistrict = "Sarikei", homeState = "Sarawak", birthDay = new DateTime(2007, 10, 20, 4, 10, 10), semesterStart = new DateTime(2021, 1, 2),
                    english = 60, malay = 60, math = 95, science = 90, sports = 78, uniforms = 86, clubs = 75}
            };

            if (students.Any(s => s.firstName == inputName))
            {
                return Ok(students.Where(s => s.firstName == inputName)
                    .Select(studentselected => new StudentDTO()
                    {
                        fullName = studentselected.fullName,
                        gender = studentselected.gender,
                        race = studentselected.race,
                        mobileNumber = studentselected.mobileNumber,
                        icNumber = studentselected.icNumber,
                        schoolName = studentselected.schoolName,
                        homeDistrict = studentselected.homeDistrict,
                        homeState = studentselected.homeState,
                        birthDate = studentselected.birthDay.ToString("f"),
                        age = studentselected.age,
                        schoolBatch = studentselected.schoolBatch,
                        schoolFeePaid = DateTime.Now.ToString("d"),
                        expectedToComplete = studentselected.semesterStart.AddMonths(6).ToString("d"),
                        overallExamGrade = studentselected.examGrade,
                        overallExtracurricularGrade = studentselected.extraCurricularGrade

                    }).FirstOrDefault());
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]

        public ActionResult CreateValue([FromBody] StudentDTO student)
        {
            if (student == null)
                return BadRequest();

            return Ok(student);
        }

        [HttpDelete]

        public ActionResult DeleteValue([FromBody] StudentDTO student)
        {
            bool badThingHappened = false;

            if (badThingHappened)
            {
                return BadRequest();
            }
            else
            {
                return NoContent();
            }
        }

        [HttpPut]
        public ActionResult UpdateValue([FromBody] StudentDTO student)
        {
            return Ok(student);
        }
    }
}
