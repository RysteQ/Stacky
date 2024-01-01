namespace Stacky.src.Models;

public class Stack
{
    public Stack()
    {
        data = new byte[65536];
        sp = 0;
    }

    public void Push(byte value)
    {
        if (sp < data.Length)
            data[sp++] = value;
        else
            throw new Exception("The SP cannot be more than 65535");
    }

    public byte Pop()
    {
        if (sp > 0)
            return data[--sp];
        else
            throw new Exception("The SP cannot be less than zero");
    }

    private byte[] data;
    private ushort sp;
}
