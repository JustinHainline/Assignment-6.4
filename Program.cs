namespace Assignment_6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
                new int[] { 1, 1, 1, 1, 1},
                new int[] {2, 2, 2, 2, 2},
                new int[] {3, 3, 3, 3, 3 },
                new int[] {4, 4, 4, 4, 4 },
                new int[] {5, 5, 5, 5, 5},
            };
            //print orignial 
            foreach (var row in matrix)
            {
                foreach (var number in row)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }

                Console.WriteLine("Rotated matrix:");

            Rotate(matrix);

            

        }
        public static  void Rotate(int[][] matrix)
        {
            int size = matrix.Length;// gets size of matrix
            int layerCount = size / 2; // gets layers for 3x3 there is only 1 

            for (int layer = 0; layer < layerCount; layer++)  //iterates through the layers only 1 for 3x3
            {
                int first = layer;   //starting index of layer
                int last = size - first - 1; // last index of layer

                for (int element = first; element < last; element++)  //through elements in current layer
                {
                    //element is current position
                    int offset = element - first; // difference between current and first
                    int top = matrix[first][element];
                    int rightSide = matrix[element][last];
                    int bottom = matrix[last][last - offset];
                    int leftSide = matrix[last - offset][first];

                    //// Rotate clockwise
                    matrix[first][element] = leftSide;
                    matrix[element][last] = top;
                    matrix[last][last - offset] = rightSide;
                    matrix[last - offset][first] = bottom;
                }
            }
           // print rotated 
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
