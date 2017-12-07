using SimpleInjector;

namespace loC
{
    public class Bootstrap
    {
        private static Container container;
        public static void Start()
        {
            container = new Container();

            container.Verify();
        }

        public static Container GetContainer()
        {
            return container;
        }
    }
}
