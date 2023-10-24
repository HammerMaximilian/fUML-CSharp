namespace fuml.syntax.commonstructure
{
    public class Comment : fuml.FumlObject
    {
        public List<Element> annotatedElement = new();
        public string body = "";

        public void setAnnotatedElement(
                Element annotatedElement)
        {
            if (annotatedElement is null)
            {
                throw new ArgumentNullException(nameof(annotatedElement));
            }

            this.annotatedElement.Add(annotatedElement);
        } // setAnnotatedElement

        public void setBody(string body)
        {
            this.body = body;
        } // setBody

    } // Comment
}
