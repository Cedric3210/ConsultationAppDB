﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        
        public string StudentUMID { get; set; }
        
        public string StudentName { get; set; }
        
        public string Email { get; set; }
        
        [ForeignKey(nameof(ProgramID))]
        public int ProgramID { get; set; }
        public virtual Program Program { get; set; }
        public List<ConsultationRequest> ConsultationRequests { get; set; }
        public List<SchoolYear> SchoolYears { get; set; }

        public Users Users { get; set; }

        public List<EnrolledCourse> EnrolledCourses { get; set; }
    }
}
