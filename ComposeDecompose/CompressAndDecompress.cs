using System.Text;

namespace ComposeDecompose
{
    public class CompressAndDecompress
    {


        public string Compress(string inputString)
        {
            if (string.IsNullOrEmpty(inputString)) return inputString;

            StringBuilder _outputString = new StringBuilder();
            int? _counter = 0;
            char? _currentChar = inputString[0];

            for (int _index = 0; _index < inputString.Length; _index++)
            {
                if(inputString[_index] != _currentChar)
                {
                    _outputString.Append(_currentChar);
                    if (_counter > 1) _outputString.Append(_counter);
                    _currentChar = inputString[_index];
                    _counter = 1;
                }
                else
                {
                    _counter++;
                }
            }

            _outputString.Append(_currentChar);
            if (_counter > 1) _outputString.Append(_counter);

            return _outputString.ToString();
        }

        public string Decompress(string inputString)
        {
            if (string.IsNullOrEmpty(inputString)) return inputString;

            StringBuilder _outputString = new StringBuilder();
            StringBuilder _letterCountString = new StringBuilder();
            int _index = 0;


            while (_index < inputString.Length)
            {
                char _currentChar = inputString[_index++];
                _outputString.Append( _currentChar);

                _letterCountString.Clear();
                while (_index < inputString.Length && Char.IsDigit(inputString[_index]))
                {
                    _letterCountString.Append(inputString[_index]);
                    _index++;
                }

                if(_letterCountString.ToString() != "")
                {
                    _outputString.Append(new string(_currentChar, Int32.Parse(_letterCountString.ToString()) - 1));
                }
            }

            return _outputString.ToString();
        }
    }
}
