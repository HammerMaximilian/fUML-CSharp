namespace uml.commonstructure
{
    public class Comment
    {
        public List<Element> annotatedElement = new();
        public string body = "";

        public void SetAnnotatedElement(
                Element annotatedElement)
        {
            if (annotatedElement is null)
            {
                throw new ArgumentNullException(nameof(annotatedElement));
            }

            this.annotatedElement.Add(annotatedElement);
        } // setAnnotatedElement

        public void SetBody(string body)
        {
            this.body = body;
        } // setBody

    } // Comment
}
