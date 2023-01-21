using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ownProgrammingLanguage {
    class Commands {

        public static void set(ref int variable, int value) {
            variable = value;
        }
        public static void log(int value) {
            Console.WriteLine(value);
        }
        public static void log(string value) {
            Console.WriteLine(value);
        }
        public static void sum(int a, int b, ref int resultVariable) {
            set(ref resultVariable, a + b);
        }
        public static void mult(int a, int b, ref int resultVariable) {
            set(ref resultVariable, a * b);
        }
        public static void divide(int a, int b, ref int resultVariable) {
            set(ref resultVariable, a / b);
        }
        public static void subtract(int a, int b, ref int resultVariable) {
            set(ref resultVariable, a - b);
        }
        public static void goTo(int lineNum) {
            //Console.WriteLine("go to line " + lineNum);

            //first - is bc lines are in array and start from 0 while in file they start from 1
            //second - is bc after interpretator does this command it does i++ before next command
            Reader.currLineNum = lineNum - 2;
        }
        public static void ifgo(int a, string op, int b, int linenum) {

            //Console.WriteLine("if " + a + " " + op + " " + b + " go to " + linenum);

            if(op == "<" && a < b) {
                goTo(linenum);
            }
            if(op == "=" && a == b) {
                goTo(linenum);
            }
            if(op == ">" && a > b) {
                goTo(linenum);
            }

        }


    }
}
