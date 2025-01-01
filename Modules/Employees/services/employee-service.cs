using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class EmployeeService
{
    public readonly EdriveDb db;

    public EmployeeService(EdriveDb _db)
    {
        this.db = _db;
    }


    public async Task<List<t_employee>> getListEmp()
    {
        return await this.db.t_employee.ToListAsync();
    }

    public async Task<t_employee> createEmployee(t_employee request)
    {
        // if (this.db.t_employee.Any(x => x.pincode == request.pincode))
        // {
        //     return Ok();
        // }

        await this.db.t_employee.AddAsync(request);
        await this.db.SaveChangesAsync();

        return request;
    }

    // public async Task<Boolean> authen(t_employee request)
    // {
    //     return this.db.t_employee.Any(x => x.pincode == request.pincode);
    // }


}
