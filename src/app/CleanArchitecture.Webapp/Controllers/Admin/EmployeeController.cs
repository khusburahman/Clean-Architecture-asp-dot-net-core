using CleanArchitecture.Application.Repository;
using CleanArchitecture.Application.VIewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Webapp.Controllers.Admin;

public class EmployeeController : Controller
{
    private readonly IEmployeeRepository employeeRepository;

    public EmployeeController(IEmployeeRepository employeeRepository)
    {
        this.employeeRepository = employeeRepository;
    }
    [HttpGet]
    public async Task<ActionResult> Index(CancellationToken CancellationToken)
    {
        var data = await employeeRepository.GetAllAsync(CancellationToken);
        return View(data);
    }

    public async Task<ActionResult<EmployeeVm>> CreateOrEdit(long id, CancellationToken cancellationToken)
    {
        if (id == 0)
        {
            return View(new EmployeeVm());
        }
        else
        {
            return View(await employeeRepository.GetByIdAsync(id, cancellationToken));
        }
    }
    [HttpPost]

    public async Task<ActionResult<EmployeeVm>> CreateOrEdit(long id, EmployeeVm studentVm, CancellationToken cancellationToken)
    {
        if (id == 0)
        {
            if (ModelState.IsValid)
            {
                await employeeRepository.InsertAsync(studentVm, cancellationToken);
                return RedirectToAction(nameof(Index));
            }
        }
        else
        {
            await employeeRepository.UpdateAsync(id, studentVm, cancellationToken);
            return RedirectToAction(nameof(Index));
        }
        return View(studentVm);
    }
    public async Task<ActionResult<EmployeeVm>> Delete(long id, CancellationToken cancellationToken)
    {
        if (id == null)
        {
            return RedirectToAction(nameof(Index));
        }
        else
        {
            await employeeRepository.DeleteAsync(id, cancellationToken);
            return RedirectToAction(nameof(Index));
        }
    }

    public async Task<ActionResult<EmployeeVm>> Details(long id, CancellationToken cancellationToken)
    {
        if (id == 0)
        {
            return RedirectToAction(nameof(Index));
        }
        else
        {
            return View(await employeeRepository.GetByIdAsync(id, cancellationToken));
        }
    }
}