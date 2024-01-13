using System.Text.Json.Serialization;
using Web.Data.Entity;

namespace WebSchema;

public class ExpenseCategoryRequestModel
{
    [JsonIgnore]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
}


public class ExpenseCategoryResponseModel
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
    
    public List<Expense> Expenses { get; set; }
}