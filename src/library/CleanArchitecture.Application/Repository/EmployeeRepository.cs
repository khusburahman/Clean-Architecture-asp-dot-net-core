using AutoMapper;
using CleanArchitecture.Application.Service;
using CleanArchitecture.Application.VIewModels;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Repository;

public class EmployeeRepository:RepositoryService<Employee,EmployeeVm>,IEmployeeRepository
{
    public EmployeeRepository(IMapper mapper, ApplicationDbContext dbContext) : base(mapper, dbContext)
    {

    }
}
