using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthcareAppointment.WebAPI.Entities;

public partial class Appointment
{
    [Required]
    public string Id { get; set; } = null!;

    [Required]
    public string PartientId { get; set; } = null!;

    [Required]
    public string DoctorId { get; set; } = null!;

    [Required]
    public DateOnly Date { get; set; }

    [Required]
    public int Status { get; set; }
}
