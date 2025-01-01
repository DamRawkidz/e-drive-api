using System.ComponentModel.DataAnnotations;

public class employee : base_table
{
    [Key]
    public int? id { get; set; }
    public string firstName { get; set; } = "";
    public string lastName { get; set; } = "";
    public string nickName { get; set; } = "";

    public bool is_active { get; set; }

    public int? msr_card { get; set; }

    public string? tax_id { get; set; }
    public string? home_phone_no { get; set; }
    public string? mobile_phone_no { get; set; }
    public string? email { get; set; }
    public string? address { get; set; }
    public string? ciy { get; set; }
    public string? state { get; set; }
    public string? zipcode { get; set; }

    public string? pincode { get; set; }

    public DateTime? hired_date { get; set; }
    public DateTime? terminated_date { get; set; }
    public DateTime? birth_date { get; set; }
    public string? driver_licence_no { get; set; }
    public DateTime? driver_licence_expire { get; set; }

    public string? car_insure_carrier { get; set; }
    public DateTime? insurance_licence_expire { get; set; }
    public string? insurance_policy_no { get; set; }
    public string? insurance_policy_note { get; set; }

    public string? employee_note { get; set; }

    public int? pay_rate_id { get; set; }

    public int pay_rate { get; set; } = 0;

    public bool is_enable_clock_break { get; set; }


}

public class t_employee : employee
{

}
public class v_employee : employee
{

}



