
namespace Hash.FNV.Fnv
{
    public class Fnv1A
    {
        private readonly dynamic Fnv_Prime;
        private dynamic HashValue;
        private string Text;

        public Fnv1A(string Text, dynamic Fnv_Prime, dynamic Fnv_Offset_Basic)
        {
            this.Text = Text;
            this.HashValue = Fnv_Offset_Basic;
            this.Fnv_Prime = Fnv_Prime;
        }

        public dynamic GetHash()
        {
            foreach (var symbol in this.Text)
            {
                this.HashValue ^= symbol;
                this.HashValue *= this.Fnv_Prime;
            }

            return HashValue;
        }
        
    }
}