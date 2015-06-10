using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataCoding
{   
    class LZ77
    {
        string substring = "";
        private string buf = "";
        private string mstring = "";
        Hashtable lz77Hashtable = new Hashtable();

        public void DoEncoding(string str)
        {
            int subStrIndex = 0;
            int pos = 0;
            int lnth = 0;
            mstring = str;
            buf = mstring.Substring(subStrIndex,2);

            for (int i = 0; i < mstring.Length; i++)
            {
                if (lz77Hashtable.ContainsKey(buf[0].ToString()))
                {
                    
                }
                else
                {
                    lz77Hashtable.Add(buf[0].ToString(), new int{0,0});
                }
            }
        }




    }
}
