namespace ModTemplate.Mod_ModID.Data.Scripts.Namespace.Common.Extensions
{
    public static class Bools
    {
        public static string ToSingleChar(this bool tf)
        {
            return tf ? "T" : "F";
        }
    }
}
