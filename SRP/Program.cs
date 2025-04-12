#region Problem

using SRP;

var order = new SRP.Problem.Order();

order.Load();

order.AddItem(new Product
{
    Id = 1,
    Name = "Apple",
    Price = 9.99m
});

var orderItems = order.OrderItemsList;

order.Save();

var price = order.Calculate();

order.Print();

#endregion

#region Solution 

var orderSolution = new SRP.Solution.Order();
var orderRepo = new SRP.Solution.OrderRepository();
var printManager = new SRP.Solution.PrintManager();

orderSolution.OrderItemsList = orderRepo.Load(orderSolution.Id).ToList();

orderSolution.AddItem(new Product
{
    Id = 1,
    Name = "Apple",
    Price = 9.99m
});

var orderSolutionItems = orderSolution.OrderItemsList;

orderRepo.Save(orderSolution);

var priceSolution = orderSolution.Calculate();

printManager.Print(orderSolution);
#endregion