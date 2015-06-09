using System;
using System.Collections;

namespace dataCoding
{
    class LZW
    {
        public Hashtable lzwHashtable = new Hashtable();
        private static int tableIndex = 0;
        private string lzwMessage = "";
        public string LzwCode { get; set; }
        
        public LZW(string message)
        {
            lzwMessage = message;

            foreach (char c in message)
            {
                if (lzwHashtable.Contains(c.ToString()))
                    continue;

                lzwHashtable.Add(c.ToString(),tableIndex++);
            }
        }

        public string GetLZWKey(char c)
        {
            
            return lzwHashtable[c].ToString();

        }

        public void DoLZWCoding()
        {
            string curentStr = lzwMessage[0].ToString();
            int charIndex = 1;
            char nextChar = lzwMessage[1];
            LzwCode = "";


            while (true)
            {


                if (! lzwHashtable.ContainsKey(curentStr + nextChar))
                {
                    LzwCode = LzwCode + Convert.ToString((int)lzwHashtable[curentStr],2) + " ";
                    lzwHashtable.Add(curentStr + nextChar,tableIndex++);
                    curentStr = nextChar.ToString();

                }
                else
                {
                    curentStr += nextChar;
                }
                

                if (charIndex < lzwMessage.Length - 1)
                {
                    nextChar = lzwMessage[++charIndex];
                }

                else
                {
                    LzwCode += Convert.ToString((int)lzwHashtable[curentStr], 2);
                    break;
                }
                
            }
        }




    }
}
