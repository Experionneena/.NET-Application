using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTOs;
using APIApplication.Data;

namespace APIApplication.EntityDtoMapping
{
    public static class StudentEntityDto
    {
        public static Student ToEntity(StudentDto dto)
        {
            Student entity = new Student();
            if (dto != null)
            {
                entity.Id = dto.Id;
                entity.Name = dto.Name;
                entity.Age = dto.Age;
            }
            return entity;
        }

       

      

        public static StudentDto ToDto(Student entity)
        {
            StudentDto dto = new StudentDto();
            if (entity != null)
            {
                dto.Id = entity.Id;
                dto.Name = entity.Name;
                dto.Age = entity.Age;
               
            }
            return dto;
        }
        public static List<StudentDto> ToDtos(List<Student> Student)
        {
            List<StudentDto> studentDtos = new List<StudentDto>();
            if (Student != null)
            {
                foreach (var item in Student)
                {
                    studentDtos.Add(ToDto(item));
                }
            }
            return studentDtos;
        }

        internal static object ToEntity(Student v)
        {
            throw new NotImplementedException();
        }
    }

    //public static List<Student> ToDTOs(this IEnumerable<Student> entities)
    //{
    //    try
    //    {
    //        if (entities == null)
    //        {
    //            return null;
    //        }

    //        return entities;
    //    }
    //    catch (Exception ex)
    //    {
    //        return null;
    //    }

    //}
    //}

}