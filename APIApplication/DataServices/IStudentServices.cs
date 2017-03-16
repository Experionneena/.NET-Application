using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIApplication.Data;
using DTOs;

namespace APIApplication.DataServices
{
    interface IStudentServices
    {
        List<StudentDto> GetAll();
        StudentDto GetOne(string name);
        bool Save(StudentDto studentdto);
        bool Edit(StudentDto studentdto);
        bool Delete(string name);
    }
}
