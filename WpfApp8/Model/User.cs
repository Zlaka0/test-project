using System.ComponentModel.DataAnnotations;
using System.Data;

namespace WpfApp8.Model;
public class User
{
    [Key]
   
    public int UserID { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public int RoleID { get; set; }
    
}

