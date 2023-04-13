namespace LercCS
{
    /// <summary>
    /// Pixel data types for encode & decode.
    /// </summary>
    public enum LercDataTypes : uint
    {
        /// <summary>
        /// 8-bit, signed integer. See <see cref="System.SByte"/>.
        /// </summary>
        SByte = 0u,

        /// <summary>
        /// 8-bit, unsigned integer. See <see cref="System.Byte"/>.
        /// </summary>
        Byte,
        
        /// <summary>
        /// 16-bit, signed integer. See <see cref="System.Int16"/>.
        /// </summary>
        Short,
        UShort,
        Int,
        UInt,
        Float,
        Double = 7u
    }
}
