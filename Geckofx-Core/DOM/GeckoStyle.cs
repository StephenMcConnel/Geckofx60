#region ***** BEGIN LICENSE BLOCK *****

/* Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Skybound Software code.
 *
 * The Initial Developer of the Original Code is Skybound Software.
 * Portions created by the Initial Developer are Copyright (C) 2008-2009
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 */

#endregion END LICENSE BLOCK

using System;
using Gecko.WebIDL;

namespace Gecko
{
    /// <summary>
    /// Wrapper around /* /* nsIDOMCSSStyleDeclaration s */nsISupports
    /// Allows viewing and modifying inline CSS styles.
    /// TODO: could add the following functionality if needed:
    /// GetParentRule, RemoveProperty, GetPropertyPriority
    /// </summary>
    public class GeckoStyle
    {
        private readonly mozIDOMWindowProxy _window;
        private readonly /* /* nsIDOMCSSStyleDeclaration s */nsISupports _styleDelcaration;
        Lazy<CSSStyleDeclaration> _style;

        internal GeckoStyle(mozIDOMWindowProxy window, /* nsIDOMCSSStyleDeclaration s */nsISupports styleDeclaration)
        {
            _window = window;
            _styleDelcaration = styleDeclaration;
            _style = new Lazy<CSSStyleDeclaration>(() => new CSSStyleDeclaration((mozIDOMWindowProxy)_window, _styleDelcaration));            
        }

        internal static GeckoStyle Create(mozIDOMWindowProxy window, /* nsIDOMCSSStyleDeclaration s */nsISupports styleDeclaration)
        {
            return (styleDeclaration == null) ? null : new GeckoStyle(window, styleDeclaration);
        }

        /// <summary>
        /// Get and sets the CssText.
        /// For example: "background-color: green; color: red;"
        /// </summary>
        public string CssText
        {
            get { return _style.Value.CssText; }
            set { _style.Value.CssText = value; }
        }

        /// <summary>
        /// Get the number of CSS properties. 
        /// </summary>
        public uint Length => _style.Value.Length;

        /// <summary>
        /// Get property name by index
        /// </summary>		
        public string this[uint index] => _style.Value.Item(index);

        /// <summary>
        /// Get the value of a specfic Css Property.
        /// </summary>		
        public string GetPropertyValue(string propertyName)
        {
           return _style.Value.GetPropertyValue(propertyName);
        }

        /// <summary>
        /// Set the value of a specfic Css Property.
        /// </summary>		
        public void SetPropertyValue(string propertyName, string value)
        {
            _style.Value.SetProperty(propertyName, value);
        }

        /// <summary>
        /// Set the value of a specfic Css Property.
        /// </summary>          
        public void SetPropertyValue(string propertyName, string value, string priority)
        {
            _style.Value.SetProperty(propertyName, value, priority);
        }
    }
}
