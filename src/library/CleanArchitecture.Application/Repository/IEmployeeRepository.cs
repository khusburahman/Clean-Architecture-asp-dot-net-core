using CleanArchitecture.Application.Service;
using CleanArchitecture.Application.VIewModels;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Repository;

public interface IEmployeeRepository:IRepositoryService<Employee, EmployeeVm>
{
}
