using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GluttonousSnake
{
    internal class BasicParams
    {
        // Oppsite Direction
        private static Dictionary<char, char> opDr = new Dictionary<char, char> { { 'r', 'l' }, { 'l', 'r' }, { 'u', 'd' }, { 'd', 'u' } };

        public static char getOpDr(char dr) { return opDr[dr]; }
    }
}
