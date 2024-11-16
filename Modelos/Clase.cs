using System.ComponentModel.DataAnnotations;

public class Detencion {

    [Key]
    public int IdDetencion {get; set;}
    public string Nombre {get; set;} = "";
    public string Apellido {get; set;} = "";
    public string Pasaporte {get; set;} = "";
    public DateTime FechaNacimiento {get; set;}
    public DateTime FechaDetencion {get; set;} = DateTime.Now;
    public double Longitud {get; set;}
    public double Latitud {get; set;}

    public string Coordenadas(){
        return $"{Latitud}, {Longitud}";
    }
}