using LSP.Problem2;

var discountedOrder = new DiscountedOrder();
SomeFunc(discountedOrder);

void SomeFunc(IOrder order)
{
    if (order is DiscountedOrder)
    {
        Console.WriteLine(discountedOrder.CalculateTotalPrice() * (100 + discountedOrder.DiscountPercent) / 100);
    }
    else
    {
        Console.WriteLine(order.CalculateTotalPrice());
    }
}
