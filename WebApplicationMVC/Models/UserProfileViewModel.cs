using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models;

public class UserProfileViewModel
{
    public string? Name { get; internal set; }
    public string? EmailAddress { get; internal set; }
    public string? ProfileImage { get; internal set; }
}

