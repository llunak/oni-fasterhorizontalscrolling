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
            if( ___horizontalScrollInertiaScale < 20 )
                ___horizontalScrollInertiaScale = 20;
        }
    }
}
