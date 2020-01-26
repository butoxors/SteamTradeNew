using System;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class GameAttribute : Attribute
    {
        public string Game { get; }

        public GameAttribute(String game)
        {
            Game = game;
        }
    }
}
