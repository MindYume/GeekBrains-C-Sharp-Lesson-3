using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public struct Complex
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        public override string ToString()
        {
            return $"{re} + {im}i";
        }

        public static Complex Plus(Complex x, Complex y)
        {
            Complex z = new Complex();

            z.re = x.re + y.re;
            z.im = x.im + y.im;

            return z;
        }

        public static Complex Minus(Complex x, Complex y)
        {
            Complex z = new Complex();

            z.re = x.re - y.re;
            z.im = x.im - y.im;

            return z;
        }

        public static Complex Multiply(Complex x, Complex y)
        {
            Complex z = new Complex();

            z.re = x.re * y.re;
            z.im = x.im * y.im;

            return z;
        }

        public static Complex Divide(Complex x, Complex y)
        {
            Complex z = new Complex();

            z.re = x.re / y.re;
            z.im = x.im / y.im;

            return z;
        }
    }


    public class ComplexClass
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double re;

        public double Re
        {
            set { re = value; }
            get { return re; }
        }

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double im;

        public double Im
        {
            set { im = value; }
            get { return im; }
        }

        public ComplexClass(double re, double im)
        { 
            this.re = re;
            this.im = im;
        }

        public ComplexClass()
        {
            this.re = 0;
            this.im = 0;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }

        public static ComplexClass Plus(ComplexClass x, ComplexClass y)
        {
            ComplexClass z = new ComplexClass();

            z.re = x.re + y.re;
            z.im = x.im + y.im;

            return z;
        }

        public static ComplexClass Minus(ComplexClass x, ComplexClass y)
        {
            ComplexClass z = new ComplexClass();

            z.re = x.re - y.re;
            z.im = x.im - y.im;

            return z;
        }

        public static ComplexClass Multiply(ComplexClass x, ComplexClass y)
        {
            ComplexClass z = new ComplexClass();

            z.re = x.re * y.re;
            z.im = x.im * y.im;

            return z;
        }

        public static ComplexClass Divide(ComplexClass x, ComplexClass y)
        {
            ComplexClass z = new ComplexClass();

            z.re = x.re / y.re;
            z.im = x.im / y.im;

            return z;
        }
    }
}
