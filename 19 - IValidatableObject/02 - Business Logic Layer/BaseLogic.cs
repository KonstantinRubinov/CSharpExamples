using System;

namespace JohnBryce
{
    public class BaseLogic : IDisposable
    {
        protected NorthwindEntities DB = new NorthwindEntities();

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
