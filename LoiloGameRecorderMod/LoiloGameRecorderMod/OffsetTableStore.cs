using LoiLo.Recording.Applications.Properties;
using LoiLo.Recording.Core;
using System;
using System.Globalization;


namespace LoiLo.Recording.Applications
{
    public class OffsetTableStore : IOffsetTableStore
    {
        private static readonly OffsetTableStore _default;
        public static OffsetTableStore Default
        {
            get
            {
                return OffsetTableStore._default;
            }
        }
        public bool HasDx9OffsetTable
        {
            get
            {
                return !string.IsNullOrEmpty(Settings.Default.Dx9DevicePresentAddressCache) && !string.IsNullOrEmpty(Settings.Default.Dx9SwapChainPresentAddressCache) && !string.IsNullOrEmpty(Settings.Default.Dx9DeviceExPresentExAddressCache) && !string.IsNullOrEmpty(Settings.Default.Dx9FilePath);
            }
        }
        public bool HasDxgiOffsetTable
        {
            get
            {
                return !string.IsNullOrEmpty(Settings.Default.DxgiSwapChainPresentAddressCache) && !string.IsNullOrEmpty(Settings.Default.DxgiFilePath);
            }
        }
        static OffsetTableStore()
        {
            OffsetTableStore._default = new OffsetTableStore();
        }
        public Dx9OffsetTable RestoreDx9OffsetTable()
        {
            return new Dx9OffsetTable(ulong.Parse(Settings.Default.Dx9DevicePresentAddressCache, CultureInfo.InvariantCulture), ulong.Parse(Settings.Default.Dx9SwapChainPresentAddressCache, CultureInfo.InvariantCulture), ulong.Parse(Settings.Default.Dx9DeviceExPresentExAddressCache, CultureInfo.InvariantCulture), Settings.Default.Dx9FilePath);
        }
        public void StoreDx9OffsetTable(Dx9OffsetTable offsetTable)
        {
            Settings.Default.Dx9DevicePresentAddressCache = offsetTable.DevicePresentOffset.ToString(CultureInfo.InvariantCulture);
            Settings.Default.Dx9SwapChainPresentAddressCache = offsetTable.SwapChainPresentOffset.ToString(CultureInfo.InvariantCulture);
            Settings.Default.Dx9DeviceExPresentExAddressCache = offsetTable.DeviceExPresentExOffset.ToString(CultureInfo.InvariantCulture);
            Settings.Default.Dx9FilePath = offsetTable.FilePath;
        }
        public DxgiOffsetTable RestoreDxgiOffsetTable()
        {
            return new DxgiOffsetTable(ulong.Parse(Settings.Default.DxgiSwapChainPresentAddressCache, CultureInfo.InvariantCulture), Settings.Default.DxgiFilePath);
        }
        public void StoreDxgiOffsetTable(DxgiOffsetTable offsetTable)
        {
            Settings.Default.DxgiSwapChainPresentAddressCache = offsetTable.SwapChainPresentOffset.ToString(CultureInfo.InvariantCulture);
            Settings.Default.DxgiFilePath = offsetTable.FilePath;
        }
    }
}
