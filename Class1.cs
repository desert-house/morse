using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace morse
{
    class Morse
    {
        private static readonly Dictionary<string, string> _abc1 = new Dictionary<string, string>(36)
        {
            ["*-"] = "A",
            ["-***"] = "B",
            ["-*-*"] = "C",
            ["-**"] = "D",
            ["*"] = "E",
            ["**-*"] = "F",
            ["--*"] = "G",
            ["****"] = "H",
            ["**"] = "I",
            ["*---"] = "J",
            ["-*-"] = "K",
            ["*-**"] = "L",
            ["--"] = "M",
            ["-*"] = "N",
            ["---"] = "O",
            ["*--*"] = "P",
            ["--*-"] = "Q",
            ["*-*"] = "R",
            ["***"] = "S",
            ["-"] = "T",
            ["**-"] = "U",
            ["***-"] = "V",
            ["*--"] = "W",
            ["-**-"] = "X",
            ["-*--"] = "Y",
            ["--**"] = "Z",
            ["*----"] = "1",
            ["**---"] = "2",
            ["***--"] = "3",
            ["****-"] = "4",
            ["*****"] = "5",
            ["-****"] = "6",
            ["--***"] = "7",
            ["---**"] = "8",
            ["----*"] = "9",
            ["-----"] = "0"
        };

        private static readonly Dictionary<string, string> _abc2 = new Dictionary<string, string>(36)
        {
            ["A"] = "*-",
            ["B"] = "-***",
            ["C"] = "-*-*",
            ["D"] = "-**",
            ["E"] = "*",
            ["F"] = "**-*",
            ["G"] = "--*",
            ["H"] = "****",
            ["I"] = "**",
            ["J"] = "*---",
            ["K"] = "-*-",
            ["L"] = "*-**",
            ["M"] = "--",
            ["N"] = "-*",
            ["O"] = "---",
            ["P"] = "*--*",
            ["Q"] = "--*-",
            ["R"] = "*-*",
            ["S"] = "***",
            ["T"] = "-",
            ["U"] = "**-",
            ["V"] = "***-",
            ["W"] = "*--",
            ["X"] = "-**-",
            ["Y"] = "-*--",
            ["Z"] = "--**",
            ["1"] = "*----",
            ["2"] = "**---",
            ["3"] = "***--",
            ["4"] = "****-",
            ["5"] = "*****",
            ["6"] = "-****",
            ["7"] = "--***",
            ["8"] = "---**",
            ["9"] = "----*",
            ["0"] = "-----"
        };

        private static readonly Dictionary<string, string> _abc3 = new Dictionary<string, string>(41)
        {
            ["*-"] = "А",
            ["-***"] = "Б",
            ["*--"] = "В",
            ["--*"] = "Г",
            ["-**"] = "Д",
            ["*"] = "Е",
            ["***-"] = "Ж",
            ["--**"] = "З",
            ["**"] = "И",
            ["-*-*"] = "К",
            ["*-**"] = "Л",
            ["--"] = "М",
            ["-*"] = "Н",
            ["---"] = "О",
            ["*--*"] = "П",
            ["*-*"] = "Р",
            ["***"] = "С",
            ["-"] = "Т",
            ["**-"] = "У",
            ["**-*"] = "Ф",
            ["****"] = "Х",
            ["-*-*"] = "Ц",
            ["---*"] = "Ч",
            ["----"] = "Ш",
            ["--*-"] = "Щ",
            ["*--*-*"] = "Ъ",
            ["-*--"] = "Ы",
            ["-**-"] = "Ь",
            ["***-***"] = "Э",
            ["**--"] = "Ю",
            ["*-*-"] = "Я",
            ["*----"] = "1",
            ["**---"] = "2",
            ["***--"] = "3",
            ["****-"] = "4",
            ["*****"] = "5",
            ["-****"] = "6",
            ["--***"] = "7",
            ["---**"] = "8",
            ["----*"] = "9",
            ["-----"] = "0"
        };

        private static readonly Dictionary<string, string> _abc4 = new Dictionary<string, string>(41)
        {
            ["А"] = "*-",
            ["Б"] = "-***",
            ["В"] = "*--",
            ["Г"] = "--*",
            ["Д"] = "-**",
            ["Е"] = "*",
            ["Ж"] = "***-",
            ["З"] = "--**",
            ["И"] = "**",
            ["К"] = "-*-*",
            ["Л"] = "*-**",
            ["М"] = "--",
            ["Н"] = "-*",
            ["О"] = "---",
            ["П"] = "*--*",
            ["Р"] = "*-*",
            ["С"] = "***",
            ["Т"] = "-",
            ["У"] = "**-",
            ["Ф"] = "**-*",
            ["Х"] = "****",
            ["Ц"] = "-*-*",
            ["Ч"] = "---*",
            ["Ш"] = "----",
            ["Щ"] = "--*-",
            ["Ъ"] = "*--*-*",
            ["Ы"] = "-*--",
            ["Ь"] = "-**-",
            ["Э"] = "***-***",
            ["Ю"] = "**--",
            ["Я"] = "*-*-",
            ["1"] = "*----",
            ["2"] = "**---",
            ["3"] = "***--",
            ["4"] = "****-",
            ["5"] = "*****",
            ["6"] = "-****",
            ["7"] = "--***",
            ["8"] = "---**",
            ["9"] = "----*",
            ["0"] = "-----"
        };

        public static void Translate(int i)
        {
            string instr = "";
            string outStr = "";
            using (var fReader = new StreamReader("./read.txt"))
            {
                if ((i == 3) || (i == 1))
                {
                    string temp = "";
                    while (!fReader.EndOfStream)
                    {
                        instr = "";
                        temp = "";
                        while (!(temp == " ")) {
                            temp = Convert.ToChar(fReader.Read()).ToString();
                            instr += temp;
                        }
                        instr = instr.Replace(" ", "");
                        if (instr == " ")
                            outStr += " ";
                        else
                            switch (i)
                            {
                                case 1:
                                    try
                                    {
                                        outStr += _abc1[instr];
                                    }
                                    catch
                                    {
                                        outStr += instr;
                                    }

                                    break;
                                case 3:
                                    try
                                    {
                                        outStr += _abc3[instr];
                                    }
                                    catch
                                    {
                                        outStr += instr;
                                    }

                                    break;
                            }
                    }
                }
                else
                {
                    while (!fReader.EndOfStream)
                    {
                        instr = Convert.ToChar(fReader.Read()).ToString();
                        if (instr == " ")
                            outStr += " ";
                        else
                            switch (i)
                            {
                                case 2:
                                    try
                                    {
                                        outStr += _abc2[instr] + " ";
                                    }
                                    catch
                                    {
                                        outStr += instr + " ";
                                    }

                                    break;
                                case 4:
                                    try
                                    {
                                        outStr += _abc4[instr] + " ";
                                    }
                                    catch
                                    {
                                        outStr += instr + " ";
                                    }

                                    break;
                            }
                    }
                }
            }

            Console.WriteLine(instr);
            Console.ReadLine();

            using (var fWriter = new StreamWriter("./output.txt", false))
            {
                fWriter.Write(outStr);
            }
        }
    }
}