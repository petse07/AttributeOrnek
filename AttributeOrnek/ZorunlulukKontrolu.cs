using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AttributeOrnek
{
    public static class ZorunlulukKontrolu
    {
        public static  bool  Dogrula(object dogrulanacakOrnek)
        {
            Type dogrulanacakTur = dogrulanacakOrnek.GetType();
            FieldInfo[] dogrulanacakTurAlanlari = dogrulanacakTur.GetFields(BindingFlags.Public | BindingFlags.Instance);


            foreach(FieldInfo dogrulanacakTurAlani in dogrulanacakTurAlanlari)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakTurAlani.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);

                if (zorunluAlanOznitelikleri.Length != 0)
                {
                    string alanDegeri = dogrulanacakTurAlani.GetValue(dogrulanacakOrnek) as string;
                    if(string.IsNullOrEmpty(alanDegeri))
                    {
                        return false;
                    }
                }

            }

            return true;
        }
    }
}
