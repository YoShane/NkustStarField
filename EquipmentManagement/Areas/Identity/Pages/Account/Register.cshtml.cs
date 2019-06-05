using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using EquipmentManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EquipmentManagement.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly string connectionString;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _logger = logger;
            _emailSender = emailSender;
            this.connectionString = configuration.GetConnectionString("DefaultConnection");

        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "學號欄位不可空白")]
            [EmailAddress(ErrorMessage = "輸入格式有誤")]
            [Display(Name = "學號")]
            public string Email { get; set; }

            [Required(ErrorMessage = "姓名欄位不可空白")]
            [Display(Name = "姓名")]
            public string Name { get; set; }

            [Required(ErrorMessage = "手機欄位不可空白")]
            [Phone(ErrorMessage = "輸入格式有誤")]
            [Display(Name = "手機號碼")]
            public string Phone { get; set; }

            [Required(ErrorMessage ="密碼欄位不可空白")]
            [StringLength(100, ErrorMessage = "密碼最低需6個字元", MinimumLength = 6)]
            [DataType(DataType.Password, ErrorMessage = "輸入格式有誤")]
            [Display(Name = "密碼")]
            public string Password { get; set; }

            [DataType(DataType.Password, ErrorMessage = "輸入格式有誤")]
            [Display(Name = "密碼確認")]
            [Compare("Password", ErrorMessage = "與前次密碼不同")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email};
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    /* string[] roleNames = { "Admin", "Member" };
            if (_roleManager == null) {
                throw new Exception("roleManager null");
            }

            IdentityResult IR = null;
            foreach (var roleName in roleNames) {
                //creating the roles and seeding them to the database
                var roleExist = await _roleManager.RoleExistsAsync(roleName);
                if (!roleExist) {
                    IR = await _roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            建立角色授權
            IdentityUser user1 = await _userManager.FindByEmailAsync("0624011@nkust.edu.tw");
            await _userManager.AddToRoleAsync(user1, "Admin");

            IdentityUser user2 = await _userManager.FindByEmailAsync("0624005@nkust.edu.tw");
            await _userManager.AddToRoleAsync(user2, "Admin");

            IdentityUser user3 = await _userManager.FindByEmailAsync("0624055@nkust.edu.tw");
            await _userManager.AddToRoleAsync(user3, "Member"); */


                    await _userManager.AddToRoleAsync(user, "Member"); //給角色權限 

                    //建使用者表
                    using (SqlConnection connection = new SqlConnection(connectionString)) {

                        String sqlQuery = "INSERT INTO dbo.Member(Stu_mail, Phone, [Name], [Identity], Member_fee) Values " +
                             $"('{Input.Email}', '{Input.Phone}', '{Input.Name}', 'Member', 0)";

                        using (SqlCommand command = new SqlCommand(sqlQuery, connection)) {
                            await connection.OpenAsync();
                            await command.ExecuteNonQueryAsync();
                            connection.Close();
                        }
                    }

                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
