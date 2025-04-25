public class Disco
{

    public string Nombre { get; private set; }
    public List<Artista> Artista { get; private set; }
    public string Genero { get; private set; }
    public Productor Productor { get; private set; }
    public List<Tema> Temas { get; private set; }
    public string Foto { get; private set; }
    public Disco(string nombre, List<Artista> artista, Productor productor, List<Tema> temas, string genero, string foto)
    {
        Nombre = nombre;
        Artista = artista;
        Productor = productor;
        Temas = temas;
        Genero = genero;
        Foto = foto;
    }
}