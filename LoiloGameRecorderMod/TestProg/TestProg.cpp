#include <windows.h>

using namespace System;

#pragma comment(lib, "user32.lib")

int main(array<System::String ^> ^args)
{
    Console::WriteLine(L"Hello World");

	// �E�B���h�E�n���h���𓾂�
	HWND hWnd = FindWindow(L"Tenshouki95", NULL);

	// ��1�����͖{���́A�������g�̃E�B���h�E�n���h��(�v����ɘ^��v���O�������̃E�B���h�E)�Ȃ̂ł��邪�A
	// �����ꍇ�́A�^�摊��̂��̂ł��w�肵�Ă����Ηǂ�

	// ��2�����́A�^�摊��̃E�B���h�E�n���h��

	// ��3�����́A���[�r�[�t�@�C���̃t���p�X�B
	LoiloGameRecorderMod::StartRecording((IntPtr)hWnd, (IntPtr)hWnd, gcnew String(L"C:\\abc\\test.avi"));


	Sleep(10000);

	// ���[�r�[�X�g�b�v�B
	LoiloGameRecorderMod::StopRecording();
		return 0;
}
