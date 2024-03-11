namespace homework3_4.Classes
{
    using homework3_4.Interfaces;
    abstract class ArrayBase:IBaseArray
    {
        public abstract void CreateArray();
        
        public abstract void UserChoise();
        
        public virtual void ReCreateArray(bool random = false)
        {
            if (!random)
            { 
                CreateArray();
            }
            else
            {
                UserChoise();
            }
        }
    }
}