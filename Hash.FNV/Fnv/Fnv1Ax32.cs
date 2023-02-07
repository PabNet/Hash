namespace Hash.FNV.Fnv
{
    public class Fnv1Ax32 : Fnv1A
    {
        public Fnv1Ax32(string Text) : 
            base(Text, (uint)0x01000193, (uint)0x811C9DC5) { }
        
    }
}