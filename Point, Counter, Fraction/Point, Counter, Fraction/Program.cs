using Point__Counter__Fraction;

//Point point = new Point(1, -13);
//point.ShowData();



// -----------------------------------------
//Counter counter = new Counter(0, 100, 99);
//counter.increment();
//Console.WriteLine(counter.Curr);

//counter.increment();
//Console.WriteLine(counter.Curr);

//counter.Curr = 0;
//counter.decrement();
//Console.WriteLine(counter.Curr);



// -----------------------------------------
Fraction f1 = new Fraction(1, 2);
Fraction f2 = new Fraction(1, 10);

Console.WriteLine(f1.Add(f2));
Console.WriteLine(f2.Subtract(f1));
Console.WriteLine(f1.Multiply(f2));
Console.WriteLine(f2.Divide(f1));