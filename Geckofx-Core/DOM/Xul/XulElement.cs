using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.DOM.Xul
{
    public class XulElement
        : GeckoElement
    {
        protected XulElement(mozIDOMWindowProxy window, nsIDOMXULElement xulElement)
            : base(window, xulElement)
        {
        }


        public static XulElement CreateXulElementWrapper(mozIDOMWindowProxy window, nsIDOMXULElement xulElement)
        {
            return xulElement == null ? null : new XulElement(window, xulElement);
        }

        /// <summary>
        /// Gets the inline style of the XulElement. 
        /// </summary>
        public GeckoStyle Style
        {
            get
            {
                //return
                //    GeckoStyle.Create(Xpcom.QueryInterface<nsIDOMElementCSSInlineStyle>(DomObject).GetStyleAttribute());
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets style of the XulElement. 
        /// </summary>
        public GeckoStyle ComputedStyle
        {
            get
            {
                /* nsIDOMCSSStyleDeclaration */ nsISupports style;
                using (var element = new ComPtr<nsIDOMElement>(Xpcom.QueryInterface<nsIDOMElement>(this.DomObject)))
                {
                    var window = new WebIDL.Window(OwnerDocument.DefaultView.DomWindow,
                        (nsISupports) OwnerDocument.DefaultView.DomWindow);
                    style = window.GetComputedStyle(element.Instance);
                }
                return GeckoStyle.Create(Window, style);
            }
        }
    }
}