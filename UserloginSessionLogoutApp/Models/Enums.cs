using Microsoft.AspNetCore.Mvc.Rendering;

namespace UserloginSessionLogoutApp.Models
{
    public class Enums
    {
        public enum Gender
        {
                female,
            male

        }
        public static List<SelectListItem> Data()
        {
            List<SelectListItem> gender = new ()
            {
                new SelectListItem{Value="male",Text="male"},
                new SelectListItem{Value="female",Text="female"},
            };
            return gender;
        }

    }
}
