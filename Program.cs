// Exercício do site URI "Medias Ponderadas"
// Esse programa o usuario ira dititar um nummero inteiro para saber quantas fileiras de notas tera que digitar.
// Cada fileira terá três notas, cada nota tera seu valor ponderado, e no final do programa ira mostrar na tela a media de cada fileitra.

double Media, Nota1, Nota2, Nota3;

int N = int.Parse(Console.ReadLine());
string[] Notas;
Media = 0;

for (int i = 1; i <= N; i++)
{
    Notas = (Console.ReadLine().Split(' '));
    Nota1 = double.Parse(Notas[0]);
    Nota2 = double.Parse(Notas[1]);
    Nota3 = double.Parse(Notas[2]);

    Media = ((Nota1 * 2) + (Nota2 * 3) + (Nota3 * 5)) / 10;

    Console.WriteLine(Media.ToString("F1"));
}