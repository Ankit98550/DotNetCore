using Microsoft.AspNetCore.Mvc.Rendering;

namespace BindingDropdownListWithDb.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public List<SelectListItem> studentList { get; set; }
    }
}
