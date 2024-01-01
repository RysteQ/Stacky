using Stacky.Models;

namespace Stacky.Stacky;

public static class Runner
{
    public static int Execute(List<Instruction> instructions)
    {
        for (int i = 0; i < instructions.Count; i++)
        {
            Instruction current_instruction = instructions[i];

            switch (current_instruction.Opcode)
            {
                case Opcode.PUSH: PUSH(current_instruction.Value); break;
                case Opcode.RPUSH: RPUSH(); break;
                case Opcode.POP: POP(); break;
                case Opcode.POPP: POPP(); break;
                case Opcode.POPPC: POPPC(); break;
                case Opcode.ADD: ADD(); break;
                case Opcode.SUB: SUB(); break;
                case Opcode.MUL: MUL(); break;
                case Opcode.DIV: DIV(); break;
                case Opcode.MOD: MOD(); break;
                case Opcode.COPY: COPY(); break;
                case Opcode.CCF: CCF(); break;
                case Opcode.CMPE: CMPE(); break;
                case Opcode.CMPL: CMPL(); break;
                case Opcode.CMPG: CMPG(); break;
                case Opcode.NEWL: NEWL(); break;
                case Opcode.HAULT: HAULT(current_instruction.Value); break;
                case Opcode.JC: i = JC(i, current_instruction.Value); break;
                case Opcode.JMP: i = JMP(i); break;
            }
        }

        return 0;
    }

    private static void PUSH(byte value) => stack.Push(value);
    private static void RPUSH() => stack.Push((byte) Console.ReadKey().KeyChar);
    private static void POP() => stack.Pop();
    private static void POPP() => Console.WriteLine(stack.Pop());
    private static void POPPC() => Console.WriteLine((char) stack.Pop());
    private static void ADD() => stack.Push((byte) (stack.Pop() + stack.Pop()));
    private static void SUB() => stack.Push((byte) (stack.Pop() - stack.Pop()));
    private static void MUL() => stack.Push((byte) (stack.Pop() * stack.Pop()));
    private static void DIV() => stack.Push((byte) (stack.Pop() / stack.Pop()));
    private static void MOD() => stack.Push((byte) (stack.Pop() % stack.Pop()));
    private static void CCF() => conditional_flag = false;
    private static void CMPE() => conditional_flag = stack.Pop() == stack.Pop();
    private static void CMPL() => conditional_flag = stack.Pop() < stack.Pop();
    private static void CMPG() => conditional_flag = stack.Pop() > stack.Pop();
    private static void NEWL() => Console.WriteLine();
    private static int JMP(int target_instruction) => target_instruction - 2;
    private static int JC(int current_instruction, int target_instruction) => conditional_flag ? target_instruction - 2 : current_instruction;

    private static void COPY()
    {
        byte copy = stack.Pop();

        stack.Push(copy);
        stack.Push(copy);
    }

    private static void HAULT(byte exit_code)
    {
        Console.ReadKey();
        Environment.Exit(exit_code);
    }

    private static Stack stack = new();
    private static bool conditional_flag = false;
}