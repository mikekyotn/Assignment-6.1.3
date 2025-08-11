namespace Assignment_6._1._3
{
    //Given an integer array nums, move all 0's to the end of it while maintaining
    //the relative order of the non-zero elements.
    //Must do this in-place without making a copy of the array.
    //Status: Complete

    //I want to keep a pointer at the last location to write
    //Keep a count of the number of 0's I find
    //write to last location if number > 0; increment 0counter if ==0
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = { 0, 1, 0, 3, 12 };
            int[] test2 = { 0 };
            int[] test3 = { 0, 0, 0, 1, 2, 3, 4, 5, 6, 0, 0, 0 };
            MoveZeros(test1);
            MoveZeros(test2);
            MoveZeros(test3);
            Console.ReadKey();
        }

        static void MoveZeros(int[] intArray)
        {
            int writePointer = 0;
            int zeroCounter = 0;
            for (int i = 0; i < intArray.Length; i++)
            {                
                if (intArray[i] == 0)
                    zeroCounter++;
                else
                {
                    intArray[writePointer] = intArray[i];
                    writePointer++;
                }                
            }
            for (int i = intArray.Length - zeroCounter; i < intArray.Length; i++)
            { intArray[i] = 0; }

            PrintArray(intArray);
        }
        static void PrintArray(int[] intArray)
        {
            foreach (int i in intArray)
                Console.Write(i + " ");                
            
            Console.WriteLine();
        }
    }
}
