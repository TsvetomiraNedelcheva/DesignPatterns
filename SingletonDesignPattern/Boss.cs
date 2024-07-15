namespace SingletonDesignPattern
{
    public class Boss
    {
        private static Boss instance = null;

        private Boss() { }

        public string Name { get; set; }

        public static Boss GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Boss();
                }
                return instance;
            }
        }
    }
}
