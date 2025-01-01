using System.ComponentModel.DataAnnotations;

public class company_info : base_table
{
    [Key]
    public int? id { get; set; }

    public string? bussiness_name { get; set; }

    public string? address_1 { get; set; }

    public string? address_2 { get; set; }
    public string? city { get; set; }
    public string? state { get; set; }
    public string? postal_code { get; set; }

    public string? phone_1 { get; set; }
    public string? phone_2 { get; set; }
    public string? fax { get; set; }
    public string? website_url { get; set; }
    public string? area_code { get; set; }
}

public class t_company_info : company_info
{

}
public class v_company_info : company_info
{

}



