using System;
using System.Runtime.InteropServices;

namespace Spike.CSharp.Library
{
    public class SpikeLibrary
    {
        private const string LibName = "spike.so";
        [DllImport(LibName)]
        public static extern int Add(long a, long b);
        [DllImport(LibName)]
        public static extern double Cosine(double a);

        [DllImport(LibName)]
        public static extern void Sort(GoSlice a);

        [DllImport(LibName, CharSet = CharSet.Unicode)]
        public static extern void Log(GoString msg);
        
       
    }
    public struct GoSlice
    {
        public IntPtr data;
        public long len, cap;
        public GoSlice(IntPtr data, long len, long cap)
        {
            this.data = data;
            this.len = len;
            this.cap = cap;
        }
    }
    public struct GoString
    {
        public string msg;
        public long len;
        public GoString(string msg, long len)
        {
            this.msg = msg;
            this.len = len;
        }
    }
}