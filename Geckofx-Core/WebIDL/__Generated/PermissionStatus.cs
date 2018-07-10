namespace Gecko.WebIDL
{
    using System;
    
    
    public class PermissionStatus : WebIDLBase
    {
        
        public PermissionStatus(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public PermissionState State
        {
            get
            {
                return this.GetProperty<PermissionState>("state");
            }
        }
    }
}
