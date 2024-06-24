using System.ComponentModel.DataAnnotations;



public class Pelicula
{
    [Key]
    public int PeliculaId { get; set; }

    [Required]
    [StringLength(100)]
    public string Titulo { get; set; }

    [Required]
    public string Director { get; set; }

    [DataType(DataType.Date)]
    public DateTime FechaDeLanzamiento { get; set; }

    [Range(1, 500)]
    public int Duracion { get; set; } // Duración en minutos

    [Required]
    [StringLength(500)]
    public string Sinopsis { get; set; }

    [Required]
    public string Portada { get; set; }

    [Required]
    public string Trailer { get; set; }

    [Required]
    public int GeneroId { get; set; }

    [Required]
    public int ClasificacionId { get; set; }

    public bool Activo { get; set; } = false; // Nuevo campo para indicar si la película está activa o inactiva

}

public class Genero
{
    [Key]
    public int GeneroId { get; set; }
    [Required]
    public string Nombre { get; set; }
    public ICollection<Pelicula> Peliculas { get; set; }
}

public class Clasificacion
{
    [Key]
    public int ClasificacionId { get; set; }
    [Required]
    public string Nombre { get; set; }
    public ICollection<Pelicula> Peliculas { get; set; }
}

public class Funcion
{
    [Key]
    public int FuncionId { get; set; }

    [Required]
    public DateTime Fecha { get; set; }

    [Required]
    [StringLength(100)]
    public string Sala { get; set; }

    [Required]
    [StringLength(50)]
    public string Idioma { get; set; }

    [Required]
    public int PeliculaId { get; set; }

    public virtual Pelicula Pelicula { get; set; }  // Propiedad de navegación

    [Required]
    [DataType(DataType.Time)]
    public TimeSpan Hora { get; set; }
}

