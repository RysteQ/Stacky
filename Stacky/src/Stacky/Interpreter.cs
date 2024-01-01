using Stacky.src.Models;

namespace Stacky.src.Stacky;

public static class Interpreter
{
    public static InterpreterStatus Verify(string source_code)
    {
        string[] lines = source_code.Split('\n').Where(line => string.IsNullOrWhiteSpace(line) == false).Select(line => line.Trim().ToUpper()).ToArray();

        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains(' ') == false)
            {
                if (IsOpcodeValid(lines[i]) == false)
                    return new(false, i + 1);

                if (NO_OPERAND_OPCODES.Contains(Enum.Parse<Opcode>(lines[i])) == false)
                    return new(false, i + 1);
            }
            else if (lines[i].Contains(' '))
            {
                if (IsOpcodeValid(lines[i].Split(' ')[0]) == false || IsValueValid(lines[i].Split(' ')[1]) == false)
                    return new(false, i + 1);

                if (OPERAND_OPCODES.Contains(Enum.Parse<Opcode>(lines[i].Split(' ')[0])) == false)
                    return new(false, i + 1);
            }
            else
            {
                return new(false, i + 1);
            }
        }

        return new(true, -1);
    }

    public static List<Instruction> Analyze(string source_code)
    {
        List<Instruction> instructions = new();
        string[] lines = source_code.Split('\n').Where(line => string.IsNullOrWhiteSpace(line) == false).Select(line => line.Trim().ToUpper()).ToArray();

        for (int i = 0; i < lines.Length; i++)
        {
            Opcode opcode = Enum.Parse<Opcode>(lines[i].Split(' ')[0]);
            byte value = 0;

            if (lines[i].Contains(' '))
                value = byte.Parse(lines[i].Split(' ')[1]);

            instructions.Add(new(opcode, value));
        }

        return instructions;
    }

    private static bool IsOpcodeValid(string opcode) => Enum.TryParse<Opcode>(opcode, out _);
    private static bool IsValueValid(string value) => byte.TryParse(value, out _);

    private static readonly Opcode[] NO_OPERAND_OPCODES = new Opcode[]
    {
        Opcode.POP,
        Opcode.POPP,
        Opcode.POPPC,
        Opcode.ADD,
        Opcode.SUB,
        Opcode.MUL,
        Opcode.DIV,
        Opcode.MOD,
        Opcode.COPY,
        Opcode.CCF,
        Opcode.CMPE,
        Opcode.CMPL,
        Opcode.CMPG,
        Opcode.JMP,
        Opcode.RPUSH,
        Opcode.NEWL
    };

    private static readonly Opcode[] OPERAND_OPCODES = new Opcode[]
    {
        Opcode.PUSH,
        Opcode.JC,
        Opcode.HAULT
    };
}