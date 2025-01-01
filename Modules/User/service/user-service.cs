using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class UserService
{
    public readonly EdriveDb _db;
    private readonly jwt_config _jwt_config;
    private readonly IConfiguration _configuration;



    public UserService(
            EdriveDb db,
            IOptions<jwt_config> jwt_config,
            IConfiguration configuration


        )
    {
        this._db = db;
        _jwt_config = jwt_config.Value;
        _configuration = configuration;
    }


    public async Task<User> registerUser(t_user request)
    {
        var newUser = new t_user();
        newUser.userName = request.userName;
        newUser.create_date = DateTime.Now;
        newUser.passwordHash = BCrypt.Net.BCrypt.HashPassword(request.password);

        await _db.t_user.AddAsync(newUser);
        await _db.SaveChangesAsync();
        return newUser;
    }


    public async Task<UserResponses> login(t_user request)
    {
        var user = _db.t_user.SingleOrDefault(r => r.userName == request.userName);
        if (user == null || !BCrypt.Net.BCrypt.Verify(request.password, user.passwordHash))
        {
            //  return  BadRequest("Username or password is incorrect");
        }

        var resUser = new UserResponses();
        resUser.userName = user.userName;
        resUser.token = generateJwtToken(user);
        return resUser;
    }

    private string generateJwtToken(t_user user)
    {

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_configuration["jwt_config:secret"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] { new Claim("id", user.id.ToString()) }),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}