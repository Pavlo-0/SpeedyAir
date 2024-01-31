using SpeedyAir.Output.Interface;

namespace SpeedyAir.Output
{
    internal class OutputFactory : IOutputFactory
    {
        public IOutput CreateOutput(OutputType type)
        {
            switch (type)
            {
                case OutputType.Console:
                    return new ConsoleOutput();
                default: throw new NotImplementedException($"Output {type} haven't been implemented");
            }
        }
    }
}
 