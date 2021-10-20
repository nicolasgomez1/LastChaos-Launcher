/*******************************************

 *                                         *

 *         LUA 5.1 TO C# P/INVOKE          *

 * Thue Tuxen - Shadow-FanX - Pablo Garcia * 

 *                                         *

 ******************************************/



using System;

using System.Runtime.InteropServices;



namespace LuaVM.Utilities.Lua
{

    public class Lua
    {

        /* mark for precompiled code (`<esc>Lua') */

        public const string LUA_SIGNATURE = "\033Lua";



        /* option for multiple returns in `lua_pcall' and `lua_call' */

        public const int LUA_MULTRET = (-1);



        /*

        ** pseudo-indices

        */

        public const int LUA_REGISTRYINDEX = (-10000);

        public const int LUA_ENVIRONINDEX = (-10001);

        public const int LUA_GLOBALSINDEX = (-10002);



        /* thread status; 0 is OK */

        public const int LUA_YIELD = 1;

        public const int LUA_ERRRUN = 2;

        public const int LUA_ERRSYNTAX = 3;

        public const int LUA_ERRMEM = 4;

        public const int LUA_ERRERR = 5;



        /*

         *  typedef int (*lua_CFunction) (lua_State *L);

         */

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

        public delegate int LuaFunction(IntPtr lua_State);



        /*

        ** basic types

        */

        public const int LUA_TNONE = (-1);

        public const int LUA_TNIL = 0;

        public const int LUA_TBOOLEAN = 1;

        public const int LUA_TLIGHTUSERDATA = 2;

        public const int LUA_TNUMBER = 3;

        public const int LUA_TSTRING = 4;

        public const int LUA_TTABLE = 5;

        public const int LUA_TFUNCTION = 6;

        public const int LUA_TUSERDATA = 7;

        public const int LUA_TTHREAD = 8;



        /* minimum Lua stack available to a C function */

        public const int LUA_MINSTACK = 20;



        /*

        ** state manipulation

        */

        //LUA_API lua_State *(lua_newstate) (lua_Alloc f, void *ud);

        //LUA_API void       (lua_close) (lua_State *L);

        [DllImport("lua5.1.dll")]

        public static extern void lua_close(IntPtr lua_State);



        //LUA_API lua_State *(lua_newthread) (lua_State *L);

        [DllImport("lua5.1.dll")]

        public static extern IntPtr lua_newthread(IntPtr lua_State);



        //LUA_API lua_CFunction (lua_atpanic) (lua_State *L, lua_CFunction panicf);

        [DllImport("lua5.1.dll")]

        public static extern LuaFunction lua_atpanic(IntPtr lua_State, LuaFunction panicf);



        /*

        ** basic stack manipulation

        */

        //LUA_API int   (lua_gettop) (lua_State *L);

        [DllImport("lua5.1.dll")]

        public static extern int lua_gettop(IntPtr lua_State);

        //LUA_API void  (lua_settop) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern void lua_settop(IntPtr lua_State, int idx);

        //LUA_API void  (lua_pushvalue) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern void lua_pushvalue(IntPtr lua_State, int idx);

        //LUA_API void  (lua_remove) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern void lua_remove(IntPtr lua_State, int idx);

        //LUA_API void  (lua_insert) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern void lua_insert(IntPtr lua_State, int idx);

        //LUA_API void  (lua_replace) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern void lua_replace(IntPtr lua_State, int idx);

        //LUA_API int   (lua_checkstack) (lua_State *L, int sz);

        [DllImport("lua5.1.dll")]

        public static extern void lua_checkstack(IntPtr lua_State);

        //LUA_API void  (lua_xmove) (lua_State *from, lua_State *to, int n);

        [DllImport("lua5.1.dll")]

        public static extern void lua_xmove(IntPtr lua_State_From, IntPtr lua_State_To);



        /*

        ** access functions (stack -> C)

        */

        //LUA_API int             (lua_isnumber) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern int lua_isnumber(IntPtr lua_State, int idx);

        //LUA_API int             (lua_isstring) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern int lua_isstring(IntPtr lua_State, int idx);

        //LUA_API int             (lua_iscfunction) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern int lua_iscfunction(IntPtr lua_State, int idx);

        //LUA_API int             (lua_isuserdata) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern int lua_isuserdata(IntPtr lua_State, int idx);

        //LUA_API int             (lua_type) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern int lua_type(IntPtr lua_State, int idx);

        //LUA_API const char     *(lua_typename) (lua_State *L, int tp);

        [DllImport("lua5.1.dll")]

        public static extern string lua_typename(IntPtr lua_State, int tp);

        //LUA_API int            (lua_equal) (lua_State *L, int idx1, int idx2);

        [DllImport("lua5.1.dll")]

        public static extern void lua_equal(IntPtr lua_State, int idx1, int idx2);

        //LUA_API int            (lua_rawequal) (lua_State *L, int idx1, int idx2);

        [DllImport("lua5.1.dll")]

        public static extern void lua_rawequal(IntPtr lua_State, int idx1, int idx2);

        //LUA_API int            (lua_lessthan) (lua_State *L, int idx1, int idx2);

        [DllImport("lua5.1.dll")]

        public static extern void lua_lessthan(IntPtr lua_State, int idx1, int idx2);

        //LUA_API lua_Number      (lua_tonumber) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern double lua_tonumber(IntPtr lua_State, int idx);

        //LUA_API lua_Integer     (lua_tointeger) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern int lua_tointeger(IntPtr lua_State, int idx);

        //LUA_API int             (lua_toboolean) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern int lua_toboolean(IntPtr lua_State, int idx);

        //LUA_API const char     *(lua_tolstring) (lua_State *L, int idx, size_t *len);

        [DllImport("lua5.1.dll")]

        public static extern string lua_tolstring(IntPtr lua_State, int idx, UIntPtr len);

        //LUA_API size_t          (lua_objlen) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern int lua_objlen(IntPtr lua_State, int idx);

        //LUA_API lua_CFunction   (lua_tocfunction) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern LuaFunction lua_tocfunction(IntPtr lua_State, int idx);

        //LUA_API void	       *(lua_touserdata) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern IntPtr lua_touserdata(IntPtr lua_State, int idx);

        //LUA_API lua_State      *(lua_tothread) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern IntPtr lua_tothread(IntPtr lua_State, int idx);

        //LUA_API const void     *(lua_topointer) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern IntPtr lua_topointer(IntPtr lua_State, int idx);



        /*

        ** push functions (C -> stack)

        */

        //LUA_API void  (lua_pushnil) (lua_State *L);

        [DllImport("lua5.1.dll")]

        public static extern void lua_pushnil(IntPtr lua_State);

        //LUA_API void  (lua_pushnumber) (lua_State *L, lua_Number n);

        [DllImport("lua5.1.dll")]

        public static extern void lua_pushnumber(IntPtr lua_State, double n);

        //LUA_API void  (lua_pushinteger) (lua_State *L, lua_Integer n);

        [DllImport("lua5.1.dll")]

        public static extern void lua_pushinteger(IntPtr lua_State, int n);

        //LUA_API void  (lua_pushlstring) (lua_State *L, const char *s, size_t l);

        //LUA_API void  (lua_pushstring) (lua_State *L, const char *s);

        [DllImport("lua5.1.dll")]

        public static extern void lua_pushstring(IntPtr lua_State, string s);

        //LUA_API const char *(lua_pushvfstring) (lua_State *L, const char *fmt,

        //                                                      va_list argp);

        //LUA_API const char *(lua_pushfstring) (lua_State *L, const char *fmt, ...);

        //LUA_API void  (lua_pushcclosure) (lua_State *L, lua_CFunction fn, int n);

        //[DllImport("lua5.1.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]

        [DllImport("lua5.1.dll")]

        public static extern void lua_pushcclosure(IntPtr lua_State, [MarshalAs(UnmanagedType.FunctionPtr)] LuaFunction func, int n);



        //LUA_API void  (lua_pushboolean) (lua_State *L, int b);

        [DllImport("lua5.1.dll")]

        public static extern void lua_pushboolean(IntPtr lua_State, int b);

        public static void lua_pushboolean(IntPtr lua_State, bool b)
        {

            if (b)

                lua_pushboolean(lua_State, 1);

            else

                lua_pushboolean(lua_State, 0);

        }



        //LUA_API void  (lua_pushlightuserdata) (lua_State *L, void *p);

        //LUA_API int   (lua_pushthread) (lua_State *L);



        /*

        ** get functions (Lua -> stack)

        */

        //LUA_API void  (lua_gettable) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern void lua_gettable(IntPtr lua_State, int idx);

        //LUA_API void  (lua_getfield) (lua_State *L, int idx, const char *k);

        [DllImport("lua5.1.dll")]

        public static extern void lua_getfield(IntPtr lua_State, int idx, string s);

        //LUA_API void  (lua_rawget) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern void lua_rawget(IntPtr lua_State, int idx);

        //LUA_API void  (lua_rawgeti) (lua_State *L, int idx, int n);

        [DllImport("lua5.1.dll")]

        public static extern void lua_rawgeti(IntPtr lua_State, int idx, int n);

        //LUA_API void  (lua_createtable) (lua_State *L, int narr, int nrec);

        [DllImport("lua5.1.dll")]

        public static extern void lua_createtable(IntPtr lua_State, int narr, int nrec);

        //LUA_API void *(lua_newuserdata) (lua_State *L, size_t sz);

        //LUA_API int   (lua_getmetatable) (lua_State *L, int objindex);

        [DllImport("lua5.1.dll")]

        public static extern int lua_getmetatable(IntPtr lua_State, int objindex);

        //LUA_API void  (lua_getfenv) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern void lua_getfenv(IntPtr lua_State, int idx);



        /*

        ** set functions (stack -> Lua)

        */

        //LUA_API void  (lua_settable) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern void lua_settable(IntPtr lua_State, int idx);

        //LUA_API void  (lua_setfield) (lua_State *L, int idx, const char *k);

        [DllImport("lua5.1.dll")]

        public static extern void lua_setfield(IntPtr lua_State, int idx, string s);



        //LUA_API void  (lua_rawset) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern void lua_rawset(IntPtr lua_State, int idx);

        //LUA_API void  (lua_rawseti) (lua_State *L, int idx, int n);

        [DllImport("lua5.1.dll")]

        public static extern void lua_rawseti(IntPtr lua_State, int idx, int n);

        //LUA_API int   (lua_setmetatable) (lua_State *L, int objindex);

        [DllImport("lua5.1.dll")]

        public static extern int lua_setmetatable(IntPtr lua_State, int objindex);

        //LUA_API int   (lua_setfenv) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern int lua_setfenv(IntPtr lua_State, int idx);



        /*

        ** `load' and `call' functions (load and run Lua code)

        */

        //LUA_API void  (lua_call) (lua_State *L, int nargs, int nresults);

        [DllImport("lua5.1.dll")]

        public static extern void lua_call(IntPtr lua_State, int nargs, int nresults);

        //LUA_API int   (lua_pcall) (lua_State *L, int nargs, int nresults, int errfunc);

        [DllImport("lua5.1.dll")]

        public static extern int lua_pcall(IntPtr lua_State, int nargs, int nresults, int errfunc);

        //LUA_API int   (lua_cpcall) (lua_State *L, lua_CFunction func, void *ud);

        //LUA_API int   (lua_load) (lua_State *L, lua_Reader reader, void *dt,

        //                                        const char *chunkname);



        //LUA_API int (lua_dump) (lua_State *L, lua_Writer writer, void *data);





        /*

        ** coroutine functions

        */

        //LUA_API int  (lua_yield) (lua_State *L, int nresults);

        //LUA_API int  (lua_resume) (lua_State *L, int narg);

        //LUA_API int  (lua_status) (lua_State *L);



        /*

        ** garbage-collection function and options

        */

        //#define LUA_GCSTOP		0

        //#define LUA_GCRESTART		1

        //#define LUA_GCCOLLECT		2

        //#define LUA_GCCOUNT		3

        //#define LUA_GCCOUNTB		4

        //#define LUA_GCSTEP		5

        //#define LUA_GCSETPAUSE		6

        //#define LUA_GCSETSTEPMUL	7



        //LUA_API int (lua_gc) (lua_State *L, int what, int data);

        [DllImport("lua5.1.dll")]

        public static extern int lua_gc(IntPtr lua_State, int what, int data);



        /*

        ** miscellaneous functions

        */

        //LUA_API int   (lua_error) (lua_State *L);

        [DllImport("lua5.1.dll")]

        public static extern int lua_error(IntPtr lua_State);

        //LUA_API int   (lua_next) (lua_State *L, int idx);

        [DllImport("lua5.1.dll")]

        public static extern int lua_next(IntPtr lua_State, int idx);



        //LUA_API void  (lua_concat) (lua_State *L, int n);

        [DllImport("lua5.1.dll")]

        public static extern void lua_concat(IntPtr lua_State, int n);

        //LUA_API lua_Alloc (lua_getallocf) (lua_State *L, void **ud);

        //LUA_API void lua_setallocf (lua_State *L, lua_Alloc f, void *ud);



        /* 

        ** ===============================================================

        ** some useful macros

        ** ===============================================================

        */



        //#define lua_pop(L,n)		lua_settop(L, -(n)-1)

        public static void lua_pop(IntPtr lua_State, int amount)
        {

            lua_settop(lua_State, -(amount) - 1);

        }



        //#define lua_newtable(L)		lua_createtable(L, 0, 0)

        public static void lua_newtable(IntPtr lua_State)
        {

            lua_createtable(lua_State, 0, 0);

        }



        //#define lua_register(L,n,f) (lua_pushcfunction(L, (f)), lua_setglobal(L, (n)))

        public static void lua_register(IntPtr lua_State, string n, LuaFunction func)
        {

            lua_pushcfunction(lua_State, func);

            lua_setglobal(lua_State, n);

        }



        //#define lua_pushcfunction(L,f)	lua_pushcclosure(L, (f), 0)

        public static void lua_pushcfunction(IntPtr lua_State, LuaFunction func)
        {

            lua_pushcclosure(lua_State, func, 0);

        }



        //#define lua_strlen(L,i)		lua_objlen(L, (i))

        public static void lua_strlen(IntPtr lua_State, int i)
        {

            lua_objlen(lua_State, i);

        }



        //#define lua_isfunction(L,n)	(lua_type(L, (n)) == LUA_TFUNCTION)

        public static bool lua_isfunction(IntPtr lua_State, int n)
        {

            return lua_type(lua_State, n) == LUA_TFUNCTION ? true : false;

        }

        //#define lua_istable(L,n)	(lua_type(L, (n)) == LUA_TTABLE)

        public static bool lua_istable(IntPtr lua_State, int n)
        {

            return lua_type(lua_State, n) == LUA_TTABLE ? true : false;

        }

        //#define lua_islightuserdata(L,n)	(lua_type(L, (n)) == LUA_TLIGHTUSERDATA)

        //#define lua_isnil(L,n)		(lua_type(L, (n)) == LUA_TNIL)

        public static bool lua_isnil(IntPtr lua_State, int n)
        {

            return lua_type(lua_State, n) == LUA_TNIL ? true : false;

        }

        //#define lua_isboolean(L,n)	(lua_type(L, (n)) == LUA_TBOOLEAN)

        public static bool lua_isboolean(IntPtr lua_State, int n)
        {

            return lua_type(lua_State, n) == LUA_TBOOLEAN ? true : false;

        }

        //#define lua_isthread(L,n)	(lua_type(L, (n)) == LUA_TTHREAD)

        //#define lua_isnone(L,n)		(lua_type(L, (n)) == LUA_TNONE)

        public static bool lua_isnone(IntPtr lua_State, int n)
        {

            return lua_type(lua_State, n) == LUA_TNONE ? true : false;

        }

        //#define lua_isnoneornil(L, n)	(lua_type(L, (n)) <= 0)

        public static bool lua_isnoneornil(IntPtr lua_State, int n)
        {

            return lua_type(lua_State, n) <= 0 ? true : false;

        }



        //#define lua_pushliteral(L, s)	\

        //    lua_pushlstring(L, "" s, (sizeof(s)/sizeof(char))-1)



        //#define lua_setglobal(L,s)	lua_setfield(L, LUA_GLOBALSINDEX, (s))

        public static void lua_setglobal(IntPtr lua_State, string s)
        {

            lua_setfield(lua_State, LUA_GLOBALSINDEX, s);

        }



        //#define lua_getglobal(L,s)	lua_getfield(L, LUA_GLOBALSINDEX, (s))

        public static void lua_getglobal(IntPtr lua_State, string s)
        {

            lua_getfield(lua_State, LUA_GLOBALSINDEX, s);

        }



        //#define lua_tostring(L,i)	lua_tolstring(L, (i), NULL)

        public static string lua_tostring(IntPtr lua_State, int i)
        {

            return lua_tolstring(lua_State, i, UIntPtr.Zero);

        }



        /*

        ** compatibility macros and functions

        */

        [DllImport("lua5.1.dll")]

        public static extern IntPtr luaL_newstate();



        //#define lua_open()	luaL_newstate()

        public static IntPtr lua_open()
        {

            return luaL_newstate();

        }



        /* open all previous libraries */

        //LUALIB_API void (luaL_openlibs) (lua_State *L);

        [DllImport("lua5.1.dll")]

        public static extern void luaL_openlibs(IntPtr lua_State);



        //#define lua_getregistry(L)	lua_pushvalue(L, LUA_REGISTRYINDEX)



        //#define lua_getgccount(L)	lua_gc(L, LUA_GCCOUNT, 0)



        //#define lua_Chunkreader		lua_Reader

        //#define lua_Chunkwriter		lua_Writer



        /* hack */

        //LUA_API void lua_setlevel	(lua_State *from, lua_State *to);



        //LUALIB_API int (luaL_loadstring) (lua_State *L, const char *s);

        [DllImport("lua5.1.dll")]

        public static extern int luaL_loadstring(IntPtr lua_State, string s);



        //#define luaL_dostring(L, s) \

        //(luaL_loadstring(L, s) || lua_pcall(L, 0, LUA_MULTRET, 0))

        public static int luaL_dostring(IntPtr lua_State, string s)
        {

            if (luaL_loadstring(lua_State, s) != 0)

                return 1;

            return lua_pcall(lua_State, 0, LUA_MULTRET, 0);

        }



        //LUALIB_API int (luaL_loadfile) (lua_State *L, const char *filename);

        [DllImport("lua5.1.dll")]

        public static extern int luaL_loadfile(IntPtr lua_State, string s);



        //#define luaL_dofile(L, fn) \

        //(luaL_loadfile(L, fn) || lua_pcall(L, 0, LUA_MULTRET, 0))

        public static int luaL_dofile(IntPtr lua_State, string s)
        {

            if (luaL_loadfile(lua_State, s) != 0)

                return 1;

            return lua_pcall(lua_State, 0, LUA_MULTRET, 0);

        }

    }

}