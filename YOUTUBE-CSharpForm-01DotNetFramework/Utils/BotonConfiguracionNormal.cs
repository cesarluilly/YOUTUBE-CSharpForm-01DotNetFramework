using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YOUTUBE_CSharpForm_01DotNetFramework.Utils
{
    //                                                      //No aplica para cambiar las dimensiones ni el color.
    //                                                      //Aplica para poner alguna fuente.
    //                                                      //Apenas estoy en la etapa experimental.
    public class BotonConfiguration
    {

        public static void subConfigurationNormal(
            Button btnButton_I
            )
        {
            btnButton_I.Size = new System.Drawing.Size(500, 400);
        }
    }
}
