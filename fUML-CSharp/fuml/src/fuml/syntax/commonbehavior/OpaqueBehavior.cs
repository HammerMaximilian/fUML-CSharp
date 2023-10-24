namespace fuml.syntax.commonbehavior
{
    public class OpaqueBehavior : Behavior
    {
        public List<string> body = new();
        public List<string> language = new();

        public void addBody(string body)
        {
            this.body.Add(body);
        } // addBody

        public void addLanguage(string language)
        {
            this.language.Add(language);
        } // addLanguage
    } // OpaqueBehavior
}
