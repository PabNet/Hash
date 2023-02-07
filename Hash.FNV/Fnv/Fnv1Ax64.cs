namespace Hash.FNV.Fnv
{
    public class Fnv1Ax64 : Fnv1A
    {
        public Fnv1Ax64(string Text) : 
            base(Text, (ulong)0x00000100000001B3, (ulong)0xCBF29CE484222325){ }
        
    }
}