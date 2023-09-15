using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
using Capa_entidad;

namespace Capa_Negocio
{
    public class ClassNegocio
    {
        ClassDatos objd = new ClassDatos();

        public DataTable N_listar_estudiantes()
        {
            return objd.D_listar_estudiantes();
        }

        public DataTable N_buscar_estudiantes(ClassEntidad obje)
        {
            return objd.D_buscar_estudiantes(obje);
        }

        public String N_mantenmiento_estudiantes(ClassEntidad obje)
        {
            return objd.D_mantenmiento_estudiantes(obje);
        }
    }
}
