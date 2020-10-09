using System;

namespace DataStructureArrays
{
    class Arrays
    {
        /// <summary>
        /// Count represents here the non fixed Length of the array
        /// </summary>
        public int Count { get; set; }

        // declare private array
        private int[] items;
        private int count;

        public int this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        //ctor
        public Arrays(int length)
        {
            
            items = new int[length];
            this.Count = count;

        }

        public void Insert(int item)
        {
            items[count] = item; // or items[count++] = item;
            count++;

            // if the array is full, resize it
            if(items.Length == count)
            {
                // Create a new array (double it)
                int[] newarr = new int[count * 2];

                // Copy all the existing items
                for (int i = 0; i < count; i++)
                {
                    newarr[i] = items[i];
                }

                // set items to this new array

                items = newarr;


            }   

        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public void RemoveAt(int index)
        {
            // validate index

            if (index < 0 || index > count)
                throw new Exception("index incorrect");

            // shift items to the left to fill the whole

            for (int i = index; i < count; i++)
            {
                items[i] = items[i + 1];
            }

            count--;
           
        }

        // O(n)
        public int IndexOf(int item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == item)
                    return i;
            }

            return -1;
        }

        public int Max()
        {
            int max = items[0];

            for (int i = 1; i < count; i++)
            {
                // sort the array
                if (items[i] > max)
                    max = items[i];
            }
            return max;
        }


        public void Intersect(int[] array2)
        {
            int[] intersect = new int[count];
            int temp = 0;

            // sort the array 

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (items[i] > items[j])
                    {
                        temp = items[i];

                        items[i] = items[j];

                        items[j] = temp;


                    }
                }

            }

            // intersected array 
            for (int i = 0; i < count; i++)
            {
                if (items[i] == array2[i])
                    intersect[i] = items[i];

            }

        }

        public void Sort()
        {
            int temp = 0;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (items[i] > items[j])
                    {
                        temp = items[i];

                        items[i] = items[j];

                        items[j] = temp;


                    }
                }

            }
        }

        public static void Reverse(int[] arr)
        {
            if (arr == null)
                throw new Exception("the array cannot be null");


            int[] reverse = new int[arr.Length];
            int length = reverse.Length - 1;


            for (int i = 0; i < length; i++)
            {
                reverse[i] = length - i;
            }

            for (int j = 0; j < length; j++)
            {
                Console.Write(reverse[j] + " ");
            }

        }






    }
}
