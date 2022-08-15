
public partial class Program
{
    public static void Main()
    {
        int s1 = 2000000000;
        int s2 = 2000000000;

        long l1 = s1 + s2; // túlcsordulás, mert az összeadás eredménye int.

        long lS1 = s1;
        long lS2 = s2; // implicit cast

        long s = lS1 + lS2; // helyes eredemény 4mrd

        long p1 = 12;

        int i2 = (int)p1; //explicit cast
        int i3 = Convert.ToInt32(p1); //explicit cast, ha túlcsordul, akkor overflow exception

        int i4 = (int)s;
        //int i5 = Convert.ToInt32(s); //overflow exception

        object o = i4; // vagy mi történik itt? -> boxing

        var p = new List<object>();
        p.Add(new MyClass());
        p.Add(o);
        p.Add(i4); // mi történik itt? -> boxing


        int v = 42;
        object vRef = v;


        var eq = eqMethodWrong(5, 5);
        Console.WriteLine(eq);

        var eqCorr = eqMethodRight<int>(5, 5);
        var eqCorrLong = eqMethodRight<long>(4000000000, 4000000000);
        Console.WriteLine(eqCorr);
        Console.WriteLine(eqCorrLong);
    }

    public static bool eqMethodWrong(object o1, object o2)
    {
        return o1 == o2;
    }

    public static bool eqMethodRight<T>(T t1, T t2)
    {
        return t1.Equals(t2);
    }

}

public class MyClass
{ 

}


