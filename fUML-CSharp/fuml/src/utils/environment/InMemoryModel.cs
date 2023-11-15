using System.Collections;

namespace fuml.environment
{
    public abstract class InMemoryModel
    {
        private readonly Hashtable elementRepository = new();

        protected void AddToElementRepository(string name, object object_)
        {
            elementRepository[name] = object_;
        }

        public object FindElementByName(string name)
        {
            object element = elementRepository[name]!;
            return element;
        }
    } // InMemoryModel
}
