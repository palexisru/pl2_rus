using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

    namespace pl2.test
    {
        /// <summary>
        /// тестирование всех библиотек
        /// </summary>
        public class Test_all
        {
            /// <summary>
            /// выполнение всех тестов
            /// </summary>
            public void run()
            {
                try{
                    test_files();
                }
                catch (Exception e)
                {
                    Trace.WriteLine(e.Message);
                }

                try{
                    test_projects();
                }
                catch (Exception e)
                {
                    Trace.WriteLine( e.Message );
                }
            }

            private void test_projects()
            {
                pl2.test.project.Test_all test = new pl2.test.project.Test_all();
                test.run();
            }

            private void test_files()
            {
                pl2.test.file.Test_all test = new pl2.test.file.Test_all();
                test.run();
            }
        }
    }
