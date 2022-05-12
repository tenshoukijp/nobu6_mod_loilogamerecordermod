//----------
using System;
using System.Runtime.InteropServices;


using LoiLo.Recording;
using LoiLo.Recording.Core;
using LoiLo.Recording.Facades;
using LoiLo.Utils.Desktop;
using LoiLo.Utils.Interop;
using LoiLo.Recording.Applications;
using LoiLo.Recording.Applications.Properties;


public partial class LoiloGameRecorderMod {

   private static RecordingFacade _recordingFacade;

   public static void StartRecording(IntPtr hWndMyself, IntPtr hWndTarget, String strMovieFileFullPath)
   {
       _recordingFacade = new RecordingFacade(RecorderMode.ScreenShot);
       // mode:0:DirectX(高速で対象のウィンドウを録画。対象のアプリがDirectX系で描画されている場合のみ可能)。隠れても問題がない。
       // mode:1:Window(中速で対象のウィンドウのみを録画。対象のウィンドウが)。隠れても問題が無い。
       // mode:2:デスクトップScreenShot。デスクトップ上の対象のウィンドウの範囲を録画。隠れたりかぶったりすると、そのまま録画も被ってしまう。

        if (hWndMyself == IntPtr.Zero) { return; }
        if (hWndTarget == IntPtr.Zero) { return; }

        RecordNotifyTarget hRNTarget = new RecordNotifyTarget(hWndMyself, 32769, 32770); // #32769 デスクトップウィンドウ、32770=ダイアログボックス
        _recordingFacade.Setup(hRNTarget, 30, false, "", OffsetTableStore.Default); // 30フレーム、マイクなし、マイクデバイス空白、ロイロ内部が利用するテーブルはデフォルト
        // this._recordingFacade.SetStatusDrawingEnable(!Settings.Default.SkipStatusDrawing);

        // レコーダーとなるウィンドウ。自分自身のこと。
        WindowProcessIdentity hWPITarget = WindowProcessIdentity.From(hWndTarget);
        // 自分自身を登録。一応ここでモードも登録。
        _recordingFacade.SetTarget(hWPITarget, RecorderMode.WindowShot);


        // .aviとして保存するフルパスでのファイル名
        string filePath = strMovieFileFullPath;

        // 解像度の情報。デフォルト値はプリセットから。
        ResolutionPreset preset = ResolutionPresetConverter.PresetAt(Settings.Default.ResolutionPreset);
        Int32Size size = preset.PresetToSize(); // 縦と横。デフォルトは空でウィンドウサイズ。

        // フレームレートの値。これもデフォルト値から
        FpsPreset preset2 = FpsPresetConverter.PresetAt(Settings.Default.FpsPreset);
        long avg100NsPerFrame = preset2.PresetToAvg100NsPerFrame(); // そこから、実際のフレームレートの数値へ。デフォルトは30

        /// jpegのクオリティもデフォルト値から数値へ。デフォは80
        int jpegQuality = JpegQualityPreset.Clip(Settings.Default.JpegQuality);
        RecordSettings settings = new RecordSettings(filePath, size, avg100NsPerFrame, jpegQuality, Settings.Default.MaxVideoEncodeAsyncDepth, Settings.Default.VideoDeliverTimeoutMilliseconds, Settings.Default.IsVideoFrameInterpolationEnabled);
        LoiloGameRecorderMod._recordingFacade.StartRecording(settings, Settings.Default.IsMicEnabled && Settings.Default.IsAudioDuckingEnabled);

    }

    public static void StopRecording()
    {
        LoiloGameRecorderMod._recordingFacade.StopRecording();
    }

    // WindowsのRECT型
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








