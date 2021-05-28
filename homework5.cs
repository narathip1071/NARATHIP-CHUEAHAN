using System;

namespace การบ้าน_5._1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write(" image data file : ");
            string imageDataFilePath = Console.ReadLine();
            Console.Write(" Convolution Kernel data file : ");
            string DataFileConvolutionKernel = Console.ReadLine();
            Console.Write(" output image data file : ");
            string DataFileOutput = Console.ReadLine();


            double[,] imageDataArray = ReadImageDataFromFile(imageDataFilePath);
            Console.WriteLine();
            double[,] imageDataConvolution = ReadImageDataFromFile(DataFileConvolutionKernel);
            Console.WriteLine();

            double[,] repeatedArray = new double[7, 7];
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    int I = ((i - 1) + 5) % 5;
                    int J = ((j - 1) + 5) % 5;
                    repeatedArray[i, j] = imageDataArray[I, J];
                    Console.Write("{0} ", imageDataArray[I, J]);
                }
                Console.WriteLine();
            }

            double[,] ConvolutionKernelArray = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ConvolutionKernelArray[i, j] = imageDataConvolution[i, j];
                }
                Console.WriteLine();
            }

            double[,] OutputFileArray = Convolution(repeatedArray, ConvolutionKernelArray);
            Console.WriteLine();
            WriteImageDataToFile(imageDataFilePath, imageDataArray);

        }

        static double[,] Convolution(double[,] repeatedArray, double[,] ConvolutionKernelArray)
        {
            double[,] OutputFileArray = new double[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int Row1 = i; int Row2 = i + 1; int Row3 = i + 2;
                    int column1 = j; int column2 = j + 1; int column3 = j + 2;
                    OutputFileArray[i, j] = (repeatedArray[Row1, column1] * ConvolutionKernelArray[0, 0])
                        + (repeatedArray[Row1, column2] * ConvolutionKernelArray[0, 1]) + (repeatedArray[Row1, column3] * ConvolutionKernelArray[0, 2])
                        + (repeatedArray[Row2, column1] * ConvolutionKernelArray[1, 0]) + (repeatedArray[Row2, column2] * ConvolutionKernelArray[1, 1])
                        + (repeatedArray[Row2, column3] * ConvolutionKernelArray[1, 2]) + (repeatedArray[Row3, column1] * ConvolutionKernelArray[2, 0])
                        + (repeatedArray[Row3, column2] * ConvolutionKernelArray[2, 1]) + (repeatedArray[Row3, column3] * ConvolutionKernelArray[2, 2]);

                    Console.Write("{0}  ", OutputFileArray[i, j]);
                }
                Console.WriteLine();
            }
            return OutputFileArray;
        }

        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                    Console.Write("{0}  ", imageDataArray[i, j]);
                }
                Console.WriteLine();
            }
            return imageDataArray;
        }
        static void WriteImageDataToFile(string imageDataFilePath, double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i, imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }
            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }

    }
}
    

    

