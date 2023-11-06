namespace fuml.syntax.commonbehavior
{
    public class OpaqueBehavior : Behavior
    {
        public List<string> body = new();
        public List<string> language = new();

        public void AddBody(string body)
        {
            this.body.Add(body);
        } // addBody

        public void AddLanguage(string language)
        {
            this.language.Add(language);
        } // addLanguage
    } // OpaqueBehavior
}
