using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


     class Complex
    {
    public double Real;
    public double Imagine;

    public Complex(double Real = 0.0, double Imagine = 0.0)
    { 
        this.Real = Real;
        this.Imagine = Imagine;
    }

    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Real+b.Real, a.Imagine+b.Imagine);
    }

    public static Complex operator -(Complex a, Complex b) 
        {
        return new Complex(a.Real - b.Real, a.Imagine - b.Imagine);
    }

    public static Complex operator -(Complex a)
    {
        return new Complex(-a.Real , -a.Imagine );
    }

   
    public static Complex operator *(Complex a, Complex b)
    {
        return new Complex(
            a.Real * b.Real - a.Imagine * b.Imagine,
            a.Real * b.Imagine + a.Imagine * b.Real
        );
    }

    public static Complex operator /(Complex a, Complex b)
    {
        double jmenovatel = b.Real * b.Real + b.Imagine * b.Imagine;

        return new Complex(
            (a.Real * b.Real + a.Imagine * b.Imagine) / jmenovatel,
            (a.Imagine * b.Real - a.Real * b.Imagine) / jmenovatel
        );
    }

    public static bool operator ==(Complex a, Complex b)
    {
        return a.Real == b.Real && a.Imagine == b.Imagine;
    }

    public static bool operator !=(Complex a, Complex b)
    {
        return !(a == b);
    }


    public override string ToString()
    {
        if (Imagine >= 0)
            return String.Format("{0} + {1}j",Real, Imagine);
        else
            return String.Format("{0} - {1}j", Real, -Imagine);
    }



    public Complex Sdruzene()
    {
        return new Complex(Real,-Imagine);
    }

    public Double Modul()
    {
        return Math.Sqrt(Real * Real + Imagine * Imagine);
    }


    public Double Argument()
    {
        return Math.Atan2(Imagine, Real);
    }

}

