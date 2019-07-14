using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToBinary
{
    class BinaryToStringConverter
    {
        private const int byteLength = 8;//How many bits are in a byte
        private static BinaryToStringConverter _instance;
        public static BinaryToStringConverter GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BinaryToStringConverter();
            }

            return _instance;
        }

        private bool ChkIfCorrectBinaryString(string text)
        {
            foreach (char bit in text)
            {
                if ((bit == '0' || bit == '1') == false)
                {
                    return false;
                }
            }

            return true;
        }
        private string ToBinary(byte[] data)
        {
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0'))).Replace(" ", "");
        }

        private byte[] GetBytesFromString(string binaryData)
        {
            if (binaryData.Length % byteLength != 0)
            {
                throw new ArgumentException($"Provided binary data is not dividable by {byteLength}!");
            }

            if (ChkIfCorrectBinaryString(binaryData) == false)
            {
                throw new ArgumentException($"Provided binary data is corrupted! It should contain only 0s and 1s!");
            }

            int bytesAmount = binaryData.Length / byteLength;
            byte[] bytes = new byte[bytesAmount];

            for (int i = 0; i < bytesAmount; i++)
            {
                bytes[i] = Convert.ToByte(binaryData.Substring(i * byteLength, byteLength), 2);//2 for the base is binary
                //if (byte.TryParse(binaryData.Substring(i*byteLength, byteLength), out bytes[i]) == false)
                //{
                //    throw new ArgumentException($"Provided binary data is corrupted - wrong number at {i*byteLength}!");
                //}
            }

            return bytes;
        }

        public string StringToBinary(string stringPassed)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            return ToBinary(encoding.GetBytes(stringPassed));
        }

        public string BinaryToString(string text)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            text = new string(text.Where(c => !char.IsWhiteSpace(c)).ToArray());
            byte[] bytes = GetBytesFromString(text);
            return encoding.GetString(bytes);
        }
    }
}
