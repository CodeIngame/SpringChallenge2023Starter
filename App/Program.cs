namespace App
{
    using App.Common;
    using App.Manager;

    class Program
    {
        static void Main(string[] args)
        {
            using (var tracer = new Tracer(nameof(Main)))
            {
                IGameManager gm = new GameManager();
                gm.Initialize();
                // game loop
                while (true)
                {
                    gm.ReadTurn();
                    var actions = gm.Play();
                    actions.ForEach(action => Console.WriteLine(action));
                }
            }
        }
    }
}