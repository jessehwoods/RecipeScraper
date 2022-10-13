using RecipeScraper;
using System.Net;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("WoksOfLIfeRecipeGetterTest")]

namespace RecipeScraper
{
    /// <summary>
    /// This class will  be used to access a recipe on <see href = "https://thewoksoflife.com/">The Woks Of Life</see> by the url and return just the recipe as html.
    /// </summary>
    /// <remarks>
    /// Because different websites have different html standards, this will be specific to <see href = "https://thewoksoflife.com/">The Woks Of Life</see>. Other websites will require their own classes.
    /// </remarks>
    public class WoksOfLIfeRecipeGetter
    {
        /// <summary>
        /// The beginning of the url for any acceptable URLSs to be accessed.
        /// </summary>
        private readonly string targetSite = "https://thewoksoflife.com/";

        /// <summary>
        /// Takes in a url, stips extraneous data, formats it, and gives it back as an html string.
        /// </summary>
        /// <param name="url"></param>
        /// The URL of the recipe to be returned. Must be from the site <see href = "https://thewoksoflife.com/">The Woks Of Life</see>.
        /// <returns>A JSON representation of the recipe.</returns>
        public string GetRecipe(string url)
        {
            // Make sure the url is going to the right website
            if (!url.StartsWith(targetSite))
            {
                throw new ArgumentException("URL must be for pages of" + targetSite);
            }
            // Try to get the html from the website
            var client = new HttpClient();
            var html = client.GetStringAsync(url).Result;
            // Make sure we got a valid recipe html
            if (!IsRecipe(html))
            {
                throw new ArgumentException("This URL is not a recipe.");
            }
            // Reformat the recipe into a JSON string
            var jsonRecipe = FormatRecipe(html);
            // Return the reformatted recipe
            return jsonRecipe;
        }

        /// <summary>
        /// Determines if the input string is a recipe formatted in the style of the target site.
        /// </summary>
        /// <param name="html">A string of formatted html to be examined.</param>
        /// <returns>True if the provided string is not empty, and is formatted in the style of the target site.</returns>
        internal bool IsRecipe(string html)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reformats a string representing a recipe formatted in the style of target site and turns it into a JSON string.
        /// </summary>
        /// <param name="recipeText"></param>
        /// <returns>A JSON string representing the recipe.</returns>
        internal string FormatRecipe(string recipeText)
        {
            throw new NotImplementedException();
        }
    }
}