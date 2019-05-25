using System;
using System.IO;
using System.Text;

namespace StaticAbstraction.Mocks
{
    public class MockConsole : IConsole
    {
        public ConsoleColor BackgroundColor {get; set; }
        public int BufferHeight {get; set; }
        public int BufferWidth {get; set; }

        public bool CapsLock { get; set; }

        public int CursorLeft {get; set; }
        public int CursorSize {get; set; }
        public int CursorTop {get; set; }
        public bool CursorVisible {get; set; }

        public TextWriter Error { get; set; }

        public ConsoleColor ForegroundColor {get; set; }

        public TextReader In { get; set; }

        public Encoding InputEncoding {get; set; }

        public bool KeyAvailable { get; set; }

        public int LargestWindowHeight { get; set; }

        public int LargestWindowWidth { get; set; }

        public bool NumberLock { get; set; }

        public TextWriter Out { get; set; }

        public Encoding OutputEncoding {get; set; }
        public string Title {get; set; }
        public bool TreatControlCAsInput {get; set; }
        public int WindowHeight {get; set; }
        public int WindowLeft {get; set; }
        public int WindowTop {get; set; }
        public int WindowWidth {get; set; }


        public void Beep()
        {
            // do nothing
        }

        public void Beep(int frequency, int duration)
        {
            // do nothing
        }

        public void Clear()
        {
            // do nothing
        }

        public void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
        {
            // do nothing
        }

        public void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
        {
            // do nothing
        }

        public Stream OpenStandardError()
        {
            return null;
        }

        public Stream OpenStandardError(int bufferSize)
        {
            return null;
        }

        public Stream OpenStandardInput()
        {
            return null;
        }

        public Stream OpenStandardInput(int bufferSize)
        {
            return null;
        }

        public Stream OpenStandardOutput()
        {
            return null;
        }

        public Stream OpenStandardOutput(int bufferSize)
        {
            return null;
        }

        public int Read()
        {
            return 0;
        }

        public ConsoleKeyInfo ReadKey()
        {
            return default(ConsoleKeyInfo);
        }

        public ConsoleKeyInfo ReadKey(bool intercept)
        {
            return default(ConsoleKeyInfo);
        }

        public void ResetColor()
        {
            // do nothing
        }

        public void SetBufferSize(int width, int height)
        {
            // do nothing
        }

        public void SetCursorPosition(int left, int top)
        {
            // do nothing
        }

        public void SetError(TextWriter newError)
        {
            // do nothing
        }

        public void SetIn(TextReader newIn)
        {
            // do nothing
        }

        public void SetOut(TextWriter newOut)
        {
            // do nothing
        }

        public void SetWindowPosition(int left, int top)
        {
            // do nothing
        }

        public void SetWindowSize(int width, int height)
        {
            // do nothing
        }

        public void Write(bool value)
        {
            // do nothing
        }

        public void Write(char value)
        {
            // do nothing
        }

        public void Write(char[] buffer)
        {
            // do nothing
        }

        public void Write(char[] buffer, int index, int count)
        {
            // do nothing
        }

        public void Write(decimal value)
        {
            // do nothing
        }

        public void Write(double value)
        {
            // do nothing
        }

        public void Write(float value)
        {
            // do nothing
        }

        public void Write(int value)
        {
            // do nothing
        }

        public void Write(long value)
        {
            // do nothing
        }

        public void Write(object value)
        {
            // do nothing
        }

        public void Write(string value)
        {
            // do nothing
        }

        public void Write(string format, object arg0)
        {
            // do nothing
        }

        public void Write(string format, object arg0, object arg1)
        {
            // do nothing
        }

        public void Write(string format, object arg0, object arg1, object arg2)
        {
            // do nothing
        }

        public void Write(string format, params object[] arg)
        {
            // do nothing
        }

        public void Write(uint value)
        {
            // do nothing
        }

        public void Write(ulong value)
        {
            // do nothing
        }

        public void WriteLine()
        {
            // do nothing
        }

        public void WriteLine(bool value)
        {
            // do nothing
        }

        public void WriteLine(char value)
        {
            // do nothing
        }

        public void WriteLine(char[] buffer)
        {
            // do nothing
        }

        public void WriteLine(char[] buffer, int index, int count)
        {
            // do nothing
        }

        public void WriteLine(decimal value)
        {
            // do nothing
        }

        public void WriteLine(double value)
        {
            // do nothing
        }

        public void WriteLine(float value)
        {
            // do nothing
        }

        public void WriteLine(int value)
        {
            // do nothing
        }

        public void WriteLine(long value)
        {
            // do nothing
        }

        public void WriteLine(object value)
        {
            // do nothing
        }

        public void WriteLine(string value)
        {
            // do nothing
        }

        public void WriteLine(string format, object arg0)
        {
            // do nothing
        }

        public void WriteLine(string format, object arg0, object arg1)
        {
            // do nothing
        }

        public void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            // do nothing
        }

        public void WriteLine(string format, params object[] arg)
        {
            // do nothing
        }

        public void WriteLine(uint value)
        {
            // do nothing
        }

        public void WriteLine(ulong value)
        {
            // do nothing
        }

#if NETCORE22
        public bool IsErrorRedirected { get; set; }

        public bool IsInputRedirected { get; set; }

        public bool IsOutputRedirected { get; set; }
#endif

    }
}
