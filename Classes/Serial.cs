using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectorKG
{
    class Serial
    {
        private readonly char[] serialKeyChars = new char[] { '2', '3', '4', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'M', 'N', 'P', 'R', 'T', 'W', 'X', 'Y', 'Z' };

        public string Generate( )
        {
            StringBuilder sb = new StringBuilder("A300");
            byte[] randomBytes = new byte[20];

            Random random = new Random( );
            random.NextBytes(randomBytes);

            for (int i = 0; i < 5; i++)
            {
                sb.AppendFormat("-{0}{1}{2}{3}", new object[]
                {
                    GetRandomChar(randomBytes[i * 4]),
                    GetRandomChar(randomBytes[i * 4 + 1]),
                    GetRandomChar(randomBytes[i * 4 + 2]),
                    GetRandomChar(randomBytes[i * 4 + 3])
                });
            }

            uint num = GetUint(sb.ToString( ));

            sb[2] = GetRandomChar((byte)(num % serialKeyChars.Length));
            sb[3] = GetRandomChar((byte)(num / serialKeyChars.Length % serialKeyChars.Length));
            return sb.ToString( );
        }

        private uint GetUint(string serial)
        {
            long num = 0L;
            foreach (int i in serial)
            {
                for (int j = 7; j >= 0; j--)
                {
                    bool flag = (num & 32768L) == 32768L ^ (i & 1 << j) != 0;
                    num = (num & 32767L) << 1;
                    if (flag)
                        num ^= 4129L;
                }
            }
            return (uint)num;
        }

        private char GetRandomChar(byte b)
        {
            return serialKeyChars[(int)b % serialKeyChars.Length];
        }
        
    }
}
