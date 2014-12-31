using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManager.Desktop{
    public class Common {
        public struct State {
            public static int _new = 0;
            public static int _modify = 1;
        }

        public struct Letters {
            public static string _upperLetters = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            public static string _lowerLetters = @"abcdefghijklmnopqrstuvwxyz";
            public static string _number = @"0123456789";
            public static string _specialCharacters = "";
        }
    }
}
