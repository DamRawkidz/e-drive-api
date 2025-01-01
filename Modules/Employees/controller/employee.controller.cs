using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;


[Route("api/employee", Name = "employee")]
[ApiController]
public class EmployeeController : Controller
{
    public readonly EmployeeService employeeService;
    public EmployeeController(EmployeeService _employeeService)
    {
        employeeService = _employeeService;
    }

    [HttpGet]
    public async Task<ActionResult> getEmployee()
    {
        var result = await employeeService.getListEmp(); ;
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult> createEmployee([FromBody] t_employee request)
    {
        var result = await employeeService.createEmployee(request);
        return Ok(result);
    }


}