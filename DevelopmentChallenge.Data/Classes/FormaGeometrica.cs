/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * OPCIONAL: Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Classes.Extensions;
using DevelopmentChallenge.Data.Classes.Lenguajes;
using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        public static string Imprimir(List<GeometicShape> formas, int idioma)
        {
            var sb = new StringBuilder();
            var lenguage = LenguageBuilder.getLenguage(idioma);

            if (!formas.Any())            
                sb.Append(lenguage.EmptyHaderLabel);
            else
            {   
                sb.Append(lenguage.HeaderLabel);

                var data = formas.getAllData();
                
                sb.Append(lenguage.GetLine(data.Where(x => x.shapeEnum == ShapeEnum.Square).FirstOrDefault()));
                sb.Append(lenguage.GetLine(data.Where(x => x.shapeEnum == ShapeEnum.Circle).FirstOrDefault()));
                sb.Append(lenguage.GetLine(data.Where(x => x.shapeEnum == ShapeEnum.EquilateralTriangle).FirstOrDefault()));
                sb.Append(lenguage.GetLine(data.Where(x => x.shapeEnum == ShapeEnum.Trapeze).FirstOrDefault()));

                // FOOTER
                sb.Append(lenguage.TotalHeaderLabel);
                sb.Append(formas.Count() + " " + (lenguage.ShapeLabel) + " ");
                sb.Append(lenguage.PerimeterLabel   +   data.Sum(x => x.TotalPerimeter).ToString("#.##") + " ");
                sb.Append(lenguage.AreaLabel        +   data.Sum(x => x.TotalArea).ToString("#.##"));
            }

            return sb.ToString();
        }

        
    }
}
