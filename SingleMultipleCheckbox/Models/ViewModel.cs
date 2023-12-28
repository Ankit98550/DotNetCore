namespace SingleMultipleCheckbox.Models
{
    public class ViewModel
    {
        public bool AcceptTerm {  get; set; }
        public string Text { get; set; }

    }
    public class ViewModelCheckbox
    {
        public List<CheckboxOptions> Options { get; set; }  
        public List<string> sports {  get; set; } 
    }
}
