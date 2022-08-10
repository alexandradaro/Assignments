namespace Assignment4
{
    internal class ArrayMultiplication
    {
        static void Main(string[] args)
        {
            //first 3 dimensional array with initialized values

            int[,,] arrayFirst = new int[2, 2, 2]
            {

                { {2,1},{1,2} },
                { {1,1},{2,1} }
            };
            //second 3 dimentional array with initialized values
            int[,,] arraySecond = new int[2, 2, 2]
            {
                { {1,2},{2,3} },
                { {2,3},{4,5} }
            };
            // result array
            int[,,] arrayResult = new int[2, 2, 2];

            // looping through the first array
            for (int i = 0; i < arrayFirst.GetLength(0); i++)
            {
                for (int j = 0; j < arrayFirst.GetLength(1); j++)
                {
                    for (int k = 0; k < arrayFirst.GetLength(2); k++)
                    {
                        // multiplying first and second array
                        arrayResult[i, j, k] += arraySecond[i, j, k] * arrayFirst[i, j, k];
                        // printing result
                        Console.WriteLine(arrayResult[i, j, k]);
                    }

                }
            }
        }
    }
}