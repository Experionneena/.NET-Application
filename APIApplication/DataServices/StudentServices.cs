using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIApplication.Data;
using APIApplication.EntityDtoMapping;
using DTOs;
using System.Web.Http;

namespace APIApplication.DataServices
{
    public class StudentServices : IStudentServices
    {
        TestEntities entities = new TestEntities();
        public List<StudentDto> GetAll()
        {
         
            List<Student> student = entities.Students.ToList();
            var students = StudentEntityDto.ToDtos(student);
            //List<Student> students = entities.Students.Where((p) => p.Age == age);
            //students.Add(s);
            return students;
        }
        public StudentDto GetOne(string name)
        {

           
            var v =entities.Students.FirstOrDefault(p => p.Name == name);
            var student = StudentEntityDto.ToDto(v);
            return student;
        }
   
        public bool Save(StudentDto studentdto)
        {
            var student = StudentEntityDto.ToEntity(studentdto);
            entities.Students.Add(student);
            entities.SaveChanges();
            return true;
        }
      
        public bool Edit(StudentDto studentdto)
        {
            var status = false;
            if (studentdto != null)
            {
                var v = entities.Students.Where(a => a.Id == studentdto.Id).FirstOrDefault();
                if (v != null)
                {
                    v.Name = studentdto.Name;
                    v.Age = studentdto.Age;
                    entities.SaveChanges();
                    status = true;
                }

            }
            return status;
        }

        public bool Delete(String name)
        {
          var v = entities.Students.Where(p => p.Name == name).FirstOrDefault();
            entities.Students.Remove(v);
            entities.SaveChanges();
            return true;
        }

      
    }

}