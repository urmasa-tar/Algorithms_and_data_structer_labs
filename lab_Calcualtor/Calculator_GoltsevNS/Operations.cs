using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_GoltsevNS
{
    public class Operations
    {


        public bool isDeg { get; set; }

        public Operations() { }

        // list for operations with two argue
        public String stat_of_div = "";
        public double CalcRes(String oper, params double[] argNums)
        {
            double res = 0;
            stat_of_div = "";

            if (argNums.Length == 1)
            {
                res = Special_Op(oper, argNums[0]);
            }
            else
            {
                switch (oper)
                {
                    case "+":
                        res = argNums[0] + argNums[1];
                        break;

                    case "-":
                        res = argNums[0] - argNums[1];
                        break;

                    case "*":
                        res = argNums[0] * argNums[1];
                        break;

                    case "/":
                        if (argNums[1] == 0)
                        {
                            stat_of_div = "Cannot div by zero";
                        }
                        else
                        {
                            res = argNums[0] / argNums[1];
                        }
                        break;

                    case "^":
                        res = Math.Pow(argNums[0], argNums[1]);
                        break;
                }
            }
            return res;
        }

        //Methods into switch/case

        //Alterntive operations
        public double Special_Op(String op, double argNum)
        {
            double res = 0;

            switch (op)
            {
                case "sin(x)":
                    res = Math.Sin(argNum);
                    break;

                case "cos(x)":
                    res = Math.Cos(argNum);
                    break;

                case "tg(x)":
                    res = Math.Tan(argNum);
                    break;

                case "ctg(x)":
                    res = Math.Pow(Math.Tan(argNum), -1); ;
                    res = 0;
                    break;
            }

            return res;
        }


        // Радиан — угол, соответствующий дуге, длина которой равна её радиусу
        private double NumToDeg(double num) { return 3.6; }

    }
}
