namespace _4_032_Delegate
{
    public class OverMaxEventArgs
    {
        private int valoreSoglia;

        public OverMaxEventArgs(int valoreSoglia)
        {
            ValoreSoglia = valoreSoglia;
        }

        public int ValoreSoglia { get => valoreSoglia; set => valoreSoglia = value; }
    }
}