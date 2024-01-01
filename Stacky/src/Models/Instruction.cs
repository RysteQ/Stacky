namespace Stacky.src.Models;

public struct Instruction
{
    public Instruction(Opcode opcode, byte value)
    {
        Opcode = opcode;
        Value = value;
    }

    public Opcode Opcode { get; private set; }
    public byte Value { get; private set; }
}
