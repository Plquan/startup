namespace startup.Ultilities
{
    public class Functions
    {
        public static string TitleSlugGeneration(string type,string Title,long id)
        {
            string sTitle = type + "_" + SlugGenerator.SlugGenerator.GenerateSlug(Title) + "_" + id.ToString() + ".html";
            return sTitle;
        }

    }
}
