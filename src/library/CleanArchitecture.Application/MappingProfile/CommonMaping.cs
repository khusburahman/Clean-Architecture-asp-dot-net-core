using AutoMapper;
using CleanArchitecture.Application.VIewModels;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.MappingProfile;

public class CommonMaping:Profile
{
    public CommonMaping()
    {
        CreateMap<Employee, EmployeeVm>().ReverseMap();
    }
}
