using System;
using System.Collections.Generic;
using UserAuthClient.Web.Elements;

namespace UserAuthClient.Web.Lib
{
    public class SourceContext
    {
        public static ElementRegistry ElementRegistry { get; set; }
        
        public SourceContext(ElementRegistry elementRegistry)
        {
            ElementRegistry??= elementRegistry;
        }

        public Dictionary<string, object> Components { get; set; } = new Dictionary<string, object>();
        
        protected T GetExposedComponent<T>(string uuid, string tag, out T invar)
        {
            if (!Components.ContainsKey(uuid))
            {
                SourceElement elem=(SourceElement) ElementRegistry.ElementMap[uuid];
                SourceElement.GetComponent<SourceElement,SourceElement>(elem, elem.Properties[tag].ToString(), out var ret);
                return invar=(T)(Components[uuid] = ret);
            }
            return invar=(T)(Components[uuid]);
        }
        
        public SourceContext(string tag, string tagValue)
        {
        }
        
    }
}