using ConsoleApp1;
using Microsoft.EntityFrameworkCore;

ShopsDB shopDB = new ShopsDB();

var list = shopDB.Workers.Include(x => x.Position);

foreach(var i in list)
{
    Console.WriteLine(i.Name + " " + i.Surname + " " + i.PhoneNumber + " " + i.Email + " " + i.Position.Name);
}