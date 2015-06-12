using System.Collections.Generic;
using System.Linq;

namespace dataCoding
{   
    /// <summary>
    /// клас кодування інформації
    /// </summary>
    class LZ77
    {
        
        public List<LZ77CodeElement> lz77CodesList = new List<LZ77CodeElement>();
        /// <summary>
        /// метод кодування інформації
        /// </summary>
        /// <param name="str"> рядок типу string</param>
        public void DoEncoding(string str)
        {
            int posInd = 0;
            int lnthInd = 0;
            int subStrIndex = 0;
            //string substring = "";
            string buf = str.Substring(subStrIndex,2);
            string dictionary = "";


            while (true)
            {
                for (int i = 0; i < buf.Length; i++)
                {
                    if (dictionary.Contains(buf[i]))
                    {
                        posInd = dictionary.IndexOf(buf[i]);
                        lnthInd++;
                        continue;
                    }
                    else
                    {
                        if (i == 0)
                        {
                            dictionary += buf[i];
                            lz77CodesList.Add(new LZ77CodeElement(0, 0, buf[i]));
                            subStrIndex += 1;
                            break;
                        }
                        else
                        {
                            dictionary += buf;
                            lz77CodesList.Add(new LZ77CodeElement(posInd, lnthInd, buf[i]));
                            subStrIndex += 2;
                            break;
                        }

                        
                    }
                }

                if (subStrIndex != str.Length - 1)
                {
                    buf = str.Substring(subStrIndex, 2);
                }
                else
                {
                    buf = str[str.Length - 1].ToString();
                }
                
                
                if (buf.Equals(str[str.Length - 1].ToString()))
                {
                    lz77CodesList.Add(new LZ77CodeElement(0, 0, buf[0]));
                    break;
                }
            }
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < lz77CodesList.Count; i++)
            {
                if (i != lz77CodesList.Count - 1)
                {
                    result = result + "(" + lz77CodesList[i].DicIndex + "," +
                         + lz77CodesList[i].MatchLength + "," + lz77CodesList[i].Symbol + ") ";
                }
                else
                {
                    result = result + "(" + lz77CodesList[i].DicIndex + "," +
                         +lz77CodesList[i].MatchLength + "," + lz77CodesList[i].Symbol + ")";
                }
            }

            return result;
        }
    }
}
