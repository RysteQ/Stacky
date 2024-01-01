using Stacky.Models;
using Stacky.Services;
using Stacky.Stacky;

if (Environment.GetCommandLineArgs().Length != 2)
{
    ErrorInformer.Inform("Input file required", ConsoleColor.Red);
    Environment.Exit(-1);
}

string file_name = Environment.GetCommandLineArgs()[1];
string file_data = File.ReadAllText(file_name);
InterpreterStatus status = Interpreter.Verify(file_data);
List<Instruction> instructions = new();

if (status.Success == false)
{
    ErrorInformer.Inform($"Error at line {status.LineOfFailure}", ConsoleColor.Red);
    Environment.Exit(-1);
} else
    instructions = Interpreter.Analyze(file_data);

try
{
    Runner.Execute(instructions);
} catch (Exception ex)
{
    ErrorInformer.Inform(ex.Message, ConsoleColor.Red);
    Environment.Exit(-1);
}

Console.WriteLine("Execution finished");
Console.ReadKey();
Environment.Exit(0);