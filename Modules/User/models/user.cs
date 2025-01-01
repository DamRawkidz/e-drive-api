public class User: base_table {
    public int? id { get; set; }
    public string password { get; set; }
    public string paswordHash { get; set; }
}

public class t_user : User {

}

public class v_user: User {
    
}