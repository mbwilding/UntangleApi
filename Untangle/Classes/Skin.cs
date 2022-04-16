//Non-nullable field is uninitialized
#pragma warning disable CS8618
// Non-accessed field
#pragma warning disable CS0414
// Unassigned field
#pragma warning disable CS0649

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnassignedField.Global

namespace Untangle.Classes;

public class Skin
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