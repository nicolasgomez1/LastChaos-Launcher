using System.Text;
using System;
using RGiesecke.DllExport;
using System.Runtime.InteropServices;
using LuaVM.Utilities.Lua;
using System.IO;

namespace BinReaderWriter
{
    public class BinReaderWriter
    {
        public static byte[] Header_lccnct = new byte[0];
        public static byte[] Header_sl = new byte[0];

        public static int ReadDTA(IntPtr Ls) 
        {
            string path = Lua.lua_tostring(Ls, 1);
            ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
            BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open));
            int num = (int)binaryReader.BaseStream.Length - 19;
            byte[] array = binaryReader.ReadBytes(19);
            byte[] array2 = binaryReader.ReadBytes(num);
            binaryReader.Close();
            byte b = array[10];
            if (Path.GetFileName(path) == "lccnct.dta")
            {
                Header_lccnct = array;
            }
            if (Path.GetFileName(path) == "sl.dta")
            {
                Header_sl = array;
            }
            for (int i = 0; i < num; i++)
            {
                byte[] expr_8F_cp_0 = array2;
                int expr_8F_cp_1 = i;
                expr_8F_cp_0[expr_8F_cp_1] -= b;
                b += array2[i];
            }
            Lua.lua_pushstring(Ls, aSCIIEncoding.GetString(array2));
            return 1;
        }

        public static int ReadBRN(IntPtr Ls)
        {
            string path = Lua.lua_tostring(Ls, 1);

            BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open, FileAccess.Read));
            int num = binaryReader.ReadInt32();
            binaryReader.Close();
            string s = ((num - 27) / 3).ToString();
            Lua.lua_pushstring(Ls, s);

            return 1;
        }

        public static int WriteDTA(IntPtr Ls)
        {
            string path = Lua.lua_tostring(Ls, 1);
            string s = Lua.lua_tostring(Ls, 2);

            ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
            byte[] array = new byte[0];
            if (Path.GetFileName(path) == "lccnct.dta")
            {
                array = Header_lccnct;
            }
            if (Path.GetFileName(path) == "sl.dta")
            {
                array = Header_sl;
            }
            byte[] bytes = aSCIIEncoding.GetBytes(s);
            byte b = array[10];
            for (int i = 0; i < bytes.Length; i++)
            {
                byte[] expr_6B_cp_0 = bytes;
                int expr_6B_cp_1 = i;
                expr_6B_cp_0[expr_6B_cp_1] += b;
                b = bytes[i];
            }
            BinaryWriter binaryWriter = new BinaryWriter(File.Create(path));
            binaryWriter.Write(array);
            binaryWriter.Write(bytes);
            binaryWriter.Close();

            return 1;
        }

        public static int WriteBRN(IntPtr Ls)
        {
            string version = Lua.lua_tostring(Ls, 1);
            string path = Lua.lua_tostring(Ls, 2);

            int num = Convert.ToInt32(version);
            num = (num + 9) * 3;
            BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create));
            binaryWriter.Write(num);
            binaryWriter.Close();

            return 1;
        }

        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static int luaopen_launcher(IntPtr Ls)
        {
            Lua.lua_register(Ls, "ReadBRN", new Lua.LuaFunction(BinReaderWriter.ReadBRN));
            Lua.lua_register(Ls, "WriteBRN", new Lua.LuaFunction(BinReaderWriter.WriteBRN));
            Lua.lua_register(Ls, "ReadDTA", new Lua.LuaFunction(BinReaderWriter.ReadDTA));
            Lua.lua_register(Ls, "WriteDTA", new Lua.LuaFunction(BinReaderWriter.WriteDTA));
            return 1;
        }
    }
}