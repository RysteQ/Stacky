namespace Stacky.Models;

public class Stack
{
    public Stack()
    {
        this.data = new byte[65536];
        this.sp = 0;
    }

    public void Push(byte value)
    {
        if (this.sp < this.data.Length)
            this.data[this.sp++] = value;
        else
            throw new Exception("The SP cannot be more than 65535");
    }

    public byte Pop()
    {
        if (this.sp > 0)
            return this.data[--this.sp];
        else
            throw new Exception("The SP cannot be less than zero");
    }

    private byte[] data;
    private ushort sp;
}
