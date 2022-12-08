using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Roman.Vasko.Classes {
    public class Lab2String {

        static public string Task0(string task) {
            StringBuilder sb = new StringBuilder();
            string[] tempMass = task.Split('-');
            foreach (string temp in tempMass) {
                int numberCount = 0;
            char[] tempChar = temp.ToCharArray();
                for (int i = 0; i < tempChar.Length; i++) {
                    if (Char.IsDigit(tempChar[i])) {
                        numberCount++;
                    }
                    if (numberCount == 4) {
                        sb.Append(temp + "-");
                    }
                }
                
            }
            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        static public string Task1(string task) {
            StringBuilder sb = new StringBuilder();
            string[] tempMass = task.Split('-');
            foreach (string temp in tempMass) {
                if (temp.Length == 3) {
                    sb.Append("***" + "-");
                } else {
                    sb.Append(temp + "-");

                }

            }
            return sb.Remove(sb.Length -1,1).ToString();
        }

        static public string Task2(string task) {
            StringBuilder sb = new StringBuilder();
            foreach (char temp in task.ToCharArray()) {
                if (sb.Length == 3 || sb.Length == 7 || sb.Length == 9) {
                    sb.Append('/');
                }
                
                if (Char.IsLetter(temp)) {
                    sb.Append(Char.ToLower(temp));
                }
                
            }
            return sb.ToString();
            //not work
            //string tempStr = sb.ToString();
            //string result = String.Format("{0:###/###/#/#}", tempStr);
            //return result;
        }
        static public string Task3(string task) {
            StringBuilder sb = new StringBuilder();
            sb.Append("Letters: ");
            foreach (char temp in task.ToCharArray()) {
                if (sb.Length == 12 || sb.Length == 16 || sb.Length == 18) {
                    sb.Append('/');
                }

                if (Char.IsLetter(temp)) {
                    sb.Append(Char.ToUpper(temp));
                }

            }
            return sb.ToString();
        }
        static public string Task4(string task) {
            StringBuilder sb = new StringBuilder();
            if (task.IndexOf("abc") != -1 || task.IndexOf("ABC") != -1) {
                sb.Append("contain");
                return sb.ToString();
            }
         sb.Append("not contain");
         return sb.ToString();   
        }
        static public string Task5(string task) {
            StringBuilder sb = new StringBuilder();
            if (task.StartsWith("555")) {
                sb.Append("contain");
                return sb.ToString();
            }
            sb.Append("not contain");
            return sb.ToString();
        }
        static public string Task6(string task) {
            StringBuilder sb = new StringBuilder();
            if (task.EndsWith("1a2b")) {
                sb.Append("contain");
                return sb.ToString();
            }
            sb.Append("not contain");
            return sb.ToString();
        }
    }
}