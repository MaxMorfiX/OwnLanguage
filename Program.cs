using System;
using System.IO;
using System.Text;

namespace OwnProgrammingLanguage {
    class Program {

        static string codePath = @"D:\programming\C#\OwnProgrammingLanguage\UserInputs\UserScript.ownl";

        static string[] codeLines;

        static void Main() {

            if(File.Exists(codePath)) {
                codeLines = File.ReadAllLines(codePath);
                Reader.ReadCode(codeLines);
            } else {
                Console.WriteLine("No code erroe - there's no code to execute");
            }

        }

    }
}