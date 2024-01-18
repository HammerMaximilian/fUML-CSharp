using uml.commonbehavior;

namespace uml.values
{
    public class OpaqueExpression : ValueSpecification // PSCS-specific
    {
        public List<string> body = new();
        public List<string> language = new();
        public Behavior? behavior = null;

        public void AddBody(string body)
        {
            this.body.Add(body);
        }

        public void AddLanguage(string language)
        {
            this.language.Add(language);
        }

        public void SetBehavior(Behavior behavior)
        {
            this.behavior = behavior ?? throw new ArgumentNullException(nameof(behavior));
        }
    } // OpaqueExpression
}
