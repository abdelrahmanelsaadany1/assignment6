using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    #region NamespaceInfo

    // what can we write inside name space? 1-class 2-struct 3-enum 4-interface
    //access modifiers inside namespace? 1-internal(default) 2-public
    #endregion
    public class TypeA
    {
       private int x ;
       internal int y ;
       public int z ;
        #region definitions
        // what you can write inside class or struct ? 
        //1-attribute(field or  variable)
        //2-property(full - automatic-indexer)
        //3-function(constructor-getter/setter-method)
        //4-event
        //allowed access modifier inside struct (1-private 2-internal 3-public)
        //allowed access modifier inside class (1-private 2-private protected 3-protected 4-internal 5-internal protected 6-public)
        // what you can write inside interface ?
        //1-signature for property 
        //2-signature for method
        //3-default implemented method
        //default access modifier inside interface is public
        #endregion
    }
}
