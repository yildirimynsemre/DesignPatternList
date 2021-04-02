using System;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton _instance;
        private static Guid _id;

        public Guid Id { get { return Singleton._id; } }

        private Singleton(Guid id) { id = _id; }


        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                var lockObject = new object();

                lock (lockObject)
                {
                    if (_instance == null)
                        _instance = new Singleton(Guid.NewGuid());
                }
            }
            return _instance;
        }
    }
}
