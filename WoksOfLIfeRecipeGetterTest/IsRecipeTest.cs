using RecipeScraper;

namespace WoksOfLIfeRecipeGetterTest
{
    [TestClass]
    public class IsRecipeTest
    {
        /// <summary>
        /// Tests with the file "valid1.html".
        /// </summary>
        /// <remarks>This is a a recipe titled "SPICY HUNAN STEAMED TOFU & MUSHROOMS"</remarks>
        [TestMethod]
        public void TestValid1()
        {
            var getter = new WoksOfLIfeRecipeGetter();
            var html = System.IO.File.ReadAllText("../../../../WoksOfLIfeRecipeGetterTest/test-files/valid1.html");
            Assert.IsTrue(getter.IsRecipe(html));
        }

        /// <summary>
        /// Tests with the file "valid2.html".
        /// </summary>
        /// <remarks>This is a a recipe titled "1-2-3-4-5 RIBS"</remarks>
        [TestMethod]
        public void TestValid2()
        {
            var getter = new WoksOfLIfeRecipeGetter();
            var html = System.IO.File.ReadAllText("../../../../WoksOfLIfeRecipeGetterTest/test-files/valid2.html");
            Assert.IsTrue(getter.IsRecipe(html));
        }

        /// <summary>
        /// Tests with the file "valid3.html".
        /// </summary>
        /// <remarks>This is a a recipe titled "CHINESE SPAGHETTI BOLOGNESE"</remarks>
        [TestMethod]
        public void TestValid3()
        {
            var getter = new WoksOfLIfeRecipeGetter();
            var html = System.IO.File.ReadAllText("../../../../WoksOfLIfeRecipeGetterTest/test-files/valid3.html");
            Assert.IsTrue(getter.IsRecipe(html));
        }

        /// <summary>
        /// Tests with the file "valid4.html".
        /// </summary>
        /// <remarks>This is a a recipe titled "KUNG PAO BEEF"</remarks>
        [TestMethod]
        public void TestValid4()
        {
            var getter = new WoksOfLIfeRecipeGetter();
            var html = System.IO.File.ReadAllText("../../../../WoksOfLIfeRecipeGetterTest/test-files/valid4.html");
            Assert.IsTrue(getter.IsRecipe(html));
        }

        /// <summary>
        /// Tests with the file "invalid1.html".
        /// </summary>
        /// <remarks>This is a the main page of The Woks of Life, so not a recipe</remarks>
        [TestMethod]
        public void TestInvalid1()
        {
            var getter = new WoksOfLIfeRecipeGetter();
            var html = System.IO.File.ReadAllText("../../../../WoksOfLIfeRecipeGetterTest/test-files//invalid1.html");
            Assert.IsFalse(getter.IsRecipe(html));
        }

        /// <summary>
        /// Tests with the file "invalid2.html".
        /// </summary>
        /// <remarks>This is a blog post about raising chickens, so not a recipe</remarks>
        [TestMethod]
        public void TestInvalid2()
        {
            var getter = new WoksOfLIfeRecipeGetter();
            var html = System.IO.File.ReadAllText("../../../../WoksOfLIfeRecipeGetterTest/test-files//invalid2.html");
            Assert.IsFalse(getter.IsRecipe(html));
        }

        /// <summary>
        /// Tests with the file "invalid3.html".
        /// </summary>
        /// <remarks>This is a contents page with several recipes, so not a recipe</remarks>
        [TestMethod]
        public void TestInvalid3()
        {
            var getter = new WoksOfLIfeRecipeGetter();
            var html = System.IO.File.ReadAllText("../../../../WoksOfLIfeRecipeGetterTest/test-files//invalid3.html");
            Assert.IsFalse(getter.IsRecipe(html));
        }
    }
}