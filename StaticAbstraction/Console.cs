using System;
using System.IO;
using System.Text;

namespace StaticAbstraction
{
    public class StAbConsole : IConsole
    {
        // TODO: Figure out how to handle this in a wrapper
        //public virtual event ConsoleCancelEventHandler CancelKeyPress;

        public virtual ConsoleColor BackgroundColor
        {
            get { return Console.BackgroundColor; }
            set { Console.BackgroundColor = value;  }
        }
        public virtual int BufferHeight
        {
            get { return Console.BufferHeight; }
            set { Console.BufferHeight = value; }
        }
        public virtual int BufferWidth
        {
            get { return Console.BufferWidth; }
            set { Console.BufferWidth = value; }
        }
        public virtual bool CapsLock
        {
            get { return Console.CapsLock; }
        }

        public virtual int CursorLeft
        {
            get { return Console.CursorLeft; }
            set { Console.CursorLeft = value; }
        }
        public virtual int CursorSize
        {
            get { return Console.CursorSize; }
            set { Console.CursorSize = value; }
        }
        public virtual int CursorTop
        {
            get { return Console.CursorTop; }
            set { Console.CursorTop = value; }
        }
        public virtual bool CursorVisible
        {
            get { return Console.CursorVisible; }
            set { Console.CursorVisible = value; }
        }

        public virtual TextWriter Error
        {
            get { return Console.Error; }
        }

        public virtual ConsoleColor ForegroundColor
        {
            get { return Console.ForegroundColor; }
            set { Console.ForegroundColor = value; }
        }

        public virtual TextReader In
        {
            get { return Console.In; }
        }

        public virtual Encoding InputEncoding
        {
            get { return Console.InputEncoding; }
            set { Console.InputEncoding = value; }
        }

        public virtual bool KeyAvailable
        {
            get { return Console.KeyAvailable; }
        }

        public virtual int LargestWindowHeight
        {
            get { return Console.LargestWindowHeight; }
        }

        public virtual int LargestWindowWidth
        {
            get { return Console.LargestWindowWidth; }
        }

        public virtual bool NumberLock
        {
            get { return Console.NumberLock; }
        }

        public virtual TextWriter Out
        {
            get { return Console.Out; }
        }

        public virtual Encoding OutputEncoding
        {
            get { return Console.OutputEncoding; }
            set { Console.OutputEncoding = value; }
        }

        public virtual string Title
        {
            get { return Console.Title; }
            set { Console.Title = value; }
        }

        public virtual bool TreatControlCAsInput
        {
            get { return Console.TreatControlCAsInput; }
            set { Console.TreatControlCAsInput = value; }
        }

        public virtual int WindowHeight
        {
            get { return Console.WindowHeight; }
            set { Console.WindowHeight = value; }
        }

        public virtual int WindowLeft
        {
            get { return Console.WindowLeft; }
            set { Console.WindowLeft = value; }
        }

        public virtual int WindowTop
        {
            get { return Console.WindowTop; }
            set { Console.WindowTop = value; }
        }

        public virtual int WindowWidth
        {
            get { return Console.WindowWidth; }
            set { Console.WindowWidth = value; }
        }




        public virtual void Beep()
        {
            Console.Beep();
        }
        public virtual void Beep(int frequency, int duration)
        {
            Console.Beep(frequency, duration);
        }

        public virtual void Clear()
        {
            Console.Clear();
        }

        public virtual void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
        {
            Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
        }
        public virtual void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
        {
            Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);
        }

        public virtual Stream OpenStandardError()
        {
            return Console.OpenStandardError();
        }
        public virtual Stream OpenStandardError(int bufferSize)
        {
            return Console.OpenStandardError(bufferSize);
        }

        public virtual Stream OpenStandardInput()
        {
            return Console.OpenStandardInput();
        }
        public virtual Stream OpenStandardInput(int bufferSize)
        {
            return Console.OpenStandardInput(bufferSize);
        }

        public virtual Stream OpenStandardOutput()
        {
            return Console.OpenStandardOutput();
        }
        public virtual Stream OpenStandardOutput(int bufferSize)
        {
            return Console.OpenStandardOutput(bufferSize);
        }

        public virtual int Read()
        {
            return Console.Read();
        }

        public virtual ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }
        public virtual ConsoleKeyInfo ReadKey(bool intercept)
        {
            return Console.ReadKey(intercept);
        }

        public virtual void ResetColor()
        {
            Console.ResetColor();
        }

        public virtual void SetBufferSize(int width, int height)
        {
            Console.SetBufferSize(width, height);
        }

        public virtual void SetCursorPosition(int left, int top)
        {
            Console.SetCursorPosition(left, top);
        }

        public virtual void SetError(TextWriter newError)
        {
            Console.SetError(newError);
        }
        public virtual void SetIn(TextReader newIn)
        {
            Console.SetIn(newIn);
        }
        public virtual void SetOut(TextWriter newOut)
        {
            Console.SetOut(newOut);
        }

        public virtual void SetWindowPosition(int left, int top)
        {
            Console.SetWindowPosition(left, top);
        }

        public virtual void SetWindowSize(int width, int height)
        {
            Console.SetWindowSize(width, height);
        }


        public virtual void Write(ulong value)
        {
            Console.Write(value);
        }
        public virtual void Write(bool value)
        {
            Console.Write(value);
        }
        public virtual void Write(char value)
        {
            Console.Write(value);
        }
        public virtual void Write(char[] buffer)
        {
            Console.Write(buffer);
        }
        public virtual void Write(char[] buffer, int index, int count)
        {
            Console.Write(buffer, index, count);
        }
        public virtual void Write(double value)
        {
            Console.Write(value);
        }
        public virtual void Write(long value)
        {
            Console.Write(value);
        }
        public virtual void Write(object value)
        {
            Console.Write(value);
        }
        public virtual void Write(float value)
        {
            Console.Write(value);
        }
        public virtual void Write(string value)
        {
            Console.Write(value);
        }
        public virtual void Write(string format, object arg0)
        {
            Console.Write(format, arg0);
        }
        public virtual void Write(string format, object arg0, object arg1)
        {
            Console.Write(format, arg0, arg1);
        }

        public virtual void Write(string format, object arg0, object arg1, object arg2)
        {
            Console.Write(format, arg0, arg1, arg2);
        }

#if NETSTANDARD2_0
        public virtual void Write(String format, Object arg0, Object arg1, Object arg2, Object arg3)
        {
            Console.Write(format, arg0, arg1, arg2, arg3);
        }
#endif

        public virtual void Write(string format, params object[] arg)
        {
            Console.Write(format, arg);
        }

        public virtual void Write(uint value)
        {
            Console.Write(value);
        }
        public virtual void Write(decimal value)
        {
            Console.Write(value);
        }
        public virtual void Write(int value)
        {
            Console.Write(value);
        }

        public virtual void WriteLine(ulong value)
        {
            Console.WriteLine(value);
        }
        public virtual void WriteLine(string format, params object[] arg)
        {
            Console.WriteLine(format, arg);
        }
        public virtual void WriteLine()
        {
            Console.WriteLine();
        }
        public virtual void WriteLine(bool value)
        {
            Console.WriteLine(value);
        }
        public virtual void WriteLine(char[] buffer)
        {
            Console.WriteLine(buffer);
        }
        public virtual void WriteLine(char[] buffer, int index, int count)
        {
            Console.WriteLine(buffer, index, count);
        }
        public virtual void WriteLine(decimal value)
        {
            Console.WriteLine(value);
        }
        public virtual void WriteLine(double value)
        {
            Console.WriteLine(value);
        }
        public virtual void WriteLine(uint value)
        {
            Console.WriteLine(value);
        }
        public virtual void WriteLine(int value)
        {
            Console.WriteLine(value);
        }
        public virtual void WriteLine(object value)
        {
            Console.WriteLine(value);
        }
        public virtual void WriteLine(float value)
        {
            Console.WriteLine(value);
        }
        public virtual void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
        public virtual void WriteLine(string format, object arg0)
        {
            Console.WriteLine(format, arg0);
        }
        public virtual void WriteLine(string format, object arg0, object arg1)
        {
            Console.WriteLine(format, arg0, arg1);
        }
        public virtual void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            Console.WriteLine(format, arg0, arg1, arg2);
        }

#if NETSTANDARD2_0
        public virtual void WriteLine(String format, Object arg0, Object arg1, Object arg2, Object arg3)
        {
            Console.WriteLine(format, arg0, arg1, arg2, arg3);
        }
#endif

        public virtual void WriteLine(long value)
        {
            Console.WriteLine(value);
        }
        public virtual void WriteLine(char value)
        {
            Console.WriteLine(value);
        }

#if NETCORE22 || NETCORE30
        public virtual bool IsErrorRedirected
        {
            get { return Console.IsErrorRedirected; }
        }

        public virtual bool IsInputRedirected
        {
            get { return Console.IsInputRedirected; }
        }

        public virtual bool IsOutputRedirected
        {
            get { return Console.IsOutputRedirected; }
        }

#endif
    }
}
