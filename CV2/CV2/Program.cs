Complex a = new Complex(4, 3);
Complex b = new Complex(2, -1);


TestComplex.Test(a + b, new Complex(6, 2), "Test +");
TestComplex.Test(a + b, new Complex(6, 3), "Test +");
Console.WriteLine();

TestComplex.Test(a - b, new Complex(2, 4), "Test -");
Console.WriteLine();

TestComplex.Test(a * b, new Complex(11, 2), "Test *");
Console.WriteLine();

TestComplex.Test(a / b, new Complex(1, 2), "Test /");
Console.WriteLine();

TestComplex.Test(-a, new Complex(-4, -3), "Test unární -");
Console.WriteLine();

TestComplex.Test(a.Sdruzene(), new Complex(4, -3), "Test sdružené");
Console.WriteLine();

Console.WriteLine("a == b: {0}", a == b);
Console.WriteLine("a != b: {0}", a != b);
Console.WriteLine("a == new Complex(4,3): {0}", a == new Complex(4, 3));


Console.WriteLine("|a| = {0}", a.Modul());
Console.WriteLine("arg(a) = {0}", a.Argument());





