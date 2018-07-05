namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTimeElement : WebIDLBase
    {
        
        public HTMLTimeElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string DateTime
        {
            get
            {
                return this.GetProperty<string>("dateTime");
            }
            set
            {
                this.SetProperty("dateTime", value);
            }
        }
    }
}
