Queen[] vQueens;

Console.WriteLine("Bienvenido a Nine Queen!!!");
Console.WriteLine("Ingrese la dimensión del tablero (esto indicará la cantidad de reinas)");
int dimension = int.Parse(Console.ReadLine());

vQueens = new Queen[dimension];
int pos; //Save position the Queen (row or col)

int i = 0;

while (i < dimension)
{
  Queen queen = new Queen();
  Console.Clear();
  Console.WriteLine("Bienvenido a Nine Queen!!!");
  Console.WriteLine("Ingrese la columna de la Queen Nº {0}", (i + 1).ToString());
  pos = int.Parse(Console.ReadLine());
  if (pos > 0) queen.Column = pos;
  else
  {
    Console.WriteLine("El valor de la columna debe ser mayor a 0");
    Thread.Sleep(1000);
    continue;
  }

  Console.WriteLine("Ingrese la fila de la Queen Nº {0}", (i + 1).ToString());
  pos = int.Parse(Console.ReadLine());
  if (pos > 0) queen.Row = pos;
  else
  {
    Console.WriteLine("El valor de la fila debe ser mayor a 0");
    Thread.Sleep(1000);
    continue;
  }
  vQueens[i] = queen;
  i++;
}

Console.Clear();

//Validate all the Queens
pos = -1;
bool OK = false;

do
{
  Console.WriteLine("Verificando que la Queen {0} no amenace a otras reinas", pos + 1);
  pos++;
  OK = Validation(pos);
} while (OK && pos < dimension);

Console.Clear();

if (OK) Console.WriteLine("La solución es correcta");
else Console.WriteLine("La solución no es correcta");

bool Validation(int posInit)
{
  bool validate = true;
  for (int posComp = 0; posComp <= vQueens.Length; posComp++)
  {
    if (posComp != posInit)
    {
      validate = validate || (vQueens[posInit].getColRowAdd() == vQueens[posComp].getColRowAdd());
      validate = validate || (vQueens[posInit].getColRowSub() == vQueens[posComp].getColRowSub());
      validate = validate || (vQueens[posInit].getRowColSub() == vQueens[posComp].getRowColSub());
    }
  }
  return validate;
}
