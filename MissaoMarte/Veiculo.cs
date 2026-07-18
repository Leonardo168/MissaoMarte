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
    public char Direcao { get; set; }

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

    public void VirarDireita()
    {
        switch (this.Direcao)
        {
            case 'N':
                this.Direcao = 'L';
                break;
            case 'L':
                this.Direcao = 'S';
                break;
            case 'S':
                this.Direcao = 'O';
                break;
            case 'O':
                this.Direcao = 'N';
                break;
            default:
                break;
        }
    }
}
