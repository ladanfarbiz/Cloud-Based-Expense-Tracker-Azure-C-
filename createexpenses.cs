using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public static class CreateExpense
{
    [FunctionName("CreateExpense")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = "expenses")] HttpRequest req,
        [CosmosDB("ExpenseDB", "Expenses", ConnectionStringSetting = "CosmosDbConnection")] IAsyncCollector<Expense> expensesOut)
    {
        var expense = await req.ReadFromJsonAsync<Expense>();
        await expensesOut.AddAsync(expense);
        return new OkObjectResult(expense);
    }
}
