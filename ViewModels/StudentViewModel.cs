namespace MvcRazorViews.ViewModels;

public class StudentViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }   
    public string Address { get; set; } 
    public bool Active { get; set; }

    public StudentViewModel(int id, string name, string address, bool active)
    {
        Id = id;
        Name = name;
        Address = address;
        Active = active;
    }
}