namespace CreatingMethods
{
    // ReSharper disable once IdentifierTypo
    public static class PassthroughMethods
    {
        public static bool ReturnValue(bool boolValue)
        {
            return boolValue;
        }

        public static byte ReturnValue(byte byteValue) => byteValue;

        public static sbyte ReturnValue(sbyte sbyteValue) => sbyteValue;

        public static char ReturnValue(char charValue) => charValue;

        public static decimal ReturnValue(decimal decimalValue) => decimalValue;

        public static double ReturnValue(double doubleValue) => doubleValue;

        public static float ReturnValue(float floatValue) => floatValue;

        public static int ReturnValue(int intValue) => intValue;

        public static uint ReturnValue(uint uintValue) => uintValue;

        public static long ReturnValue(long longValue) => longValue;

        public static ulong ReturnValue(ulong ulongValue) => ulongValue;

        public static short ReturnValue(short shortValue) => shortValue;

        public static ushort ReturnValue(ushort ushortValue) => ushortValue;
    }
}
