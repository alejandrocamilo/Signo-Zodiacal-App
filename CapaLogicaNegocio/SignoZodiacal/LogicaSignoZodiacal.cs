using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.SignoZodiacal
{
    public class LogicaSignoZodiacal
    {
        public string determinarSigno(DatosSignoZodiacal dsz)
        {
            if(dsz.month == "Enero" )
            {
                if(dsz.day >= 21)
                {
                    return "Acuario";
                }
                else
                    if(dsz.day <= 20)
                {
                    return "Capricornio";
                }
            }
            else
                if(dsz.month == "Febrero")
            {
                if(dsz.day <= 19)
                {
                    return "Acuario";
                }
                else
                    if (dsz.day >= 20)
                {
                    return "Piscis";
                }
            }
            else
                if(dsz.month == "Marzo")
            {
                if(dsz.day <= 20)
                {
                    return "Piscis";
                }
                else
                   if (dsz.day >= 21)
                {
                    return "Aries";
                }

            }
            else
                if (dsz.month == "Abril")
            {
                if (dsz.day <= 19)
                {
                    return "Aries";
                }
                else
                   if (dsz.day >= 20)
                {
                    return "Tauro";
                }
            }
            else
                if (dsz.month == "Mayo")
            {
                if (dsz.day <= 20)
                {
                    return "Tauro";
                }
                else
                   if (dsz.day >= 21)
                {
                    return "Geminis";
                }
            }
            else
                if (dsz.month == "Junio")
            {
                if (dsz.day <= 20)
                {
                    return "Geminis";
                }
                else
                   if (dsz.day >= 21)
                {
                    return "Cancer";
                }
            }
            else
                if (dsz.month == "Julio")
            {
                if (dsz.day <= 22)
                {
                    return "Cancer";
                }
                else
                   if (dsz.day >= 23)
                {
                    return "Leo";
                }
            }
            else
                if (dsz.month == "Agosto")
            {
                if (dsz.day <= 22)
                {
                    return "Leo";
                }
                else
                   if (dsz.day >= 23)
                {
                    return "Virgo";
                }
            }
            else
                if (dsz.month == "Septiembre")
            {
                if (dsz.day <= 22)
                {
                    return "Virgo";
                }
                else
                   if (dsz.day >= 23)
                {
                    return "Libra";
                }
            }
            else
                if (dsz.month == "Octubre")
            {
                if (dsz.day <= 22)
                {
                    return "Libra";
                }
                else
                  if (dsz.day >= 23)
                {
                    return "Escorpio";
                }
            }
            else
                if (dsz.month == "Noviembre")
            {

                if (dsz.day <= 21)
                {
                    return "Escorpio";
                }
                else
                   if (dsz.day >= 22)
                {
                    return "Sagitario";
                }
            }
            else
                if (dsz.month == "Diciembre")
            {
                if (dsz.day <= 21)
                {
                    return "Sagitario";
                }
                else
                  if (dsz.day >= 22)
                {
                    return "Capricornio";
                }
            }

             return "No corresponde a ningun signo zodiacal";
        }
    }
}
