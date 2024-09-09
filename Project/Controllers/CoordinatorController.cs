using Microsoft.AspNetCore.Mvc;

public class CoordinatorController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Approve(int id)
    {
        ViewData["Message"] = $"Claim with ID {id} has been approved.";
        return View("ActionResult");
    }

    public IActionResult Reject(int id)
    {
        ViewData["Message"] = $"Claim with ID {id} has been rejected.";
        return View("ActionResult");
    }

    public IActionResult ViewClaims()
    {
        // fetch and display all pending claims
        var claims = new List<dynamic> {
            new { Id = 1, LecturerName = "John Doe", HoursWorked = 10, Status = "Pending" },
            new { Id = 2, LecturerName = "Jane Smith", HoursWorked = 8, Status = "Pending" }
        };

        return View(claims);
    }
}