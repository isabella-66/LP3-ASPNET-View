using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class StudentController : Controller
{
    //private static List<StudentViewModel> students = new List<StudentViewModel>();
    private static List<StudentViewModel> students = 
        new List<StudentViewModel>{
            new StudentViewModel(1, "Maria Silveira", "Rua A, 1", true),
            new StudentViewModel(2, "João Roberto", "Rua A, 2", true),
            new StudentViewModel(3, "Mariana Caprisa", "Rua A, 3", false),
            new StudentViewModel(4, "Carla Gomes", "Rua A, 4", true)
        }; //coleção de estudantes, como se fosse bd; static pq quer uma coleção só pra coleção toda
    
    public IActionResult Index() //index normalmente usado pra listar
    {
        return View(students);
    }

    public IActionResult Show(int id)
    {
        return View(students[id-1]);
    }
}