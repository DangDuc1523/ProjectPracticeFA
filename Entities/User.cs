using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthcareAppointment.WebAPI.Entities;

public partial class User
{
    [Required]
    public string Id { get; set; } = null!;
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public string Email { get; set; } = null!;
    [Required]
    public DateTime DateOfBirth { get; set; }
    [Required]
    public string Password { get; set; } = null!;
    [Required]
    public int Role { get; set; }
    [Required]
    public string Specialization { get; set; } = null!;
}
