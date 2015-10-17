namespace HtmlGenerator
{
    public class HtmlTabIndexAttribute : HtmlAttribute 
    {
        internal HtmlTabIndexAttribute() : base("tabIndex", "TabIndex", null, false, true) 
        {
        }

        internal HtmlTabIndexAttribute(string value) : base("tabIndex", "TabIndex", value, false, true) 
        {
        }
    }
}