using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class CompanyInfoService
{
    public readonly EdriveDb db;
    public CompanyInfoService(
        EdriveDb _db
    )
    {
        this.db = _db;
    }


    public async Task<t_company_info> getCompanyInfo()
    {
        return await db.t_company_info.FirstOrDefaultAsync();
    }

    public async Task<t_company_info> updateCompanyInfo(t_company_info request)
    {

        if (request.id == null)
        {
            await db.t_company_info.AddAsync(request);
            await db.SaveChangesAsync();
            return request;
        }
        else
        {
            db.Update(request);
            await db.SaveChangesAsync();
            return request;
        }

    }
}