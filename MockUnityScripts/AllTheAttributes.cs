using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Tooltip : System.Attribute
    {
        public Tooltip(string blah)
        {
            //doing nothing
        }
    }

    public class FormerlySerializedAs : System.Attribute
    {
        public FormerlySerializedAs(string blah)
        {
            //doing nothing
        }
    }

    public class PreferBinarySerialization : System.Attribute
    {
        public PreferBinarySerialization()
        {
            //doing nothing
        }
    }

    public class UMAAssetFieldVisible : System.Attribute
    {
        public UMAAssetFieldVisible()
        {
            //doing nothing
        }
    }

    public class SerializeField : System.Attribute
    {
        public SerializeField()
        {
            //doing nothing
        }
    }

    public class HideInInspector : System.Attribute
    {
        public HideInInspector()
        {
            //doing nothing
        }
    }
}
