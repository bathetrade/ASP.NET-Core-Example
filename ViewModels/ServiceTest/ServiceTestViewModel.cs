using MvcMovie.Services;

namespace MvcMovie.ViewModels
{
    public enum Operation
    {
        Add,
        Div
    }
    public class ServiceTestViewModel
    {
        public MathService MathService;

        public int x;
        public int y;

        public Operation Operation;
    }
}