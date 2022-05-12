//----------
using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using LoiLo.Recording;
using LoiLo.Recording.Core;
using LoiLo.Recording.Facades;
using LoiLo.Utils.Desktop;
using LoiLo.Utils.Interop;
using LoiLo.Recording.Applications;
using LoiLo.Recording.Applications.Properties;
using log4net;


namespace LoiloGameRecorderForm
{
    public partial class MainForm : Form
    {

        public RecordingFacade _recordingFacade;

        private void MainForm_Shown(Object o, EventArgs e)
        {
            _recordingFacade = new RecordingFacade(RecorderMode.ScreenShot); // mode:2相当

            // スコアエンジンの左上の座標
            IntPtr hWndScore = FindWindow("scorengine", null);
            if (hWndScore == IntPtr.Zero) {
                return;
            }

            RecordNotifyTarget target = new RecordNotifyTarget(this.Handle, 32769, 32770);
            _recordingFacade.Setup(target, 30, false, "", OffsetTableStore.Default);
            // this._recordingFacade.SetStatusDrawingEnable(!Settings.Default.SkipStatusDrawing);

            // レコーダーとなるウィンドウ。自分自身のこと。
            WindowProcessIdentity hWndTarget = WindowProcessIdentity.From(hWndScore);
            // 自分自身を登録。一応ここでモードも登録。
            _recordingFacade.SetTarget(hWndTarget, RecorderMode.WindowShot);

            // ファイル名
            string filePath = @"C:\LOILO\a.avi";
            // 解像度の情報。デフォルト値はプリセットから。
            ResolutionPreset preset = ResolutionPresetConverter.PresetAt(Settings.Default.ResolutionPreset);
            Int32Size size = preset.PresetToSize(); // 縦と横。デフォルトは空でウィンドウサイズ。

            // フレームレートの値。これもデフォルト値から
            FpsPreset preset2 = FpsPresetConverter.PresetAt(Settings.Default.FpsPreset);
            long avg100NsPerFrame = preset2.PresetToAvg100NsPerFrame(); // そこから、実際のフレームレートの数値へ。デフォルトは30

            /// jpegのクオリティもデフォルト値から数値へ。デフォは80
            int jpegQuality = JpegQualityPreset.Clip(Settings.Default.JpegQuality);
            RecordSettings settings = new RecordSettings(filePath, size, avg100NsPerFrame, jpegQuality, Settings.Default.MaxVideoEncodeAsyncDepth, Settings.Default.VideoDeliverTimeoutMilliseconds, Settings.Default.IsVideoFrameInterpolationEnabled);
            this._recordingFacade.StartRecording(settings, Settings.Default.IsMicEnabled && Settings.Default.IsAudioDuckingEnabled);

        }

        private void MainForm_Closing(Object o, FormClosingEventArgs e)
        {
            this._recordingFacade.StopRecording();
        }

        [StructLayout(LayoutKind.Sequential)]
        struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowRect(IntPtr hwnd, ref RECT lpRect);
    }
}







