using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcu1
{
    //this class will contail all methods for all math operations
    
 public class MathFuctions
    {
        public static double Mem=0;
        double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        double Div(double num1, double num2)
        {
            return num1/num2;
        }
        double Mul(double num1, double num2)
        {
            return num1 * num2;
        }
        double CosMy(double num1)
        {
            return Math.Cos(num1);
        }
        double Square(double num1, double num2)
        {
            return num1 * num1;
        }
        double SinMy(double num1)
        {
            return Math.Sin(num1);
        }
        double TanMy(double num1)
        {
            return Math.Tan(num1);
        }
        double CtanMy(double num1)
        {
            return 1/Math.Tan(num1);
        }
        double InvA(double num1)
        {
            if (num1 == 0) return -9999;
            return 1.0f/num1;
        }
        public double calc(double num1, double num2,string Mathopr)
        {
           double result=0;
         try{
                switch(Mathopr)
                {
               case "Add":
                   result=Add(num1,num2);
                   break;
               case "Sub":
                   result=Sub(num1,num2);
                   break;
               case "Div":
                   result = Div(num1, num2);
                   break;
               case "Mul":
                   result = Mul(num1, num2);
                   break;
               case "Square":
                   result = Mul(num1, num1);
                   break;
               case "cos":
                   result = CosMy(num1);
                   break;
               case "sin":
                   result = SinMy(num1);
                   break;
               case "tan":
                   result = TanMy(num1);
                   break;
               case "ctn":
                  result = CtanMy(num1);
                  break;
               case "InvA":
                  result = InvA(num1);
                  break;
               case "Other":
                   break;

            }    
               }
                catch(Exception)
                {
                    result=0;
                }
           return result;
            
           
        }

       }
}
