namespace Assignment2
{
    internal class Sorter
    {
        static void Main(string[] args)
        {
            // creating and initializing an array
            int[] array = new int[] { 2, 1, 3, 5, 4, 8, 6 };
            int sorted = 0;

            
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i + 1; j < array.Length; j++)

                    // check if preceding value is lesser than current value in the array
                    if (array[i] < array[j])
                    {

                        sorted = array[i];
                        array[i] = array[j];
                        array[j] = sorted;
                    }

            // print all element of array in descending order
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.ReadLine();
        }
    }
}
