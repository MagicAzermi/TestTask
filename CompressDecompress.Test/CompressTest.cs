using ComposeDecompose;

namespace CompressDecompress.Test
{
    public class CompressTest
    {
        private CompressAndDecompress _compressAndDecompress;
        public CompressTest()
        {
            _compressAndDecompress = new CompressAndDecompress();
        }

        [Theory]
        [InlineData("aaabbcccdde", "a3b2c3d2e")]
        [InlineData("aaaaaaaaaaaaaaaaaaaa", "a20")]
        [InlineData("AAAaaa", "A3a3")]
        private void ReturnCompressedTest(string inputString, string outputString)
        {
            var _result = _compressAndDecompress.Compress(inputString);

            Assert.Equal(outputString, _result);
        }

        [Theory]
        [InlineData("aaabbcccdde")]
        [InlineData("aaaaaaaaaaaaaaaaaaaa")]
        [InlineData("AAAaaa")]
        private void ReturnDecompressedTest(string originalString)
        {
            var _compressed = _compressAndDecompress.Compress(originalString);
            var _decompressed = _compressAndDecompress.Decompress(_compressed);

            Assert.Equal(originalString, _decompressed);
        }

        [Fact]
        private void ReturnEmptyStringTest()
        {
            var _compressed = _compressAndDecompress.Compress(null);
            var _decompressed = _compressAndDecompress.Decompress(null);
            Assert.Null(_compressed);
            Assert.Null(_decompressed);
        }
    }
}
