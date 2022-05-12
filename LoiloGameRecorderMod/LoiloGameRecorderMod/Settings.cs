using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
namespace LoiLo.Recording.Applications.Properties
{
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0"), CompilerGenerated]
    internal sealed class Settings : ApplicationSettingsBase
    {
        private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
        public static Settings Default
        {
            get
            {
                return Settings.defaultInstance;
            }
        }
        [DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
        public string SaveDirectoryPath
        {
            get
            {
                return (string)this["SaveDirectoryPath"];
            }
            set
            {
                this["SaveDirectoryPath"] = value;
            }
        }
        [DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode]
        public int ResolutionPreset
        {
            get
            {
                return (int)this["ResolutionPreset"];
            }
            set
            {
                this["ResolutionPreset"] = value;
            }
        }
        [DefaultSettingValue("3"), UserScopedSetting, DebuggerNonUserCode]
        public int FpsPreset
        {
            get
            {
                return (int)this["FpsPreset"];
            }
            set
            {
                this["FpsPreset"] = value;
            }
        }
        [DefaultSettingValue("80"), UserScopedSetting, DebuggerNonUserCode]
        public int JpegQuality
        {
            get
            {
                return (int)this["JpegQuality"];
            }
            set
            {
                this["JpegQuality"] = value;
            }
        }
        [ApplicationScopedSetting, DefaultSettingValue("http://loilo.tv/"), DebuggerNonUserCode]
        public string LoiLoScopeURL
        {
            get
            {
                return (string)this["LoiLoScopeURL"];
            }
        }
        [DefaultSettingValue("117"), UserScopedSetting, DebuggerNonUserCode]
        public int ShortCutKeyRec
        {
            get
            {
                return (int)this["ShortCutKeyRec"];
            }
            set
            {
                this["ShortCutKeyRec"] = value;
            }
        }
        [ApplicationScopedSetting, DefaultSettingValue("\"explorer\",\"SndVol\",\"devenv\",\"LoiLoScopeLauncher\",\"rundll32\""), DebuggerNonUserCode]
        public string IgnoreList
        {
            get
            {
                return (string)this["IgnoreList"];
            }
        }
        [DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
        public bool IsSettingUpgraded
        {
            get
            {
                return (bool)this["IsSettingUpgraded"];
            }
            set
            {
                this["IsSettingUpgraded"] = value;
            }
        }
        [ApplicationScopedSetting, DefaultSettingValue("\"iexplore\",\"chrome\",\"firefox\",\"WWAHost\",\"LoiLoScope\""), DebuggerNonUserCode]
        public string ForceWindowModeList
        {
            get
            {
                return (string)this["ForceWindowModeList"];
            }
        }
        [DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
        public string Dx9DevicePresentAddressCache
        {
            get
            {
                return (string)this["Dx9DevicePresentAddressCache"];
            }
            set
            {
                this["Dx9DevicePresentAddressCache"] = value;
            }
        }
        [DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
        public string Dx9SwapChainPresentAddressCache
        {
            get
            {
                return (string)this["Dx9SwapChainPresentAddressCache"];
            }
            set
            {
                this["Dx9SwapChainPresentAddressCache"] = value;
            }
        }
        [DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
        public string DxgiSwapChainPresentAddressCache
        {
            get
            {
                return (string)this["DxgiSwapChainPresentAddressCache"];
            }
            set
            {
                this["DxgiSwapChainPresentAddressCache"] = value;
            }
        }
        [DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
        public string Dx9FilePath
        {
            get
            {
                return (string)this["Dx9FilePath"];
            }
            set
            {
                this["Dx9FilePath"] = value;
            }
        }
        [DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
        public string DxgiFilePath
        {
            get
            {
                return (string)this["DxgiFilePath"];
            }
            set
            {
                this["DxgiFilePath"] = value;
            }
        }
        [ApplicationScopedSetting, DefaultSettingValue("http://www.youtube.com/signup?next=/"), DebuggerNonUserCode]
        public string YoutubeSigninURL
        {
            get
            {
                return (string)this["YoutubeSigninURL"];
            }
        }
        [ApplicationScopedSetting, DefaultSettingValue(""), DebuggerNonUserCode]
        public string OverrideUILang
        {
            get
            {
                return (string)this["OverrideUILang"];
            }
        }
        [ApplicationScopedSetting, DefaultSettingValue("2"), DebuggerNonUserCode]
        public int MaxVideoEncodeAsyncDepth
        {
            get
            {
                return (int)this["MaxVideoEncodeAsyncDepth"];
            }
        }
        [ApplicationScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode]
        public int VideoDeliverTimeoutMilliseconds
        {
            get
            {
                return (int)this["VideoDeliverTimeoutMilliseconds"];
            }
        }
        [DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
        public string Dx9DeviceExPresentExAddressCache
        {
            get
            {
                return (string)this["Dx9DeviceExPresentExAddressCache"];
            }
            set
            {
                this["Dx9DeviceExPresentExAddressCache"] = value;
            }
        }
        [DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
        public bool SkipStatusDrawing
        {
            get
            {
                return (bool)this["SkipStatusDrawing"];
            }
            set
            {
                this["SkipStatusDrawing"] = value;
            }
        }
        [DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
        public bool IsMicEnabled
        {
            get
            {
                return (bool)this["IsMicEnabled"];
            }
            set
            {
                this["IsMicEnabled"] = value;
            }
        }
        [DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
        public string MicDeviceId
        {
            get
            {
                return (string)this["MicDeviceId"];
            }
            set
            {
                this["MicDeviceId"] = value;
            }
        }
        [DefaultSettingValue("True"), UserScopedSetting, DebuggerNonUserCode]
        public bool IsAudioDuckingEnabled
        {
            get
            {
                return (bool)this["IsAudioDuckingEnabled"];
            }
            set
            {
                this["IsAudioDuckingEnabled"] = value;
            }
        }
        [DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
        public bool IsVideoFrameInterpolationEnabled
        {
            get
            {
                return (bool)this["IsVideoFrameInterpolationEnabled"];
            }
            set
            {
                this["IsVideoFrameInterpolationEnabled"] = value;
            }
        }
        [ApplicationScopedSetting, DefaultSettingValue("http://loiloscope.loilo.tv/news/loilogr/info.xml"), DebuggerNonUserCode]
        public string CurrentVersionURL
        {
            get
            {
                return (string)this["CurrentVersionURL"];
            }
        }
    }
}
