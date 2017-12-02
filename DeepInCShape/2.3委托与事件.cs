using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepInCShape
{
    public class 委托与事件
    {
        delegate void Delegate();

        event Delegate EventHandler  //事件其实就是类似属性，封装委托进行过滤
        {
            add { EventHandler += value; }  //可以在add、remove中过滤事件
            remove { EventHandler -= value; }
        }




    }
}
