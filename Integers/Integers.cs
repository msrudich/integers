[assembly: CLSCompliant(false)]

namespace Literals
{
    public static class Integers
    {
        public static int ReturnInteger11()
        {
            return 0;
        }

        public static int ReturnInteger12()
        {
            return 1;
        }

        public static int ReturnInteger13()
        {
            return -1;
        }

        public static int ReturnInteger14()
        {
            return int.MaxValue;
        }

        public static int ReturnInteger15()
        {
            return -2_147_483_648;
        }

        public static uint ReturnInteger16()
        {
            return 1u;
        }

        public static uint ReturnInteger17()
        {
            return 32767;
        }

        public static uint ReturnInteger18()
        {
            return uint.MaxValue / 2;
        }
    }
}
