using System.Collections.Generic;
using System.Web.Http;
using APIApplication.Data;
using APIApplication.DataServices;
using DTOs;

namespace APIApplication.Controllers
{
    public class StudentController : ApiController
    {
        IStudentServices IStudentService;
        [HttpGet]
        public List<StudentDto> GetStudents()
        {
            IStudentService = new StudentServices();
            List<StudentDto> students = IStudentService.GetAll();
            return students;
        }
        public StudentDto GetStudent(string name)
        {
            IStudentService = new StudentServices();
            StudentDto students = IStudentService.GetOne(name);
            return students;
        }

        [HttpPost]
        public bool Save(StudentDto studentdto)
        {
            IStudentService = new StudentServices();

            return IStudentService.Save(studentdto);

        }
        [HttpPut]
        public bool Edit(StudentDto studentdto)
        {
            IStudentService = new StudentServices();

            return IStudentService.Edit(studentdto);

        }

        public bool Delete(string name)
        {
            IStudentService = new StudentServices();
            return IStudentService.Delete(name);
        }
    }
}
