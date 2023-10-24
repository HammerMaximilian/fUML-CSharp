﻿namespace fuml.syntax.commonstructure
{
    public abstract class NamedElement : Element
    {
        public string name = "";
        public VisibilityKind? visibility = null;
        public string qualifiedName = "";
        public Namespace? namespace_ = null;

        public void setName(string name)
        {
            this.name = name;

            if (name != null)
            {
                if (namespace_ is null)
                {

                    qualifiedName = name;
                }
                else if (namespace_.qualifiedName is not null)
                {

                    qualifiedName = namespace_.qualifiedName + "::" + name;
                }
            }

        } // setName

        public void setVisibility(
               VisibilityKind visibility)
        {
            this.visibility = visibility;
        } // setVisibility

        public void _setNamespace(Namespace namespace_)
        {
            this.namespace_ = namespace_;

            if (name is not null)
            {
                if (this.namespace_ == null) 
                {

                    qualifiedName = name;
                } 
                else if (this.namespace_.qualifiedName != null) 
                {

                    qualifiedName = this.namespace_.qualifiedName + "::" + name;
			    }
            }
        } // _setNamespace
    }
}  // NamedElement