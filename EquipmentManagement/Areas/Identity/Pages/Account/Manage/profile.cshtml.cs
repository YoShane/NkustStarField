using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace EquipmentManagement.Areas.Identity.Pages.Account.Manage
{
    public partial class ProfileModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly string connectionString;

        public ProfileModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        [TempData]
        public string StatusMessage { get; set; }

        public class InfoModel
        {
            [Required]
            [Display(Name = "姓名"), StringLength(50, MinimumLength = 1)]
            public string Name { get; set; }

            [Editable(false)]
            [Display(Name = "身份"), StringLength(10)]
            public string Identity { get; set; }

            [Editable(false)]
            [Display(Name = "已繳社費")]
            public bool Member_fee { get; set; }

            [Editable(false)]
            [Display(Name = "帳號建立時間"), DataType(DataType.Date)]
            public DateTime CreateDate { get; set; }
        }

        [BindProperty]
        public InfoModel Info { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                await connection.OpenAsync();
                String sqlQuery = $"SELECT * FROM dbo.Member WHERE Stu_mail = '{user.UserName}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                using (SqlDataReader dataReader = await command.ExecuteReaderAsync()) {
                    if (dataReader.HasRows) {
                        dataReader.Read();
                        Info = new InfoModel
                        {
                            CreateDate = Convert.ToDateTime(dataReader["CreateDate"]),
                            Name = Convert.ToString(dataReader["Name"]),
                            Identity = Convert.ToString(dataReader["Identity"]),
                            Member_fee = Convert.ToBoolean(dataReader["Member_fee"])
                        };
                        if(Info.Identity == "Member") {
                            Info.Identity = "一般使用者";
                        }else if (Info.Identity == "Club") {
                            Info.Identity = "社團代表";
                        } else if (Info.Identity == "Admin") {
                            Info.Identity = "器材管理者";
                        } 
                    }
                }
            }
                    return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                String sqlQuery = $"UPDATE dbo.Member SET Name = '{Info.Name}' WHERE Stu_mail = '{user.UserName}'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection)) {
                    await connection.OpenAsync();
                    try {
                        await command.ExecuteNonQueryAsync();
                    }
                    catch (SqlException ex) {
                        Console.WriteLine("Operation got error:" + ex.Message);
                    }
                    connection.Close();
                }
            } //更改使用者姓名 SQL

            StatusMessage = "你的個人資訊已經更新";
            return RedirectToPage();
        }

      
    }
}
