#pragma warning disable CS8618 | Non-nullable field is uninitialized

// ReSharper disable ClassNeverInstantiated.Global

namespace UntangleApi.Classes;

public class SkinClass
{
    public class SkinSettings
    {
        public string JavaClass;
        public string SkinName;
    }
    
    public class SkinInfo
    {
        public bool AdminSkin;
        public bool AdminSkinOutOfDate;
        public string JavaClass;
        public string DisplayName;
        public string ExtJsTheme;
        public uint AdminSkinVersion;
        public string Name;
        public string AppsViewType;
    }
}