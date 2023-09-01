using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial.shared.Entities
{
    public class proyecto
    {
     
     public int Id { get; set; }

        
     public string NombreProyecto { get; set; } = null;
     public string FechaInicio { get; set; } = null;
     public string FechaFin { get; set; } = null;
     public string liderProyecto { get; set; } = null;
     public string Descripcion { get; set; } = null;
     public string AreaInvestigacion { get; set; } = null;

    }
}
