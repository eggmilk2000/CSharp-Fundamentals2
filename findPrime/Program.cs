using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace homework
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Task task1 = TaskOne(); //find prime number from 1 -> 50
            Task task2 = TaskTwo(); //find prime number from 51 -> 100
            Task.WaitAll(task1,task2);
            
        }

        private static bool checkPrime(int num){
            if (num <= 1) return false;
            for(int index = 2; index < num; index++){
                if(num % index == 0){
                    return false;
                }
            }
            return true;
        }
        private static async Task TaskOne(){
            await Task.Delay(200);
            for(int i = 1; i <= 50; i++)
            {
                if(checkPrime(i)){
                    Console.WriteLine(i);
                }
            }
            
        }

        private static async Task TaskTwo(){
            await Task.Delay(200);
            for(int i = 51; i <= 100; i++)
            {
                if(checkPrime(i)){
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
