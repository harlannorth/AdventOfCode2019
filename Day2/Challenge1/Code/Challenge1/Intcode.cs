using System;
using System.Collections.Generic;

namespace Challenge1
{
    public class Intcode
    {
        private const char delimiter = ',';

        public int[] RunIntCode(int[] input)
        {
            var program = input;

            var currentPosition = 0;
            var complete = false;
            do
            {
                var opCode = program[currentPosition];
                switch(opCode)
                {
                    case 1:
                        program = PerformOperationOne(currentPosition, program);
                        break;
                    case 2:
                        program = PerformOperationTwo(currentPosition, program);
                        break;
                    case 99:
                    default:
                        complete = true;
                        break;
                }
                currentPosition = currentPosition + 4;

            }
            while( !complete );
            
            return program;
        }

        public int[] ParseInput(string input)
        {
            var split = input.Split(delimiter);
            var program = new List<int>();

            foreach(var s in split)
            {
                if (int.TryParse(s.Trim(), out var code))
                {
                    program.Add(code);
                }
            }

            return program.ToArray();

        }

        public int[] PerformOperationOne(int position, int[] program)
        {
            var newValue = program[program[position+1]] + program[program[position+2]];
            
            program[program[position+3]] = newValue;

            return program;
        }
        
        public int[] PerformOperationTwo(int position, int[] program)
        {
            var newValue = program[program[position+1]] * program[program[position+2]];
            
            program[program[position+3]] = newValue;
            
            return program;
        }

    }
}
