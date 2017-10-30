using Xunit;
using name_sorter_library;
using System.Collections;

namespace name_sorter_tests {
    public class unitTests {

        //Constant file names for unit tests
        public const string ONE_NAME_FILENAME = "./testFiles/oneName.txt";
        public const string TWO_NAMES_FILENAME = "./testFiles/twoNames.txt";
        public const string THREE_NAMES_FILENAME = "./testFiles/threeNames.txt";

        //----------- Tests for function MoveLastNameFromBackToFront -----------------
        [Fact]
        public void MoveLastNameFromBackToFront_OneName(){
            Assert.Equal("Jerry", sorterLibrary.MoveLastNameFromBackToFront("Jerry"));
        }

        [Fact]
        public void MoveLastNameFromBackToFront_TwoNames(){
            Assert.Equal("Smith Jerry", sorterLibrary.MoveLastNameFromBackToFront("Jerry Smith"));
        }

        [Fact]
        public void MoveLastNameFromBackToFront_ThreeNames(){
            Assert.Equal("Smith Jerry Thomas", sorterLibrary.MoveLastNameFromBackToFront("Jerry Thomas Smith"));
        }

        [Fact]
        public void MoveLastNameFromBackToFront_FourNames(){
            Assert.Equal("Smith Jerry Thomas Marcus", sorterLibrary.MoveLastNameFromBackToFront("Jerry Thomas Marcus Smith"));
        }

        //----------- Tests for function MoveLastNameFromFrontToBack -----------------
        [Fact]
        public void MoveLastNameFromFrontToBack_OneName(){
            Assert.Equal("Jerry", sorterLibrary.MoveLastNameFromFrontToBack("Jerry"));
        }

        [Fact]
        public void MoveLastNameFromFrontToBack_TwoNames(){
            Assert.Equal("Jerry Smith", sorterLibrary.MoveLastNameFromFrontToBack("Smith Jerry"));
        }

        [Fact]
        public void MoveLastNameFromFrontToBack_ThreeNames(){
            Assert.Equal("Jerry Thomas Smith", sorterLibrary.MoveLastNameFromFrontToBack("Smith Jerry Thomas"));
        }

        [Fact]
        public void MoveLastNameFromFrontToBack_FourNames(){
            Assert.Equal("Jerry Thomas Marcus Smith", sorterLibrary.MoveLastNameFromFrontToBack("Smith Jerry Thomas Marcus"));
        }

        //----------- Tests for function ReadInNames ---------------------
        [Fact]
        public void ReadInNames_oneName(){
            ArrayList names = sorterLibrary.ReadInNames(ONE_NAME_FILENAME);
            Assert.Equal("Bell Marcus", names[0]);
        }

        [Fact]
        public void ReadInNames_twoNames(){
            ArrayList names = sorterLibrary.ReadInNames(TWO_NAMES_FILENAME);
            Assert.Equal("Bell Marcus", names[0]);
            Assert.Equal("King Larry", names[1]);
        }

        [Fact]
        public void ReadInNames_threeNames(){
            ArrayList names = sorterLibrary.ReadInNames(THREE_NAMES_FILENAME);
            Assert.Equal("Bell Marcus", names[0]);
            Assert.Equal("King Larry", names[1]);
            Assert.Equal("Potter Harry", names[2]);
        }
    }
}
