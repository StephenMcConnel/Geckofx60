namespace Gecko.WebIDL
{
    using System;
    
    
    public class External : WebIDLBase
    {
        
        public External(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void AddSearchProvider(string aDescriptionURL)
        {
            this.CallVoidMethod("AddSearchProvider", aDescriptionURL);
        }
        
        public uint IsSearchProviderInstalled(string aSearchURL)
        {
            return this.CallMethod<uint>("IsSearchProviderInstalled", aSearchURL);
        }
    }
}
