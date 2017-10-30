using System;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace name_sorter {
    class Program {
        //Constants
        private const int NUMARGS = 1;
        private const string SORTED_FILENAME = "./sorted-names-list.txt";

        /// The main method
        static void Main(string[] args) {

            Stopwatch s = new Stopwatch();
            s.Start();

            //Check that the number of arguments is correct, otherwise exit
            if(args.Length != NUMARGS){
                Console.WriteLine("name-sorter UNSORTED-NAMES-LIST.txt");
                Environment.Exit(0); //Exit without error
            }

            string unsorted_names_filename = args[0];
            ArrayList allNames = ReadInNames(unsorted_names_filename);
            allNames.Sort();

            WriteNamesToFile(SORTED_FILENAME, allNames);
            s.Stop();
            Console.WriteLine("Time taken: " + s.Elapsed.TotalSeconds);
        }

        /// Reads in a list of names in a file, each on a new line
        /// The names are of the form GIVENNAMES LASTNAME
        /// They are read into the list as LASTNAME GIVENNAMES
        static ArrayList ReadInNames(string filename){
            ArrayList nameList = new ArrayList();
            //Read in all the names in the file
            var names_file = File.ReadLines(filename);

            //Move the last name to in front of the name and add to the array list
            foreach(string name in names_file){
                nameList.Add(MoveLastNameFromBackToFront(name));
            }
            return nameList;
        }

        /// Writes a list of names with names of the form LASTNAME GIVENNAMES to a
        /// file with the name filename. Names are then given the form GIVENNAMES LASTNAME
        /// when output. Also writes the names to the console
        static void WriteNamesToFile(string filename, ArrayList names){
            for(int i = 0; i < names.Count; i++){
                names[i] = MoveLastNameFromFrontToBack((string)names[i]);
                Console.WriteLine(names[i]);
            }
            //Write to a new file (have to convert ArrayList to string[] first)
            File.WriteAllLines(filename, (string[])names.ToArray(typeof(string)));
        }

        /// Takes a name of the form GIVENNAMES LASTNAME and returns
        /// the name with the form LASTNAME GIVENNAMES
        static string MoveLastNameFromBackToFront(string name){
            string[] name_parts = name.Split(' ');
            string reconstructed_name = name_parts[name_parts.Length-1]; //Last name first
            for(int i = 0; i < name_parts.Length - 1; i++){
                reconstructed_name += " " + name_parts[i]; //Then all the other names
            }
            return reconstructed_name;
        }

        /// Takes a name of the form LASTNAME GIVENNAMES and returns
        /// the name with the form GIVENNAMES LASTNAME
        static string MoveLastNameFromFrontToBack(string name){
            string[] name_parts = name.Split(' ');
            string reconstructed_name = name_parts[1]; //The first given name
            for(int i = 2; i < name_parts.Length; i++){
                reconstructed_name += " " + name_parts[i]; //The other given names
            }
            reconstructed_name += " " + name_parts[0]; //Then the last name
            return reconstructed_name;
        }
    }
}
