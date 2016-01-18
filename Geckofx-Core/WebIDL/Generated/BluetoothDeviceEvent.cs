namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothDeviceEvent : WebIDLBase
    {
        
        public BluetoothDeviceEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Device
        {
            get
            {
                return this.GetProperty<nsISupports>("device");
            }
        }
        
        public nsAString Address
        {
            get
            {
                return this.GetProperty<nsAString>("address");
            }
        }
    }
}
