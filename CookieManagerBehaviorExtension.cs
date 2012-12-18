// Taken from http://archive.msdn.microsoft.com/wcfcookiemanager

using System;
using System.ServiceModel.Configuration;

namespace PanoptoAPITest
{
    public class CookieManagerBehaviorExtension : BehaviorExtensionElement
    {
        /// <summary>
        /// Gets the type of behavior.
        /// </summary>
        public override Type BehaviorType
        {
            get { return typeof(CookieManagerEndpointBehavior); }
        }

        /// <summary>
        /// Creates a behavior extension based on the current configuration settings.
        /// </summary>
        protected override object CreateBehavior()
        {
            return new CookieManagerEndpointBehavior();
        }
    }
}
