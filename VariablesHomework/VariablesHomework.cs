using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VariablesHomework
{
    [TestClass]
    public class Variables
    {
        [TestMethod]
        public void Declaration()
        {
            Assert.IsTrue(number == 25); // Make this pass without changing this statement (add other statements before or after to make it pass)
            Assert.IsTrue(boolean == true); // Make this pass without changing this statement
            Assert.IsTrue(decimalValue == 99.9); // Make this pass without changing this statement
            Assert.IsTrue(floatingDecimalValue == 25.4f); // Make this pass without changing this statement
            Assert.IsTrue(words == "I am a programmer now"); // Make this pass without changing this statement
            Assert.IsTrue(character == 'z'); // Make this pass without changing this statement
        }

        [TestMethod]
        public void Assignment()
        {
            int i = 0;
            Assert.IsTrue(i == 25); // Make this pass without changing this statement (add or modify a statement above to make it pass)

            Assert.IsTrue(i == 100); // Then make this pass without changing this statement

            float f = 0.0f;
            Assert.IsTrue(f == 3.5); // Make this pass without changing this statement (except you might need to add something)

            Assert.IsTrue(f == 99.9); // Then make this pass without changing this statement (except you might need to add something)

            bool b = false;
            Assert.IsTrue(b); // Make this pass without changing this statement

            Assert.IsTrue(b == false); // Then make this pass without changing this statement

            double d = 0.0;
            Assert.IsTrue(d == 10.0); // Make this pass without changing this statement

            Assert.IsTrue(d == 20.0); // Then make this pass without changing this statement


            string s = "";
            Assert.IsTrue(s == "word"); // Make this pass without changing this statement

            Assert.IsTrue(s == "next"); // Then make this pass without changing this statement

            char c = 'a';
            Assert.IsTrue(c == 'b'); // Make this pass without changing this statement

            Assert.IsTrue(c == 'c'); // Then make this pass without changing this statement

            int z = i;
            Assert.IsTrue(z == /*Answer here*/); // Make this pass by ONLY filling in the answer
        }

        // Refer to this if you need help https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators
        [TestMethod]
        public void Operators()
        {
            int a = 0;
            int b = a + 13; 
            Assert.IsTrue(b == /*Answer here*/); // Make this pass by ONLY filling in the answer

            float f = 12.3f;
            float c = f - 7.43f;
            Assert.IsTrue(c == /*Answer here*/); // Make this pass by ONLY filling in the answer
            Assert.IsTrue(f == /*Answer here*/); // Make this pass by ONLY filling in the answer

            bool d = false;
            bool e = !d;
            Assert.IsTrue(e == /*Answer here*/); // Make this pass by ONLY filling in the answer

            int anotherInt = 12;
            int g = -anotherInt; 
            Assert.IsTrue(g == /*Answer here*/); // Make this pass by ONLY filling in the answer

            int yetAnotherInt = 23456;
            int t = yetAnotherInt * 3;
            Assert.IsTrue(t == /*Answer here*/); // Make this pass by ONLY filling in the answer

            int z = 23456;
            z *= 3;
            Assert.IsTrue(z == /*Answer here*/); // Make this pass by ONLY filling in the answer

            int h = 23;
            h++;
            Assert.IsTrue(h == /*Answer here*/); // Make this pass by ONLY filling in the answer
            h--;
            Assert.IsTrue(h == /*Answer here*/); // Make this pass by ONLY filling in the answer
            ++h;
            Assert.IsTrue(h == /*Answer here*/); // Make this pass by ONLY filling in the answer
            --h;
            Assert.IsTrue(h == /*Answer here*/); // Make this pass by ONLY filling in the answer
            h += 1;
            Assert.IsTrue(h == /*Answer here*/); // Make this pass by ONLY filling in the answer
            h -= 1;
            Assert.IsTrue(h == /*Answer here*/); // Make this pass by ONLY filling in the answer

            string l = "Hello! ";
            string m = l + "You!";
            Assert.IsTrue(m == /*Answer here*/); // Make this pass by ONLY filling in the answer

            int v = 5;
            int x = v % 4;
            Assert.IsTrue(x == /*Answer here*/); // Make this pass by ONLY filling in the answer

            int finalInt = 15;
            int divisionResult = 15 / 3;
            Assert.IsTrue(divisionResult == /*Answer here*/); // Make this pass by ONLY filling in the answer

            finalInt = 15;
            finalInt /= 3;
            Assert.IsTrue(finalInt == /*Answer here*/); // Make this pass by ONLY filling in the answer

            int orderOfOperations = 2;
            orderOfOperations = 2 + 12 * (orderOfOperations * 3);
            Assert.IsTrue(orderOfOperations == /*Answer here*/); // Make this pass by ONLY filling in the answer
        }

        [TestMethod]
        public void Ranges()
        {
            Assert.IsTrue(int.MaxValue == /*Answer here*/); // Make this pass
            Assert.IsTrue(int.MinValue == /*Answer here*/); // Make this pass
            Assert.IsTrue(float.MaxValue == /*Answer here*/); // Make this pass
            Assert.IsTrue(float.MinValue == /*Answer here*/); // Make this pass
            Assert.IsTrue(double.MaxValue == /*Answer here*/); // Make this pass
            Assert.IsTrue(double.MinValue == /*Answer here*/); // Make this pass
        }

        [TestMethod]
        public void Overflow()
        {
            unchecked // ignore this, it simple means im telling the compiler i know what I am doing.
            {
                Assert.IsTrue(int.MaxValue + 1 == /*Answer here*/); // Make this pass (you can use a literal number or a symbol)
                Assert.IsTrue(int.MinValue - 1 == /*Answer here*/); // Make this pass (you can use a literal number or a symbol)
                Assert.IsTrue(float.MaxValue + 1 == /*Answer here*/); // Make this pass (you can use a literal number or a symbol)
                Assert.IsTrue(float.MinValue - 1 == /*Answer here*/); // Make this pass (you can use a literal number or a symbol)
                Assert.IsTrue(double.MaxValue + 1 == /*Answer here*/); // Make this pass (you can use a literal number or a symbol)
                Assert.IsTrue(double.MinValue - 1 == /*Answer here*/); // Make this pass (you can use a literal number or a symbol)
            }
        }

        [TestMethod]
        public void Conversion()
        {
            int i = 13;
            double d = i;
            Assert.IsTrue(d == /*Answer here*/); // Make this pass by ONLY filling in the answer

            // Why does that compile andwork but this doesnt? (Add a comment with your answer)
            // double d = 15.5;
            // int c = d;
        }

        [TestMethod]
        public void Casting()
        {
            // what am i doing here that make the above work? (Add a comment with your answer)
            double d = 15.5;
            int c = (int)d;
            Assert.IsTrue(c == /*Answer here*/); // Make this pass by ONLY filling in the answer

            string e = d.ToString();
            Assert.IsTrue(e == /*Answer here*/); // Make this pass by ONLY filling in the answer
        }

        [TestMethod]
        public void Parsing()
        {
            string a = "67";
            int b = int.Parse(a);
            Assert.IsTrue(b == /*Answer here*/); // Make this pass by ONLY filling in the answer
        }
    }
}
