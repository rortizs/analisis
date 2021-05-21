using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace analisis.Entidades.Almacen
{
   public class Categoria
    {
        public int idcategoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength =3, ErrorMessage ="El nombre debe tener al menos 3 caracteres o un maximo de 50")]
        public string nombre { get; set; }

        [StringLength(256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }
    }
}
