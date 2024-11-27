using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class Sorts
    {
        public List<int> BubbleSort(List<int> list)
        {
            for (int i = 0; i < list.Count() - 1; i++)
            {
                for (int j = 0; j < list.Count() - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        var temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
        public List<int> InsertionSort(List<int> array)
        {
            for (int i = 1; i < array.Count(); i++)
            {
                int j;
                int buf = array[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < buf)
                        break;

                    array[j + 1] = array[j];
                }
                array[j + 1] = buf;
            }
            return array;
        }
    }
}
