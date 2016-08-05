using Repository.Context;

namespace BusinessLayer.ContextService
{
    public static class ContextService
    {
        public static void EnsureDbCreation()
        {
            ContextEnsure.EnsureDb();
        }
    }
}
