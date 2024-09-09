using Microsoft.AspNetCore.Mvc;

public class AcademicManagerController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Approve(int id)
    {
        // Approve the claim by the academic manager
        ViewData["Message"] = $"Claim with ID {id} has been approved by the Academic Manager.";
        return View("ActionResult");
    }

    public IActionResult Reject(int id)
    {
        // Reject the claim by the academic manager
        ViewData["Message"] = $"Claim with ID {id} has been rejected by the Academic Manager.";
        return View("ActionResult");
    }

    public IActionResult ViewClaims()
    {
        // Fetch claims verified by Programme Coordinators but pending for Academic Manager approval
        var claims = new List<dynamic> {
            new { Id = 1, LecturerName = "John Doe", HoursWorked = 10, Status = "Pending Approval by Academic Manager" },
            new { Id = 2, LecturerName = "Jane Smith", HoursWorked = 8, Status = "Pending Approval by Academic Manager" }
        };

        return View(claims);
    }
}
