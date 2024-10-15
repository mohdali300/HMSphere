﻿using HMSphere.Domain.Entities;
using HMSphere.Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace HMSphere.MVC.ViewModels
{
    public class AppointmentViewModel
    {
        public int? Id { get; set; }

        public DateTime? Date { get; set; } = DateTime.Now;
        public Status? Status { get; set; }  
        public string? ReasonFor { get; set; } = string.Empty;
        public string? Clinic { get; set; } = string.Empty;
        public int? PatientId { get; set; }
        public int? DepartmentId { get; set; }
        public TimeSpan? AppointmentTime { get; set; }
        public int? DoctorId { get; set; }

        public string? Reason { get; set; }
    }

}
