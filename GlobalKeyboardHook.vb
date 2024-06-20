Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class GlobalKeyboardHook
    Implements IDisposable

    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WM_KEYUP As Integer = &H101
    Private Const WM_SYSKEYDOWN As Integer = &H104
    Private Const WM_SYSKEYUP As Integer = &H105

    Private Delegate Function LowLevelKeyboardProcDelegate(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetWindowsHookEx(ByVal id As Integer, ByVal callback As LowLevelKeyboardProcDelegate, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function UnhookWindowsHookEx(ByVal hook As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function CallNextHookEx(ByVal hook As IntPtr, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function GetModuleHandle(ByVal name As String) As IntPtr
    End Function

    Private Enum HookType As Integer
        WH_KEYBOARD_LL = 13
    End Enum

    Private Structure KBDLLHOOKSTRUCT
        Public vkCode As Keys
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public dwExtraInfo As IntPtr
    End Structure

    Private hookID As IntPtr = IntPtr.Zero
    Private hookDelegate As LowLevelKeyboardProcDelegate = Nothing

    Public Event KeyDown(ByVal key As Keys)

    Public Sub New()
        hookDelegate = New LowLevelKeyboardProcDelegate(AddressOf LowLevelKeyboardProc)
        hookID = SetHook(hookDelegate)
    End Sub

    Private Function SetHook(ByVal proc As LowLevelKeyboardProcDelegate) As IntPtr
        Using curProcess As Process = Process.GetCurrentProcess()
            Using curModule As ProcessModule = curProcess.MainModule
                Return SetWindowsHookEx(HookType.WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0)
            End Using
        End Using
    End Function

    Private Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        If nCode >= 0 AndAlso (wParam = CType(WM_KEYDOWN, IntPtr) OrElse wParam = CType(WM_SYSKEYDOWN, IntPtr)) Then
            Dim struct As KBDLLHOOKSTRUCT = DirectCast(Marshal.PtrToStructure(lParam, GetType(KBDLLHOOKSTRUCT)), KBDLLHOOKSTRUCT)
            RaiseEvent KeyDown(struct.vkCode)
        End If

        Return CallNextHookEx(hookID, nCode, wParam, lParam)
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        UnhookWindowsHookEx(hookID)
    End Sub

End Class
