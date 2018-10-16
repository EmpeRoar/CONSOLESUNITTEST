using System;

namespace CONSOLESUNITTEST
{

    public interface ITurtleState
    {
        int XPos { get; set; }
        int YPos { get; set; }
    }

    public class TurtleState : ITurtleState
    {
        public int XPos { get; set; } = 0;
        public int YPos { get; set; } = 0;
    }

    public interface ITurtle
    {
        void Move();
        ITurtleState GetState();
    }

    public class Turtle : ITurtle
    {
        ITurtleState _turtleState;
        public Turtle(ITurtleState turtleState)
        {
            _turtleState = turtleState;
        }

        public ITurtleState GetState() => _turtleState;

        public void Move()
        {
            _turtleState.XPos++;
            _turtleState.YPos++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var turtleState = new TurtleState();
            var turtle = new Turtle(turtleState);
            turtle.Move();
            turtle.Move();
            Console.WriteLine($"{turtle.GetState().XPos}-{turtle.GetState().YPos}");
            Console.ReadLine();
        }
    }
}
