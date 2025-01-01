using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

[Route("api/companyInfo", Name = "companyInfo")]
[ApiController]
public class CompanyInfoController : Controller
{
    public readonly CompanyInfoService companyInfoService;
    public CompanyInfoController(CompanyInfoService _companyInfoService)
    {
        companyInfoService = _companyInfoService;
    }

    [HttpGet]
    public async Task<ActionResult> getCompanyInfo()
    {
        var result = await companyInfoService.getCompanyInfo();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult> updateCompanyInfo([FromBody] t_company_info request)
    {
        var result = await companyInfoService.updateCompanyInfo(request);
        return Ok(result);
    }

}