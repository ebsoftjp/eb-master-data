namespace eBMasterData
{
    public static class Paths
    {
        public const string NameSpace = "MasterData";
        public static string BasePath = $"Assets/{NameSpace}";
        public const string OpenWindowPath = "Window/eB Master Data/DB class convert";

        public const string SettingsPath = "eBMasterData/Settings";
        public static string SettingsFullPath => $"{BasePath}/Resources/{SettingsPath}.asset";
        public static string DataPath => $"eBMasterData/Data";
        public static string DataFullPath => $"{BasePath}/Resources/{DataPath}.asset";
        public static string AsmFullPath => $"{BasePath}/{NameSpace}.asmdef";
    }
}
