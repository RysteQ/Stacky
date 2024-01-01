namespace Stacky.Models;

public struct InterpreterStatus
{
    public InterpreterStatus(bool success, int line_of_failure)
    {
        this.Success = success;
        this.LineOfFailure = line_of_failure;
    }

    public bool Success { get; private set; }
    public int LineOfFailure { get; private set; }
}