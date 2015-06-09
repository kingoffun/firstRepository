using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataCoding
{
    class RLE
    {
        public string RleMessage { get; set; }

        public string GetRLECode(string str )
        {
            int index = 1;
            string rleCode = "";
            
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals(str[i + 1]))
                {
                    if (i != str.Length - 2)
                    {
                        index++;
                    }
                    else
                    {
                        index++;
                        rleCode = rleCode + index + str[i];
                    }

                }
                else
                {
                    if (i != str.Length - 2)
                    {
                        rleCode = rleCode + index + str[i];
                        index = 1;
                    }
                    else
                    {
                        rleCode = rleCode + index + str[i];
                        rleCode = rleCode + 1 + str[i + 1];
                    }
                }
            }

            return rleCode;
        }
    }
}
