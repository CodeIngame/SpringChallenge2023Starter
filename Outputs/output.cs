namespace App.Common.Helpers
{
    using System;

    public class SystemHelpers
    {
        /// <summary>
        /// Permet de lire la ligne et de retourner son contenu
        /// Log si nécessaire l'information lue
        /// </summary>
        /// <param name="newLine"></param>
        /// <param name="debug"></param>
        /// <returns></returns>
        public static string ReadLine(bool newLine = true, bool debug = true, LogLevel loglevel = LogLevel.Information)
        {
            var msg = Console.ReadLine();
            if (debug)
            {
                if (newLine)
                    WriteLineLog($"\"{msg}\"", loglevel);
                else
                    WriteLog($"\"{msg}\",", loglevel);
            }

            return msg;
        }

        /// <summary>
        /// Write a new line of log
        /// </summary>
        /// <param name="log"></param>
        /// <param name="logLevel"></param>
        public static void WriteLineLog(string log, LogLevel logLevel = LogLevel.Verbose)
        {
            Write(log, logLevel, true);
        }

        /// <summary>
        /// Write log on same line
        /// </summary>
        /// <param name="log"></param>
        /// <param name="logLevel"></param>
        public static void WriteLog(string log, LogLevel logLevel = LogLevel.Verbose)
        {
            Write(log, logLevel, false);
        }

        private static void Write(string log, LogLevel logLevel = LogLevel.Verbose, bool newLine = false)
        {
            if (logLevel >= LogLevel.Warning)
            {
                if (newLine)
                    Console.Error.WriteLine(log);
                else
                    Console.Error.Write(log);
            }
        }
    }
}
namespace App.Common
{
    public enum LogLevel
    {
        Verbose = 0,
        Debug,
        Information,
        Warning,
        Critical
    }
}
namespace App.Common
{
    using App.Common.Helpers;
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Permet de logger le temps d'exécution d'une méthode
    /// </summary>
    public class Tracer
        : IDisposable
    {
        private Stopwatch Sw;
        private string Method;
        private string Start;
        private string End;
        private string Text = string.Empty;
        private LogLevel LogLevel;


        public Tracer(string method, string startText = "", string endText = "", LogLevel logLevel = LogLevel.Warning)
        {
            Method = method;
            Start = startText;
            End = endText;
            LogLevel = logLevel;
            Sw = new Stopwatch();
            Sw.Start();
            if (!string.IsNullOrEmpty(startText))
                SystemHelpers.WriteLineLog($"[{Method}]({Start})", logLevel);
        }

        public void AddText(string text)
        {
            Text += text;
        }

        public void ChangeLogLevel(LogLevel loglevel)
        {
            LogLevel = loglevel;
        }

        public void WriteLog(string msg)
        {
            SystemHelpers.WriteLineLog($"[{Method}] - {msg}", LogLevel);
        }

        public void Dispose()
        {
            Sw.Stop();
            var isMs = Sw.Elapsed.TotalMilliseconds < 1000;
            var unit = isMs ? "ms" : "s";
            var value = isMs ? Sw.Elapsed.TotalMilliseconds : Sw.Elapsed.TotalSeconds;
            var withMoreText = string.IsNullOrEmpty(Text) ? string.Empty : $" - {Text}";
            if (!string.IsNullOrEmpty(withMoreText))
                SystemHelpers.WriteLineLog($"[{Method}] ({withMoreText})", LogLevel);

            if (!string.IsNullOrEmpty(End))
                SystemHelpers.WriteLineLog($"[{Method}]({End}) took [{value}{unit}]", LogLevel);
        }
    }
}
namespace App.Entities
{
    /// <summary>
    /// Gère le contexte du jeu
    /// </summary>
    public class Game
    {
    }
}
namespace App.Manager
{
    using App.Common;
    using App.Entities;
    using System;
    using System.Collections.Generic;

    public interface IGameManager
    {
        /// <summary>
        /// Initialise le jeu
        /// </summary>
        void Initialize();
        /// <summary>
        /// Lit les données d'un tours
        /// </summary>
        void ReadTurn();
        /// <summary>
        /// Joue un tours
        /// </summary>
        /// <returns></returns>
        List<string> Play();
    }

    public class GameManager
        : IGameManager
    {
        #region Private Fields
        public Game Game { get; init; } = new();
        #endregion Private Fields


        public void Initialize()
        {
            using (var tracer = new Tracer(nameof(Initialize)))
            {
                // Pour lire les entrées du jeu ->
                // var inputs = SystemHelpers.ReadLine(debug: true);
                // a la place de 
                // Console.ReadLine();

                // Ainsi les entrées seront loggées en debug puis retournées dans un but de DEBUGAGE

                throw new NotImplementedException();
            }
        }

        public void ReadTurn()
        {
            using (var tracer = new Tracer(nameof(ReadTurn)))
            {
                throw new NotImplementedException();
            }
        }

        public List<string> Play()
        {
            // TODO : Implémenter la logique du jeu
            // A Adapter dans le cas où le jeu ne demande pas une liste d'actions en retour!
            using (var tracer = new Tracer(nameof(Play)))
            {
                throw new NotImplementedException();
            }
        }
    }
}
namespace App
{
    using App.Common;
    using App.Manager;
    using System;

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
