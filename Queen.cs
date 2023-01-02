class Queen
{
  private int col;
  private int row;

  public Queen() { col = 0; row = 0; }

  public int Column
  {
    set { col = value; }
    get { return col; }
  }

  public int Row
  {
    set { row = value; }
    get { return row; }
  }
  public int getColRowAdd()
  {
    return col + row;
  }

  public int getColRowSub()
  {
    return col - row;
  }

  public int getRowColSub()
  {
    return row - col;
  }
}
