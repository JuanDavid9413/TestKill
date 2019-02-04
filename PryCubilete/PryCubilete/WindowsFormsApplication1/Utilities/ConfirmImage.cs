using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ConfirmImage
    {
        public string SelectImagen(int vRandom)
        {
            string RutaImagen = null;
            switch (vRandom)
            {
                case 1:
                    RutaImagen = @"D:\GitHub\TestKill\PryCubilete\PryCubilete\imgs\as.jpg";
                    break;
                case 2:
                    RutaImagen = @"D:\GitHub\TestKill\PryCubilete\PryCubilete\imgs\J.jpg";
                    break;
                case 3:
                    RutaImagen = @"D:\GitHub\TestKill\PryCubilete\PryCubilete\imgs\K.jpg";
                    break;
                case 4:
                    RutaImagen = @"D:\GitHub\TestKill\PryCubilete\PryCubilete\imgs\ocho.jpg";
                    break;
                case 5:
                    RutaImagen = @"D:\GitHub\TestKill\PryCubilete\PryCubilete\imgs\Q.jpg";
                    break;
                case 6:
                    RutaImagen = @"D:\GitHub\TestKill\PryCubilete\PryCubilete\imgs\siete.jpg";
                    break;
            }
            return RutaImagen;
        }
    }
}
