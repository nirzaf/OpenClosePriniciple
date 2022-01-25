using OpenClosePrinciple;
using static System.Console;

WriteLine("Hello, World!");
var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);

Product[] products = { apple, tree, house };

var pf = new ProductFilter();
WriteLine("Green products (old):");
foreach (var p in pf.FilterByColor(products, Color.Green))
    WriteLine($" - {p.Name} is green");

// ^^ BEFORE

// vv AFTER
var bf = new BetterFilter();
WriteLine("Green products (new):");
foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
    WriteLine($" - {p.Name} is green");

WriteLine("Large products");
foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
    WriteLine($" - {p.Name} is large");

WriteLine("Large blue items");
foreach (var p in bf.Filter(products,
             new AndSpecification<Product>(new ColorSpecification(Color.Blue),
                 new SizeSpecification(Size.Large)))
        )
{
    WriteLine($" - {p.Name} is big and blue");
}