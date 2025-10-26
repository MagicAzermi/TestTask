using System.Text;

namespace ComposeDecompose
{
    public class ComposeAndDecompose
    {
        public string Compose(string inputString)
        {
            string _outputString = "";
            int? _counter;

            for (int _index = 0; _index < inputString.Length; _index++)
            {
                _counter = 0;

                while (inputString[_index] == inputString[_index + 1])
                {
                    _counter++;
                    _index++;
                }

                if(_counter == 1)
                {
                    _counter = null;
                }

                _outputString = _outputString + inputString[_index] + _counter;
            }

            return _outputString;
        }

        public string Decompose(string inputString)
        {
            string _outputString = "";



            return _outputString;
        }
    }
}
