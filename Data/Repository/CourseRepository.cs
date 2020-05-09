using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private YPInvoiceAppDbContext _ctx;
        public CourseRepository(YPInvoiceAppDbContext ctx) {
            _ctx = ctx;
        }
        IEnumerable<Course> ICourseRepository.GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
