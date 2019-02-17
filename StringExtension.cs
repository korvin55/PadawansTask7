using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            if ( array == null)
            {
                throw new ArgumentNullException();
            }
            else if( array.Length == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                int sumnul = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == null)
                    {
                        sumnul++;
                    }
                }
                if (sumnul == array.Length)
                {
                    throw new ArgumentNullException();
                }
                for (int count = 0; count < array.Length; count++)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i].Length > array[i + 1].Length)
                        {
                            string str = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = str;
                        }
                    }
                }
            }
        }
    }
}
