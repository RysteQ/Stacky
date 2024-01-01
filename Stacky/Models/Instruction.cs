namespace Stacky.Models;

public struct Instruction
{
    public Instruction(int line, Opcode opcode, byte value)
    {
        this.Opcode = opcode;
        this.Value = value;
    }

    public Opcode Opcode { get; private set; }
    public byte Value { get; private set; }
}
