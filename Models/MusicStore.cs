class MusicStore
{
    Dictionary<int, Disco> discos = InicializarDiscos();

    /*public Disco(string nombre, List<Artista> artista, Productor productor, string genero, List<Tema> temas, string foto)
     {
        this.nombre = nombre;
        this.artista = artista;
        this.productor = productor;
        this.genero = genero;
        this.temas = temas;
        this.foto = foto;
     }*/
    private static Dictionary<int, Disco> InicializarDiscos()
    {
        Dictionary<int, Disco> discos = new Dictionary<int, Disco>();
        string nombre = "DeBÍ TiRAR MáS FOToS";
        List<Artista> artistas = new List<Artista>(); artistas.Add(new("Bad Bunny"));
        Productor productor = new Productor("Rimas Entertainment");
        List<Tema> temas = new List<Tema>();
        agregarTemas(temas, "NUEVAYoL");
        agregarTemas(temas, "VOY A LLeVARTE PA PR");
        agregarTemas(temas, "BAILE INoLVIDABLE");
        agregarTemas(temas, "PERFuMITO NUEVO");
        agregarTemas(temas, "WELTiTA");
        agregarTemas(temas, "VeLDÁ");
        agregarTemas(temas, "EL CLuB");
        agregarTemas(temas, "KETU TeCRÉ");
        agregarTemas(temas, "BOKeTE");
        agregarTemas(temas, "KLOuFRENS");
        agregarTemas(temas, "TURiSTA");
        agregarTemas(temas, "CAFé CON RON");
        agregarTemas(temas, "PIT0RRO DE COCO");
        agregarTemas(temas, "LO QUE LE PASÓ A HAWAii");
        agregarTemas(temas, "EoO");
        agregarTemas(temas, "DtMF");
        agregarTemas(temas, "LA MuDANZA");
        string genero = "Reguetón, Plena";
        string foto = "DtMF.jpg";
        Disco disco = new Disco(nombre, artistas, productor, temas, genero, foto);
        discos.Add(0, disco);
        // Disco 2
discos.Add(1, new Disco(
    "Noches en Condado",
    new List<Artista> { new("Rauw Alejandro") },
    new Productor("Sony Music Latin"),
    new List<Tema> {
        new("Intro"), new("Puesta Pa' Mí"), new("Luz de Noche"), new("Cielo Abierto"),
        new("Bellaqueo Eterno"), new("Código 787"), new("Frikitona 3000"), new("Más Flow"),
        new("Noche Lluviosa"), new("La Última Vez")
    },
    "Electro Urbano, R&B", "rauw.jpg"
));

// Disco 3
discos.Add(2, new Disco(
    "Tropikal 3000",
    new List<Artista> { new("Feid") },
    new Productor("Universal Music"),
    new List<Tema> {
        new("VACilón"), new("Tu Calor"), new("Luz Verde"), new("1000 Likes"),
        new("Estás Aquí"), new("Parche de Oro"), new("Mambo Slow"), new("Fiesta sin Fin")
    },
    "Reguetón, Dancehall", "feid_tropikal.jpg"
));

// Disco 4
discos.Add(3, new Disco(
    "Perreo Profundo",
    new List<Artista> { new("Jowell & Randy") },
    new Productor("White Lion Records"),
    new List<Tema> {
        new("Intro Salvaje"), new("Perreo Del Futuro"), new("Gata Turbo"), new("Nadie Sabe"),
        new("Bajo Tierra"), new("Tóxica Remix"), new("Flow Antiguo"), new("Outro")
    },
    "Perreo, Reguetón", "perreo_profundo.jpg"
));

// Disco 5
discos.Add(4, new Disco(
    "Latidos de la Calle",
    new List<Artista> { new("Residente") },
    new Productor("El Abismo"),
    new List<Tema> {
        new("Intro - Palabras"), new("Bajo Presión"), new("Callejero"), new("La Voz"),
        new("Crónicas de Barrio"), new("Mentiras del Sistema"), new("Despertar"), new("Outro")
    },
    "Hip-Hop, Protesta", "latidos.jpg"
));

// Disco 6
discos.Add(5, new Disco(
    "Estrella Fugaz",
    new List<Artista> { new("Young Miko") },
    new Productor("The Wave Records"),
    new List<Tema> {
        new("Space Trip"), new("Amor Lunar"), new("Brillar Contigo"), new("404 Emocional"),
        new("Nube9"), new("Eclipse Total"), new("Final de Verano")
    },
    "Trap Pop, Experimental", "estrella.jpg"
));

// Disco 7
discos.Add(6, new Disco(
    "Sueños de Arena",
    new List<Artista> { new("Tainy") },
    new Productor("NEON16"),
    new List<Tema> {
        new("Desierto de Noche"), new("Oasis Perdido"), new("Arena y Viento"), new("Eco del Mar"),
        new("Solitario"), new("Visiones"), new("Reflejo"), new("Náufrago")
    },
    "Ambient Trap, Electrónica", "arena.jpg"
));

// Disco 8
discos.Add(7, new Disco(
    "Bajo el Sol de PR",
    new List<Artista> { new("Myke Towers") },
    new Productor("Warner Music"),
    new List<Tema> {
        new("Calor Urbano"), new("Desde La Esquina"), new("Sol en la Frente"), new("Playa y Problemas"),
        new("Camino al Barrio"), new("Ritmo del Asfalto"), new("Humo y Recuerdos")
    },
    "Rap, Trap Latino", "bajoelsol.jpg"
));

    }

    public static void agregarTemas(List<Tema> temas, string nombre)
    {
        temas.Add(new(nombre));
    }
}