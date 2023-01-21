using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnProgrammingLanguage {
    class Reader {

        public static int[] vars = new int[100];
        public static int currLineNum;

        public static void ReadCode(string[] lines) {

            for(currLineNum = 0; currLineNum < lines.Length; currLineNum++) {

                //Console.WriteLine("line " + (currLineNum + 1));

                string line = lines[currLineNum];

                if(line.StartsWith("/")) continue;

                string[] parts = line.Split(' ');

                //commandName getting
                string commandName = parts[0];

                //creating params

                string[] parameters = new string[parts.Length];

                for(int i = 1; i < parts.Length; i++) {
                    parameters[i - 1] = parts[i];
                }

                //Console.WriteLine("commandName = " + commandName + ", parameters = " + parameters[0] + ", " + parameters[1]);

                //set command
                if(commandName == "set") {
                    ref int variable = ref vars[Convert.ToInt32(parameters[0])];
                    int value = Convert.ToInt32(parameters[1]);

                    Commands.set(ref variable, value);
                }
                //get command
                if(commandName == "get") {
                    ref int variable = ref vars[Convert.ToInt32(parameters[0])];

                    Commands.get(ref variable);
                }

                //log command
                if(commandName == "log") {
                    int variable = vars[Convert.ToInt32(parameters[0])];

                    Commands.log(variable);
                }

                //sum command
                if(commandName == "sum" || commandName == "add") {
                    int a = vars[Convert.ToInt32(parameters[0])];
                    int b = vars[Convert.ToInt32(parameters[1])];
                    ref int resultVar = ref vars[Convert.ToInt32(parameters[2])];

                    Commands.sum(a, b, ref resultVar);
                }

                // subtract command
                if(commandName == "subtr" || commandName == "subtract") {
                    int a = vars[Convert.ToInt32(parameters[0])];
                    int b = vars[Convert.ToInt32(parameters[1])];
                    ref int resultVar = ref vars[Convert.ToInt32(parameters[2])];

                    Commands.subtract(a, b, ref resultVar);
                }
                if(commandName == "mult") {
                    int a = vars[Convert.ToInt32(parameters[0])];
                    int b = vars[Convert.ToInt32(parameters[1])];
                    ref int resultVar = ref vars[Convert.ToInt32(parameters[2])];

                    Commands.mult(a, b, ref resultVar);
                }
                if(commandName == "divide" || commandName == "div") {
                    int a = vars[Convert.ToInt32(parameters[0])];
                    int b = vars[Convert.ToInt32(parameters[1])];
                    ref int resultVar = ref vars[Convert.ToInt32(parameters[2])];

                    Commands.divide(a, b, ref resultVar);
                }

                //ifgo command
                if(commandName == "ifgo") {
                    int a = vars[Convert.ToInt32(parameters[0])];
                    string op = parameters[1];
                    int b = vars[Convert.ToInt32(parameters[2])];
                    int lineNum = vars[Convert.ToInt32(parameters[3])];

                    Commands.ifgo(a, op, b, lineNum);

                }

                //goTo command
                if(commandName == "goTo") {
                    int lineNum = vars[Convert.ToInt32(parameters[0])];

                    Commands.goTo(lineNum);
                }

            }
            
        }

    }
}
