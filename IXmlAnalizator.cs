using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Xml_Lab
{
    public interface IXmlAnalyzatorStrategy
    {
        List<Member> Find(Member member);
    }
}
