using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pl2.test;

    namespace pl2.compiler
    {
        class Program
        {
            private static bool is_test_mode = true;

            static void Main(string[] args)
            {
                Console.WriteLine("комилятор PL/2");
                if (is_test_mode)
                {
                    execute_test();
                }
                Console.WriteLine( "комилятор PL/2 - выполнение завершено" );
                Console.ReadKey();
            }

            private static void execute_test()
            {
                //throw new NotImplementedException();
                            
                Console.WriteLine( "комилятор PL/2 - самотестирование" );
                pl2.test.Test_all test = new Test_all();
                test.run();
                Console.WriteLine( "комилятор PL/2 - окончание самотестирования" );
            }
        }
    }
    