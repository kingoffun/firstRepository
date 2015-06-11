namespace dataCoding
{
    class LZ77CodeElement
    {
        private int dicIndex;
        private int matchLength;
        private char symbol; 

        public int DicIndex
        {
            get { return dicIndex; }
        }

        public int MatchLength
        {
            get { return matchLength; }
        }

        public char Symbol
        {
            get { return symbol; }
        }

        public LZ77CodeElement(int index, int mlength, char symb)
        {
            dicIndex = index;
            matchLength = mlength;
            symbol = symb;
        }

    }
}
