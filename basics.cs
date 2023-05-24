using System;

namespace Basicsprogram {
    class Basics {
        public static int Add(int x, int y) {
            int result = x + y;
            return result;
        }
        public static int Strlen(string x) {
            int result;
            result = x.Length;
            return result;
        }
        public static int Divide(int x, int y) {
            int result;
            result = x / y;
            return result;
        }
        public static int Multiply(int x, int y) {
            int result;
            result = x * y;
            return result;
        }
        public static double Root(int x) {
            double result;
            result = Math.Sqrt(x);
            return result;
        }
        public static bool Contains(string x, char y) {
            bool result = false;
            int count = 0;
            for(int i = 0; i < Strlen(x);i++){
                char current = x[i];
                if(current == y){
                    count++;
                    result = true;
                }
            }
            return result;
        }
        public static int Subtract(int x, int y){
            int result;
            result = x - y;
            return result;
        }
        public static int HowMany(string x, char y){
            int count = 0;
            for(int i=0;i<Strlen(x);i++){
                char current = x[i];
                if(current == y){
                    count++;
                }
            }
            return count;
        }
        public static int MaxNum(List<int> x){
            int max = 0;
            for(int i=0;i<x.Count;i++){
                if(x[i] > max){
                    max = x[i];
                }
            }
            return max;
        }
    }
}