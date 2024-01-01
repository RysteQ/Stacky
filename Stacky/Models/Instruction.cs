namespace Stacky.Models;

public struct Instruction
{
    public Instruction(int line, Opcode opcode, string name, byte value)
    {
        this.Line = line;
        this.Opcode = opcode;
        this.Name = name;
        this.Value = value;
    }

    public int Line { get; private set; }
    public Opcode Opcode { get; private set; }
    public string Name { get; private set; }
    public byte Value { get; private set; }
}
