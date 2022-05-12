#include <windows.h>

using namespace System;

#pragma comment(lib, "user32.lib")

int main(array<System::String ^> ^args)
{
    Console::WriteLine(L"Hello World");

	// ウィンドウハンドルを得る
	HWND hWnd = FindWindow(L"Tenshouki95", NULL);

	// 第1引数は本来は、自分自身のウィンドウハンドル(要するに録画プログラム側のウィンドウ)なのであるが、
	// 無い場合は、録画相手のものでも指定しておけば良い

	// 第2引数は、録画相手のウィンドウハンドル

	// 第3引数は、ムービーファイルのフルパス。
	LoiloGameRecorderMod::StartRecording((IntPtr)hWnd, (IntPtr)hWnd, gcnew String(L"C:\\abc\\test.avi"));


	Sleep(10000);

	// ムービーストップ。
	LoiloGameRecorderMod::StopRecording();
		return 0;
}
