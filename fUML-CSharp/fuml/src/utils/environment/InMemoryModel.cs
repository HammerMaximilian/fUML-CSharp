using System.Collections;

namespace fuml.environment
{
    public abstract class InMemoryModel
    {
        private readonly Hashtable elementRepository = new();

        protected void AddToElementRepository(string name, FumlObject object_)
        {
            elementRepository[name] = object_;
        }

        public FumlObject FindElementByName(string name)
        {
            FumlObject element = (FumlObject)elementRepository[name]!;
            return element;
        }
    } // InMemoryModel
}
