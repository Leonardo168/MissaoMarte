namespace MissaoMarte;

public class Veiculo
{
    public Veiculo(int coordX, int coordY, char direcao)
    {
        CoordX = coordX;
        CoordY = coordY;
        Direcao = direcao;
    }

    public int CoordX { get; set; }
    public int CoordY { get; set; }
    public char Direcao { get; }

    public void IncrementarCoordX()
    {
        this.CoordX++;
    }

    public void IncrementarCoordY()
    {
        this.CoordY++;
    }

    public void DecrementarCoordX()
    {
        this.CoordX--;
    }

    public void DecrementarCoordY()
    {
        this.CoordY--;
    }
}
