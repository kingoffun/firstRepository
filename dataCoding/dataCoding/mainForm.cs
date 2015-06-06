using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dataCoding
{
    public partial class MainForm : Form
    {
        string stringMessage = "король";
        double[] values = { 0.36, 0.16, 0.16, 0.16, 0.16 };
        char[] alphabet = "окрль".ToCharArray();
        string[] shenonFanoCodes = new string[5];
        int shenonFanoCodesIndex = 0;

        public MainForm()
        {
            InitializeComponent();

        }

        // середнє значення імовірності
        private double getArrayMiddleValue(double[] valueArr, int start, int end)
        {
            double valuesSum = 0;

            for (int i = start; i <= end; i++)
            {
                valuesSum += valueArr[i];
            }

            return valuesSum / 2;
        }

        // обрахунок кодів алфавіту
        private void ShenonFanoCodeSearch(char brenchChar, string fullBranch, int startPos, int endPos)
        {
            double middleValue = 0;
            int middleIndex, index;
            double leftBranchSum;
            string c_branch = "";


            if (alphabet != null)
            {
                c_branch = fullBranch + brenchChar;

            }
            else
            {
                c_branch = "";
            }

            if (startPos == endPos)
            {

                Array.Reverse(c_branch.ToCharArray());
                if (startPos != alphabet.Length - 1)
                {
                    shenonFanoCodes[shenonFanoCodesIndex] = c_branch;
                    shenonFanoCodesIndex++;
                }
                else
                {
                    shenonFanoCodes[shenonFanoCodesIndex] = c_branch;
                }

                return;
            }

            middleValue = getArrayMiddleValue(values, startPos, endPos);

            leftBranchSum = 0;
            index = startPos;
            middleIndex = index;

            while ((!(leftBranchSum + values[index] > middleValue)) & (index < endPos))
            {
                leftBranchSum += values[index];
                index++;
                if (!(leftBranchSum + values[index] > middleValue))
                    middleIndex++;
            }

            if ((leftBranchSum + values[index + 1] > middleValue) & leftBranchSum < middleValue)
                middleIndex++;

            ShenonFanoCodeSearch('1', c_branch, startPos, middleIndex);

            ShenonFanoCodeSearch('0', c_branch, middleIndex + 1, endPos);
        }



        private void shenonFanoButton_Click(object sender, EventArgs e)
        {
            ShenonFanoCodeSearch(' ', "", 0, 4);

            // вивід алфавіту
            foreach (char c in stringMessage.ToCharArray())
            {
                shenonFanoCodeTextBox.Text += shenonFanoCodes[Array.IndexOf(alphabet, c)];
            }

        }

        
        // реалізує код Хафмана
        void combineElemrnts(ref int[] val, ref string[] alphbt, int left, int right, ref Hashtable haphmanCode)
        {
            if (val.Length >= 3)
            {
                if (val[left - 1] < val[right])
                {
                    left--;
                    right--;
                }

            }


            int sumVal = val[left] + val[right];
            string sumAlphbt = alphbt[left] + alphbt[right];

            if (alphbt[left].Length > 1)
            {
                for (int i = 0; i < alphbt[left].Length; i++)
                {
                    haphmanCode[alphbt[left][i].ToString()] += "0";
                }
            }
            else
            {
                haphmanCode[alphbt[left]] += "0";
            }

            if (alphbt[right].Length > 1)
            {
                for (int i = 0; i < alphbt[right].Length; i++)
                {
                    haphmanCode[alphbt[right][i].ToString()] += "1";
                }
            }
            else
            {
                haphmanCode[alphbt[right]] += "1";
            }
            
            

            int[] cloneVal = val;
            string[] cloneAlphbt = alphbt;

            alphbt = new string[cloneAlphbt.Length - 1];
            val = new int[cloneVal.Length - 1];

            for (int i = 0; i < alphbt.Length; i++)
            {
                if (i < left)
                {
                    alphbt[i] = cloneAlphbt[i];
                    val[i] = cloneVal[i];
                }
                else
                {
                    if (i == left)
                    {
                        alphbt[i] = sumAlphbt;
                        val[i] = sumVal;
                    }
                    else
                    {
                        alphbt[i] = cloneAlphbt[i + 1];
                        val[i] = cloneVal[i + 1];
                    }
                }
            }
        }

        private void haphmanButton_Click(object sender, EventArgs e)
        {
            int[] valuesHaphman = { 2, 1, 1, 1, 1 };
            string[] haphmanAlphabet = new[] { "о", "к", "р", "л", "ь" };
            Hashtable haphmanHashtable = new Hashtable();

            for (int i = 0; i < haphmanAlphabet.Length; i++)
            {
                haphmanHashtable.Add(haphmanAlphabet[i], "");
            }

            while (haphmanAlphabet.Length > 1)
            {
                combineElemrnts(ref valuesHaphman, ref haphmanAlphabet, haphmanAlphabet.Length - 2, haphmanAlphabet.Length - 1, ref haphmanHashtable);
            }

            foreach (char c in stringMessage.ToCharArray())
            {

                haphmanCodeTextBox.Text = haphmanCodeTextBox.Text + haphmanHashtable[c.ToString()] + " ";

            }
        }


    }
}