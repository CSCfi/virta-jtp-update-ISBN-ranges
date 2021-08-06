using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace UpdateISBNRanges
{
    class Program
    {
        static void Main(string[] args)
        {

            //////////////////////////////////////////////
            // There is one parameter given to program  //
            // 1. args[0] = path to file                //
            ////////////////////////////////////////////////////////////////////////

            if (args.Length != 1)
            {
                Console.Write("amount of arguments is wrong");
            }

            else
            {

                FileOperations fileOperations = new FileOperations();

                // path to file which is first deleted (if exists) and after that get from ISBN api
                string pathToFile = args[0];

                // destroy the old file if exist
                fileOperations.deleteFile(pathToFile);

                // get file from the ISBN API
                fileOperations.getFileFromAPI(pathToFile);

                // remove DTD declarations at the beginning of xml file
                fileOperations.Remove_DTD_From_XML(pathToFile);

            }

        }

    }

}
