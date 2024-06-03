using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_GoltsevNS
{
    public class Operations
    {


        public bool isDeg { get; set; }

        public Dictionary<string, double> Special_Num = new Dictionary<string, double>()
        {
            { "Pi", Math.PI},
            { "Exp", Math.Exp(1)}
        };
        public Operations() { }

        public double Convert_to(String num)
        {
            double res = 0;
            if (Special_Num.ContainsKey(num))
            {
                res = Special_Num[num];
            }
            else { res = Convert.ToDouble(num); }

            return res;
        }

        public static int Factorial(int number)
        {
            if (number == 1 || number == 0)
                return 1;
            else
                return number * Factorial(number - 1);
        }

        // list for operations with two argue
        public String stat_of_div = "";
        public double CalcRes(String oper, params string[] argNums)
        {
            double res = 0;
            stat_of_div = "";

            if (argNums.Length == 1)
            {
                res = Special_Op(oper, Convert_to(argNums[0]));
            }
            else
            {
                res = Average_Op(oper, Convert_to(argNums[0]), Convert_to(argNums[1]));
                
            }
            return res;
        }

        //Methods into switch/case
        public double Average_Op(String oper, double argNumsFst, double argNumsScn)
        {
            double res = 0;
            switch (oper)
            {
                case "+":
                    res = argNumsFst + argNumsScn;
                    break;

                case "-":
                    res = argNumsFst - argNumsScn;
                    break;

                case "*":
                    res = argNumsFst * argNumsScn;
                    break;

                case "/":
                    if (argNumsScn == 0)
                    {
                        stat_of_div = "Cannot div by zero";
                    }
                    else
                    {
                        res = argNumsFst / argNumsScn;
                    }
                    break;

                case "^":
                    res = Math.Pow(argNumsFst, argNumsScn);
                    break;
            }
            return res;
        }
        //Alterntive operations
        List<string> trg_ops = new List<string>() { "sin(x)", "cos(x)", "tg(x)", "ctg(x)" };
        public double Special_Op(String op, double argNum)
        {
            double res = 0;
            if (trg_ops.Any(op))
            {
                res = trigOperations(op, argNum);
            }
            else
            {
                switch (op)
                {
                    case "n!":
                        res = Factorial(Convert.ToInt32(argNum));
                        break;

                    case "x^2":
                        res = Math.Pow(argNum, 2);
                        break;

                    case "10x":
                        res = argNum * 10;
                        break;

                    case "sqrt(x)":
                        res = Math.Sqrt(argNum);
                        break;

                    case "ln(x)":
                        res = Math.Log(argNum);
                        break;
                }

            }

            return res;
        }


        // Радиан — угол, соответствующий дуге, длина которой равна её радиусу
        public double ConvertDegreesToRadians(double degrees)
        {
            double radians = (Math.PI / 180) * degrees;
            return (radians);
        }

        private double trigOperations(string op, double num)
        {
            double res = 0;
            double loc_num = num;
            if (isDeg) loc_num = ConvertDegreesToRadians(num);

            switch (op)
            {
                case "sin(x)":
                    res = Math.Sin(num);
                    break;

                case "cos(x)":
                    res = Math.Cos(num);
                    break;

                case "tg(x)":
                    res = Math.Tan(num);
                    break;

                case "ctg(x)":
                    res = Math.Pow(Math.Tan(num), -1);
                    break;
            }
            return res;
        }
    }
}
