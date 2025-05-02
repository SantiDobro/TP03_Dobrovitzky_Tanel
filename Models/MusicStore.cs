public class MusicStore
{
    public static List <Disco> Discos { get; set; } = InicializarDiscos();
    public static List<Disco> InicializarDiscos()
    {
        // Disco 1
        List<Disco> discos = new List<Disco>();
        discos.Add(new Disco(0, "DeBÍ TiRAR MáS FOToS",
        new Artista ("Bad Bunny"), new Productor("Rimas Entertainment"), new List<Tema>{
            new("NUEVAYoL"), new("VOY A LLeVARTE PA PR"), new("BAILE INoLVIDABLE"), new("PERFuMITO NUEVO"),
        new("WELTiTA"), new("VeLDÁ"), new("EL CLuB"), new("KETU TeCRÉ"),
        new("BOKeTE"), new("KLOuFRENS"), new("TURiSTA"), new("CAFé CON RON"), new("PIT0RRO DE COCO"), new("LO QUE LE PASÓ A HAWAii"),
        new("EoO"), new("DtMF"), new("LA MuDANZA")}, "Reguetón, Plena", "DtMF.jpg"));

        // Disco 2 - A partir de acá: ChatGPT
        discos.Add(new Disco(1, "Colores",
            new Artista ("J Balvin"), new Productor("Universal Music Latin"), new List<Tema>{
        new("Amarillo"), new("Morado"), new("Rojo"), new("Azul"),
        new("Verde"), new("Rosa"), new("Gris"), new("Azul Pastel"),
        new("Blanco"), new("Negro"), new("Rojo Fuego"), new("Girasol")}, "Reguetón, Trap", "Colores.jpg"));

        // Disco 3
        discos.Add(new Disco(2, "KG0516",
            new Artista ("Karol G"), new Productor("Interscope Records"), new List<Tema>{
        new("Bichota"), new("El Makinón"), new("La Tóxica"), new("Pineapple"),
        new("Mi Ex Tenía Razón"), new("Ay Dios Mío"), new("Sejodioto"), new("X"),
        new("Que Me Vas a Dar"), new("200 Copas"), new("Verdad"), new("El Barco")}, "Reguetón, Trap", "KG0516.jpg"));

        // Disco 4
        discos.Add(new Disco(3, "Afrodisíaco",
            new Artista("Rauw Alejandro"), new Productor("Sony Music Latin"), new List<Tema>{
        new("Dile a Él"), new("Fantasías"), new("Lo Siento"), new("Sexo Fácil"),
        new("Una Noche Más"), new("Nadie Como Tú"), new("Cuentos de la Calle"), new("Un Día de Enero"),
        new("Tattoo Remix"), new("Aventura"), new("Me Dejas Ser")}, "Reguetón, R&B", "Afrodisiaco.jpg"));

        // Disco 5
        discos.Add(new Disco(4,"Real hasta la Muerte",
            new Artista ("Anuel AA"), new Productor("Real G4 Life Music"), new List<Tema>{
        new("Intocable"), new("Bebe"), new("Nadie Sabe"), new("Amor Genuino"),
        new("Ven y Hazlo Tú"), new("La Ultima Vez"), new("Me Contagié"), new("Sigo Gozando"),
        new("Real hasta la Muerte"), new("Reloj"), new("Guerrero")}, "Trap, Reguetón", "RealHastaLaMuerte.jpg"));

        // Disco 6
        discos.Add(new Disco(5, "Fénix",
            new Artista ("Nicky Jam"), new Productor("Sony Music Latin"), new List<Tema>{
        new("Te Robaré"), new("El Amante"), new("No Me Acuerdo"), new("Fénix"),
        new("La Fiesta"), new("Me Pasé"), new("Hasta el Amanecer"), new("Tu Amor"),
        new("Solo Yo"), new("Muero Por Ti"), new("Otra Copa")}, "Reguetón, Balada", "Fenix.jpg"));

        // Disco 7
        discos.Add(new Disco(6, "Nibiru",
            new Artista ("Ozuna"), new Productor("Sony Music Latin"), new List<Tema>{
        new("Caramelo"), new("Noche de Sexo"), new("Baila Baila"), new("Como Antes"),
        new("Difícil de Creer"), new("Solitaria"), new("Ya No Me Acuerdo"), new("Te Bote"),
        new("Imposible"), new("Lo Que Me Gusta"), new("Secreto"), new("Contigo Siempre")}, "Reguetón, Dancehall", "Nibiru.jpg"));

        // Disco 8
        discos.Add(new Disco(7, "YHLQMDLG",
    new Artista ("Bad Bunny") , new Productor("Rimas Entertainment"), new List<Tema>{
        new("Si Veo a Tu Mamá"), new("La Canción"), new("Vete"), new("Pa' Romperla"),
        new("Safaera"), new("Bye Me Fui"), new("Yo Perreo Sola"), new("Otra Noche en Miami"),
        new("Estamos Bien"), new("Qué Malo"), new("Puesto Pa' Guerrillar"), new("Soltera Remix"),
        new("Te Mudaste"), new("Hablamos Mañana")}, "Reguetón, Trap, Latin Hip-Hop", "YHLQMDLG.jpg"));

        // Disco 9
        discos.Add(new Disco(8, "Mañana Será Bonito",
    new Artista("Karol G"), new Productor("Universal Music Latino"), new List<Tema>{
new("Mientras Me Curo del Cora"), new("X Si Volvemos"), new("Pero Tú"), new("Besties"),
new("Gucci Los Paños"), new("TQG"), new("Kármika"), new("Provenza"),
new("Tus Gafitas"), new("Carolina"), new("Amargura"), new("Mercurio")}, "Reguetón, Pop Latino", "MananaSeraBonito.jpg"));

        // Disco 10
        discos.Add(new Disco(9, "Feliz Cumpleaños Ferxxo Te Pirateamos el Álbum",
    new Artista("Feid"), new Productor("Universal Music Latino"), new List<Tema>{
new("Le Pido a Dios"), new("Ferxxo 100"), new("XQ Te Pones Así"), new("Prohibidox"),
new("Belixe"), new("Feliz Cumpleaños Ferxxo"), new("Normal"), new("Si Te La Encuentras Por Ahí"),
new("Castigo"), new("Vacaxiones"), new("Quemando Calorías"), new("Paris"), new("De Tanto Chimbiar")}, 
"Reguetón, Trap", "FelizCumpleanosFerxxo.jpg"));

        return discos;
    }
    public static Disco SelectDisco(int id)
    {
        Disco discoEncontrado = null;
        int i = 0;
        while(i <= Discos.Count() && discoEncontrado == null)
     {
       if (id == Discos[i].ID)
        {
            discoEncontrado = Discos[i];
        }
        i++;
    }
        return discoEncontrado;
    }
}