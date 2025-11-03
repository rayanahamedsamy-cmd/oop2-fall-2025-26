float ItemPrice = 250.00f;
float Discount = 15.0f / 100.00f;

float PriceAfterDiscount = ItemPrice - (ItemPrice * Discount);
Console.WriteLine("The Price After Discount is: " + PriceAfterDiscount + "$");