using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Лабораторна_робота_2
{
    public class StringProcesser
    {
        public String Text { get; private set; }
        public StringProcesser() 
        {
            Text = String.Empty;
        }
        public StringProcesser(String Text)
        {
            if(Text == null)
            {
                this.Text = String.Empty;
            }
            this.Text = Text;
        }

        public List<String> Divide()
        {
            var TrimmedText = Text.Trim('.', ',', ':', ';', '-');
            var Words = TrimmedText.Split(' '); 
            return Words.ToList();
        }

        public String SortUsual()
        {
            List<String> Words = Divide();
            //сортування за допомогою LINQ
            var SortedWords = (from word in Words
                              orderby word.Length
                              select word).ToList();

            String SortedText = String.Empty;
            foreach(String word in SortedWords)
            {
                SortedText += word + " ";
            }
            return SortedText;
        }

        public String SortStandard()
        {
            List<String> Words = Divide();
            // сортування бульбашкою
            for (var i = 1; i < Words.Count; i++)
            {
                for (var j = 0; j < Words.Count - i; j++)
                {
                    if (Words[j].Length > Words[j + 1].Length)
                    {
                        var temp = Words[j + 1];
                        Words[j + 1] = Words[j];
                        Words[j] = temp;
                    }
                }
            }

            String SortedText = String.Empty;
            foreach (String word in Words)
            {
                SortedText += word + " ";
            }
            return SortedText;
        }
    }
    
}
