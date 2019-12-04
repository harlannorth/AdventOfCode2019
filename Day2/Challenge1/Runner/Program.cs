using System;
using Challenge1;

namespace Runner
{
    class Program
    {

         
        private const int desiredResult = 19690720;
        static void Main(string[] args)
        {

            

            var solved = false;
            var noun = 0;
            var verb = 0;

            for(noun = 0; noun <= 99; noun++)
            {
                for(verb = 0; verb <= 99; verb++)
                {

                    var input = new int[] {1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,6,1,19,2,19,13,23,1,23,10,27,1,13,27,31,2,31,10,35,1,35,9,39,1,39,13,43,1,13,43,47,1,47,13,51,1,13,51,55,1,5,55,59,2,10,59,63,1,9,63,67,1,6,67,71,2,71,13,75,2,75,13,79,1,79,9,83,2,83,10,87,1,9,87,91,1,6,91,95,1,95,10,99,1,99,13,103,1,13,103,107,2,13,107,111,1,111,9,115,2,115,10,119,1,119,5,123,1,123,2,127,1,127,5,0,99,2,14,0,0};
                    
                    input[1] = noun;
                    input[2] = verb;
                    
                    var intCode = new Intcode();
                    var result = intCode.RunIntCode(input);

                    if (result[0] == desiredResult) 
                    {
                        solved = true;
                        break;
                    }
                }
                if (solved) break;
            }
            
            // Console.WriteLine(solved);
            // Console.WriteLine(noun);
            // Console.WriteLine(verb);


            var x = (100 * noun) + verb;
            Console.WriteLine(x);
        }
    }
}
