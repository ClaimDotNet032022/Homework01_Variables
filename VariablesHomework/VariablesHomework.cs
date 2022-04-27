using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VariablesHomework
{
    [TestClass]
    public class Variables
    {
        [TestMethod]
        public void Declaration()
        {
            int number = 25;
            Assert.IsTrue(number == 25); // Make this pass without changing this statement (add other statements before or after to make it pass)
           bool boolean = true;
            Assert.IsTrue(boolean == true); // Make this pass without changing this statement
            double decimalValue = 99.9;
            Assert.IsTrue(decimalValue == 99.9); // Make this pass without changing this statement
            float floatingDecimalValue = 25.4f;
            Assert.IsTrue(floatingDecimalValue == 25.4f); // Make this pass without changing this statement
            string words = ("I am a programmer now");
            Assert.IsTrue(words == "I am a programmer now"); // Make this pass without changing this statement
            char character = ('z');
            Assert.IsTrue(character == 'z'); // Make this pass without changing this statement
        }

        [TestMethod]
        public void Assignment()
        {
            int i = 25;
            Assert.IsTrue(i == 25); // Make this pass without changing this statement (add or modify a statement above to make it pass)
            i =  100;
            Assert.IsTrue(i == 100); // Then make this pass without changing this statement

            float f = 3.5f;
            Assert.IsTrue(f == 3.5); // Make this pass without changing this statement (except you might need to add something)
            f = 99.9f;
            Assert.IsTrue(f == 99.9); // Then make this pass without changing this statement (except you might need to add something)

            bool b = true;
            Assert.IsTrue(b); // Make this pass without changing this statement
            b = false;
            Assert.IsTrue(b == false); // Then make this pass without changing this statement

            double d = 10.0;
            Assert.IsTrue(d == 10.0); // Make this pass without changing this statement
            d = 20.0;
            Assert.IsTrue(d == 20.0); // Then make this pass without changing this statement


            string s = "word";
            Assert.IsTrue(s == "word"); // Make this pass without changing this statement
            s = ("next");
            Assert.IsTrue(s == "next"); // Then make this pass without changing this statement

            char c = 'b';
            Assert.IsTrue(c == 'b'); // Make this pass without changing this statement
            c = 'c';
            Assert.IsTrue(c == 'c'); // Then make this pass without changing this statement

            int z = i;
            Assert.IsTrue(z == 100); // Make this pass by ONLY filling in the answer
        }

        // Refer to this if you need help https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators
        [TestMethod]
        public void Operators()
        {
            int a = 0;
            int b = a + 13;
            Assert.IsTrue(b == 13); // Make this pass by ONLY filling in the answer

            float f = 12.3f;
            float c = f - 7.43f;
            Assert.IsTrue(c == 4.87f); // Make this pass by ONLY filling in the answer
            Assert.IsTrue(f == 12.3f); // Make this pass by ONLY filling in the answer

            bool d = false;
            bool e = !d;
            Assert.IsTrue(e == true); // Make this pass by ONLY filling in the answer

            int anotherInt = 12;
            int g = -anotherInt;
            Assert.IsTrue(g == -12); // Make this pass by ONLY filling in the answer

            int yetAnotherInt = 23456;
            int t = yetAnotherInt * 3;
            Assert.IsTrue(t == 70368); // Make this pass by ONLY filling in the answer

            int z = 23456;
            z *= 3;
            Assert.IsTrue(z == 70368); // Make this pass by ONLY filling in the answer

            int h = 23;
            h++;
            Assert.IsTrue(h == 24); // Make this pass by ONLY filling in the answer
            h--;
            Assert.IsTrue(h == 23); // Make this pass by ONLY filling in the answer
            ++h;
            Assert.IsTrue(h == 24); // Make this pass by ONLY filling in the answer
            --h;
            Assert.IsTrue(h == 23); // Make this pass by ONLY filling in the answer
            h += 1;
            Assert.IsTrue(h ==24); // Make this pass by ONLY filling in the answer
            h -= 1;
            Assert.IsTrue(h == 23); // Make this pass by ONLY filling in the answer

            string l = "Hello! ";
            string m = l + "You!";
            Assert.IsTrue(m == "hello! you!"); // Make this pass by ONLY filling in the answer

            int v = 5;
            int x = v % 4;
            Assert.IsTrue(x == 1); // Make this pass by ONLY filling in the answer

            int finalInt = 15;
            int divisionResult = 15 / 3;
            Assert.IsTrue(divisionResult == 5); // Make this pass by ONLY filling in the answer

            finalInt = 15;
            finalInt /= 3;
            Assert.IsTrue(finalInt == 5); // Make this pass by ONLY filling in the answer

            int orderOfOperations = 2;
            orderOfOperations = 2 + 12 * (orderOfOperations * 3);
            Assert.IsTrue(orderOfOperations == 74); // Make this pass by ONLY filling in the answer
        }

        [TestMethod]
        public void Ranges()
        {
            Assert.IsTrue(int.MaxValue == 2147483648); // Make this pass
            Assert.IsTrue(int.MinValue == -2147483648); // Make this pass
            Assert.IsTrue(float.MaxValue == 3.4028234664E38f); // Make this pass
            Assert.IsTrue(float.MinValue == 1.1754943508E-38f); // Make this pass
            Assert.IsTrue(double.MaxValue == 1.7976931348623157E+308); // Make this pass
            Assert.IsTrue(double.MinValue == -1.7976931348623157E+308); // Make this pass
        }

        [TestMethod]
        public void Overflow()
        {
            unchecked // ignore this, it simple means im telling the compiler i know what I am doing.
            {
                Assert.IsTrue(int.MaxValue + 1 == 2147483649); // Make this pass (you can use a literal number or a symbol)
                Assert.IsTrue(int.MinValue - 1 == -2147483647); // Make this pass (you can use a literal number or a symbol)
                Assert.IsTrue(float.MaxValue + 1 == 3.4028234664E38f + 1); // Make this pass (you can use a literal number or a symbol)
                Assert.IsTrue(float.MinValue - 1 == 1.1754943508E-38f - 1); // Make this pass (you can use a literal number or a symbol)
                Assert.IsTrue(double.MaxValue + 1 == 1.7976931348623158E+308 +1); // Make this pass (you can use a literal number or a symbol)
                Assert.IsTrue(double.MinValue - 1 == -1.7976931348623156E+308 - 1); // Make this pass (you can use a literal number or a symbol)
            }
        }

        [TestMethod]
        public void Conversion()
        {
            int i = 13;
            double d = i;
            Assert.IsTrue(d == 13); // Make this pass by ONLY filling in the answer

            // Why does that compile andwork but this doesnt? (Add a comment with your answer)
            //double d = 15.5;
            d = 15.5;
            int c = (int)(double)d;
            // d is already declared 
            // double can store whole numbers and decimals,
            // but an interger can only store whole numbers.
        }

        [TestMethod]
        public void Casting()
        {
            // what am i doing here that make the above work? (Add a comment with your answer)
            double d = 15.5;
            int c = (int)d;
            Assert.IsTrue(c == 15); // Make this pass by ONLY filling in the answer

            string e = d.ToString();
            Assert.IsTrue(e == "15.5"); // Make this pass by ONLY filling in the answer
        }

        [TestMethod]
        public void Parsing()
        {
            string a = "67";
            int b = int.Parse(a);
            Assert.IsTrue(b == 67); // Make this pass by ONLY filling in the answer
        }
    }
}
