namespace SpeedyAir.Output.Interface
{
    internal interface IOutputFactory
    {
        IOutput CreateOutput(OutputType type);
    }
}
 