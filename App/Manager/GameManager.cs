

namespace App.Manager
{
    using App.Common;
    using App.Entities;
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
