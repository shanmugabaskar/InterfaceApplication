// See https://aka.ms/new-console-template for more information
using InterfaceApplication;

Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);

t1.showTransaction();
t2.showTransaction();
Console.ReadKey();
