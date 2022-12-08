using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Roman.Vasko.Classes {
    internal class Lab2Hard {
        static public void pr() {

        }

        static public void Table(string[] args, string token, string funk) {
            StringBuilder sb = new StringBuilder();
            foreach (string arg in args) {
                sb.Append(arg + " ");
            }
            sb.Append(funk);
            Console.WriteLine(sb);
            sb.Clear();
            for (int i = 0; i <= 1; i++) {
                for (int j = 0; j <= 1; j++) {
                        sb.Append(i + " " + j + " " + operand(i,j,token) +'\n');
                }
            }
            Console.WriteLine(sb);
        }
        static public void Table(string[] args, string[] token, string funk) {
            StringBuilder sb = new StringBuilder();
            foreach (string arg in args) {
                sb.Append(arg + " ");
            }
            sb.Append(funk);
            Console.WriteLine(sb);
            sb.Clear();
            for (int i = 0; i <= 1; i++) {
                for (int j = 0; j <= 1; j++) {
                    for (int k = 0; k <= 1; k++) {
                        sb.Append(i + " " + j + " " + operand(i, j, k, token) + '\n');
                    }
                }
            }
            Console.WriteLine(sb);
        }
        static int operand(int i, int j, string token) {
            switch (token) {
                case "&": return i&j;
                case "|": return i|j;
                case "^": return i^j;
                //case "": return ij;
                //case "": return ij;
                //case "": return ij;
                //case "": return ij;
            }
            return -1;
        }
        static int operand(int i, int j, int k, string[] token) {
            int temp = 0;
            switch (token[0]) {
                case "&": temp = i & j; break;
                case "|": temp = i | j; break;
                case "^": temp = i ^ j; break;
                    //case "": return ij;
                    //case "": return ij;
                    //case "": return ij;
                    //case "": return ij;
            }
            switch (token[1]) {
                case "&": return temp & k;
                case "|": return temp | k;
                case "^": return temp ^ k;
                    //case "": return ij;
                    //case "": return ij;
                    //case "": return ij;
                    //case "": return ij;
            }
            return -1;
        }
    }
}
