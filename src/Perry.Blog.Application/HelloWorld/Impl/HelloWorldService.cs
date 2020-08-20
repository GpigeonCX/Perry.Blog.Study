using System;
using System.Collections.Generic;
using System.Text;

namespace Perry.Blog.Application
{
    public class HelloWorldService : PerryBlogApplicationServiceBase, IHelloWorldService
    {
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
