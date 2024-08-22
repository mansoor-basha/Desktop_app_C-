namespace WindowsFormsApp1
{
    internal class ConvolutionMatrix
    {
        public ConvolutionMatrix(float[][] sharpenMatrixElements)
        {
            SharpenMatrixElements = sharpenMatrixElements;
        }

        public float[][] SharpenMatrixElements { get; }
    }
}