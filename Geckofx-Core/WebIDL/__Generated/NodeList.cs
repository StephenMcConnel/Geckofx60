namespace Gecko.WebIDL
{
    using System;
    
    
    public class NodeList : WebIDLBase
    {
        
        public NodeList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
    }
}
