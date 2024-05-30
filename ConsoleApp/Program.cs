using ConsoleApp;

Context _context = new Context();
if (!_context.People.Any())
{
    var adatok = File.ReadAllLines(@"10.csv").Skip(1);
    foreach (var item in adatok)
    {
        _context.People.Add(new People(item));
    }
    _context.SaveChanges();
}

Console.WriteLine("Adatok: ");

foreach (var item in _context.People)
{
    Console.WriteLine(item);
}