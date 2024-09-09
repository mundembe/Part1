using Microsoft.AspNetCore.Mvc;

public class ClaimController : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View(); 
    }

    [HttpPost]
    public IActionResult Create(Claim claim)
    {
        if (ModelState.IsValid)
        {
            // save the claim data
            return RedirectToAction("Index");  
        }
        return View(claim); 
    }
}
