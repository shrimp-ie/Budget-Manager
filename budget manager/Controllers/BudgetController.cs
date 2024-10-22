using Microsoft.AspNetCore.Mvc;

public class BudgetController : Controller
{
    // GET: Light Saver
    public ActionResult LightSaver()
    {
        return View();
    }

    // POST: Light Saver
    [HttpPost]
    public ActionResult LightSaver(decimal amount)
    {
        // Define allocation percentages for Light Saver
        var expensePercentage = 0.70m; // 70% for expenses
        var savingsPercentage = 0.20m; // 20% for savings
        var leisurePercentage = 0.10m; // 10% for leisure

        // Calculate amounts
        var expenses = amount * expensePercentage;
        var savings = amount * savingsPercentage;
        var leisure = amount * leisurePercentage;

        ViewBag.TotalAmount = amount;
        ViewBag.Expenses = expenses;
        ViewBag.Savings = savings;
        ViewBag.Leisure = leisure;

        return View();
    }

    // Similarly for Saver and HeavySaver
    public ActionResult Saver()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Saver(decimal amount)
    {
        // Define allocation percentages for Saver
        var expensePercentage = 0.60m; // 60% for expenses
        var savingsPercentage = 0.30m; // 30% for savings
        var leisurePercentage = 0.10m; // 10% for leisure

        var expenses = amount * expensePercentage;
        var savings = amount * savingsPercentage;
        var leisure = amount * leisurePercentage;

        ViewBag.TotalAmount = amount;
        ViewBag.Expenses = expenses;
        ViewBag.Savings = savings;
        ViewBag.Leisure = leisure;

        return View();
    }

    public ActionResult HeavySaver()
    {
        return View();
    }

    [HttpPost]
    public ActionResult HeavySaver(decimal amount)
    {
        // Define allocation percentages for Heavy Saver
        var expensePercentage = 0.50m; // 50% for expenses
        var savingsPercentage = 0.40m; // 40% for savings
        var leisurePercentage = 0.10m; // 10% for leisure

        var expenses = amount * expensePercentage;
        var savings = amount * savingsPercentage;
        var leisure = amount * leisurePercentage;

        ViewBag.TotalAmount = amount;
        ViewBag.Expenses = expenses;
        ViewBag.Savings = savings;
        ViewBag.Leisure = leisure;

        return View();
    }
}
