using System;
using System.Collections;
using name_sorter_library;

namespace name_sorter {
    class Program {
        //Constants
        private const int NUMARGS = 1;
        private const string SORTED_FILENAME = "./sorted-names-list.txt";

        /// The main method
        static void Main(string[] args) {

            //Check that the number of arguments is correct, otherwise exit
            if(args.Length != NUMARGS){
                Console.WriteLine("name-sorter UNSORTED-NAMES-LIST.txt");
                Environment.Exit(0); //Exit without error
            }

            string unsorted_names_filename = args[0];
            ArrayList allNames = sorterLibrary.ReadInNames(unsorted_names_filename);
            allNames.Sort();

            sorterLibrary.WriteNamesToFile(SORTED_FILENAME, allNames);
        }
    }
}
