using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User : base_table
{
    public int? id { get; set; }
    // [Required]
    public string? userName { get; set; }
    // [Required]
    public string? password { get; set; } = "";
    public string? passwordHash { get; set; }
}

public class UserResponses
{
    public string? userName { get; set; }

    public string token { get; set; } = "";
    public string refreshToken { get; set; } = "";

    public UserResponses()
    {

    }


}




public class t_user : User
{

}

public class v_user : User
{

}