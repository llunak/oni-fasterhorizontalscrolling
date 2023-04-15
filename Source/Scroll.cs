using HarmonyLib;

namespace FasterHorizontalScrolling
{
    [HarmonyPatch(typeof(KScrollRect))]
    public class KScreenRect_Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch(MethodType.Constructor)]
        public static void ctor(ref float ___horizontalScrollInertiaScale)
        {
            ___horizontalScrollInertiaScale *= 4;
        }
    }
}
