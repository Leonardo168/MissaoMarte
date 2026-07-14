namespace MissaoMarte;

public class Veiculo
{
    public Veiculo(int coordX, int coordY, char direcao)
    {
        CoordX = coordX;
        CoordY = coordY;
        Direcao = direcao;
    }

    public int CoordX { get; }
    public int CoordY { get; }
    public char Direcao { get; }
}
