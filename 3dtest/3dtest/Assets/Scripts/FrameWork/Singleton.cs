namespace FrameWork
{
    public class Singleton<T> where T : class, new()
    {
        private T _instance;
        private object _lockObj = new object();
        public T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockObj)
                    {
                        if (_instance == null)
                        {
                            _instance = new T();
                        }
                    }
                }

                return _instance;
            }
        }

        public Singleton()
        {
            Init();
        }

        protected virtual void Init()
        {
            
        }
    }
}