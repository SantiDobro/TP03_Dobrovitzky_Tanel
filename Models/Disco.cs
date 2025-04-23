class Disco 
{
    string nombre; List<Artista> artista; Productor productor; string genero; List<Tema> temas; string foto;
     public Disco(string nombre, List<Artista> artista, Productor productor, List<Tema> temas, string genero, string foto)
     {
        this.nombre = nombre;
        this.artista = artista;
        this.productor = productor;
        this.temas = temas;
        this.genero = genero;
        this.foto = foto;
     }
}