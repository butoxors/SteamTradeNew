using Attributes;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Extensions
{
    public static class EnumExtension
    {
        public static string GetDescription(this Enum value)
        {
            return
                value
                    .GetType()
                    .GetMember(value.ToString())
                    .FirstOrDefault()
                    ?.GetCustomAttribute<DescriptionAttribute>()
                    ?.Description
                ?? value.ToString();
        }

        public static string GetGameUrl<T>(this string gameType)
        {
            var prop = typeof(T).GetMembers()
                .Where(x => x.Name.Contains(gameType))
                .Select(x => x.Name)
                .First();
            return Enum.Parse(typeof(T), prop)
                .GetType()
                .GetField(prop)
                .GetCustomAttribute<DescriptionAttribute>()
                .Description;
        }

    }
}
