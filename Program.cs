
int a = 5;

double c = a; //implicitno

int d = (int)c; //eksplicitno


Nesto nesto = new();
NestoDrugo nestoDrugo = new();

Nesto test;






test = nestoDrugo;

int x = 5;
int y = 8;
int rez1 = x + y;

Nesto n1 = new Nesto { Blabla = "Prvi" };
Nesto n2 = new Nesto { Blabla = "Drugi" };
int rez = n1 - n2;

Console.WriteLine("asdasd");

class Nesto
{
    public string Blabla;

    public static int operator -(Nesto a, Nesto b)
    {
        return 15;
    }

    public static Nesto operator + (Nesto a, Nesto b)
    {
        return new Nesto { Blabla = a.Blabla + b.Blabla };
    }

    public static implicit operator Nesto(NestoDrugo nd)
    {
        return new Nesto { Blabla = nd.JosNesto };
    }
}

class NestoDrugo
{
    public int Broj;
    public string JosNesto;
}
