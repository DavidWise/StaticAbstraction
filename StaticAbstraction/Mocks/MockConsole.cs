using System;
using System.IO;
using System.Text;

namespace StaticAbstraction.Mocks
{
    public class MockConsole : IConsole
    {
        public virtual ConsoleColor BackgroundColor {get; set; }
        public virtual int BufferHeight {get; set; }
        public virtual int BufferWidth {get; set; }

        public virtual bool CapsLock { get; set; }

        public virtual int CursorLeft {get; set; }
        public virtual int CursorSize {get; set; }
        public virtual int CursorTop {get; set; }
        public virtual bool CursorVisible {get; set; }

        public virtual TextWriter Error { get; set; }

        public virtual ConsoleColor ForegroundColor {get; set; }

        public virtual TextReader In { get; set; }

        public virtual Encoding InputEncoding {get; set; }

        public virtual bool KeyAvailable { get; set; }

        public virtual int LargestWindowHeight { get; set; }

        public virtual int LargestWindowWidth { get; set; }

        public virtual bool NumberLock { get; set; }

        public virtual TextWriter Out { get; set; }

        public virtual Encoding OutputEncoding {get; set; }
        public virtual string Title {get; set; }
        public virtual bool TreatControlCAsInput {get; set; }
        public virtual int WindowHeight {get; set; }
        public virtual int WindowLeft {get; set; }
        public virtual int WindowTop {get; set; }
        public virtual int WindowWidth {get; set; }


        public virtual void Beep()
        {
            // do nothing
        }

        public virtual void Beep(int frequency, int duration)
        {
            // do nothing
        }

        public virtual void Clear()
        {
            // do nothing
        }

        public virtual void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
        {
            // do nothing
        }

        public virtual void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
        {
            // do nothing
        }

        public virtual Stream OpenStandardError()
        {
            return null;
        }

        public virtual Stream OpenStandardError(int bufferSize)
        {
            return null;
        }

        public virtual Stream OpenStandardInput()
        {
            return null;
        }

        public virtual Stream OpenStandardInput(int bufferSize)
        {
            return null;
        }

        public virtual Stream OpenStandardOutput()
        {
            return null;
        }

        public virtual Stream OpenStandardOutput(int bufferSize)
        {
            return null;
        }

        public virtual int Read()
        {
            return 0;
        }

        public virtual ConsoleKeyInfo ReadKey()
        {
            return default(ConsoleKeyInfo);
        }

        public virtual ConsoleKeyInfo ReadKey(bool intercept)
        {
            return default(ConsoleKeyInfo);
        }

        public virtual void ResetColor()
        {
            // do nothing
        }

        public virtual void SetBufferSize(int width, int height)
        {
            // do nothing
        }

        public virtual void SetCursorPosition(int left, int top)
        {
            // do nothing
        }

        public virtual void SetError(TextWriter newError)
        {
            // do nothing
        }

        public virtual void SetIn(TextReader newIn)
        {
            // do nothing
        }

        public virtual void SetOut(TextWriter newOut)
        {
            // do nothing
        }

        public virtual void SetWindowPosition(int left, int top)
        {
            // do nothing
        }

        public virtual void SetWindowSize(int width, int height)
        {
            // do nothing
        }

        public virtual void Write(bool value)
        {
            // do nothing
        }

        public virtual void Write(char value)
        {
            // do nothing
        }

        public virtual void Write(char[] buffer)
        {
            // do nothing
        }

        public virtual void Write(char[] buffer, int index, int count)
        {
            // do nothing
        }

        public virtual void Write(decimal value)
        {
            // do nothing
        }

        public virtual void Write(double value)
        {
            // do nothing
        }

        public virtual void Write(float value)
        {
            // do nothing
        }

        public virtual void Write(int value)
        {
            // do nothing
        }

        public virtual void Write(long value)
        {
            // do nothing
        }

        public virtual void Write(object value)
        {
            // do nothing
        }

        public virtual void Write(string value)
        {
            // do nothing
        }

        public virtual void Write(string format, object arg0)
        {
            // do nothing
        }

        public virtual void Write(string format, object arg0, object arg1)
        {
            // do nothing
        }

        public virtual void Write(string format, object arg0, object arg1, object arg2)
        {
            // do nothing
        }

        public virtual void Write(string format, params object[] arg)
        {
            // do nothing
        }

        public virtual void Write(uint value)
        {
            // do nothing
        }

        public virtual void Write(ulong value)
        {
            // do nothing
        }

        public virtual void WriteLine()
        {
            // do nothing
        }

        public virtual void WriteLine(bool value)
        {
            // do nothing
        }

        public virtual void WriteLine(char value)
        {
            // do nothing
        }

        public virtual void WriteLine(char[] buffer)
        {
            // do nothing
        }

        public virtual void WriteLine(char[] buffer, int index, int count)
        {
            // do nothing
        }

        public virtual void WriteLine(decimal value)
        {
            // do nothing
        }

        public virtual void WriteLine(double value)
        {
            // do nothing
        }

        public virtual void WriteLine(float value)
        {
            // do nothing
        }

        public virtual void WriteLine(int value)
        {
            // do nothing
        }

        public virtual void WriteLine(long value)
        {
            // do nothing
        }

        public virtual void WriteLine(object value)
        {
            // do nothing
        }

        public virtual void WriteLine(string value)
        {
            // do nothing
        }

        public virtual void WriteLine(string format, object arg0)
        {
            // do nothing
        }

        public virtual void WriteLine(string format, object arg0, object arg1)
        {
            // do nothing
        }

        public virtual void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            // do nothing
        }

        public virtual void WriteLine(string format, params object[] arg)
        {
            // do nothing
        }

        public virtual void WriteLine(uint value)
        {
            // do nothing
        }

        public virtual void WriteLine(ulong value)
        {
            // do nothing
        }

#if NETCORE22
        public virtual bool IsErrorRedirected { get; set; }

        public virtual bool IsInputRedirected { get; set; }

        public virtual bool IsOutputRedirected { get; set; }
#endif

    }
}
