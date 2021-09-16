using System;
using System.Collections.Generic;
using UserAuthClient.Web.Elements;

namespace UserAuthClient.Web.Lib
{
    public class ElementRegistry
    {
        public Dictionary<string, object> ElementMap { get; set; } = new();

        public Dictionary<string, List<string>> ChildMap { get; set; } = new();
        
        public void Register(IIdentity parent, IIdentity self)
        {
            //Console.WriteLine((self as SourceElement)?.Tag);
            if (parent is not null)
            {
                ChildMap.TryAdd(parent.UUID, new List<string>());
                
                ChildMap[parent.UUID].Add(self.UUID);
            }
            ElementMap.Add(self.UUID, self);
        }
    }
}