using System.Text;

namespace App.Tests.Common.Helpers
{
    /// <summary>
    /// Permet de simuler des entrées dans la console
    /// </summary>
    public static class ConsoleHelpers
    {
        public static void PushInReader(string row)
        {
            Console.SetIn(new StringReader($"{row}\r\n"));
        }

        public static void PushInReader(IEnumerable<string> row)
        {
            var sb = new StringBuilder();
            row.ToList().ForEach(r => sb.Append($"{r}\r\n"));

            Console.SetIn(new StringReader(sb.ToString()));
        }
    }
}
