using homework3_4.Interfaces;
using System;

namespace homework3_4.Classes
{
    abstract class ArrayBase:IBaseArray
    {
        public abstract void RandomFill();
        
        public abstract void UserFill();
        
        public virtual void ReCreateArray(bool random = false)
        {
            if (!random)
            { 
                RandomFill();
            }
            else
            {
                UserFill();
            }
        }
    }
}