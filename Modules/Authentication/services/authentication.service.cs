using Microsoft.EntityFrameworkCore;

public class AuthenticationService
{
    public readonly EdriveDb db;

    public AuthenticationService(EdriveDb _db)
    {
        this.db = _db;
    }

    public async Task<Boolean> checkEmployeeIsCorrect(t_employee request)
    {
        return await this.db.t_employee.AnyAsync(x => x.pincode == request.pincode);
    }



}