namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLBRElement : WebIDLBase
    {
        
        public HTMLBRElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Clear
        {
            get
            {
                return this.GetProperty<string>("clear");
            }
            set
            {
                this.SetProperty("clear", value);
            }
        }
    }
}
