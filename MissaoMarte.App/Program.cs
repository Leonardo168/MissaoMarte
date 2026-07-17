using MissaoMarte;
using MissaoMarte.App.Utilities;

// ToDo implementar comportamento esperado em caso de input invalido
string inputCampoDePouso = InputUtility.CapturarInput("Insira as coordenadas do canto superior-direito do campo de pouso: ");
string[] inputCampoDePousoPartes = InputUtility.DividirInput(inputCampoDePouso);

int coordXCampo, coordYCampo;
// ToDo implementar comportamento esperado em caso de coordenadas invalidas
InputUtility.CapturarCoordenadasCampoDePouso(inputCampoDePousoPartes, out coordXCampo, out coordYCampo);

// ToDo implementar comportamento esperado em caso de input invalido
string inputVeiculo1 = InputUtility.CapturarInput("Insira a posicao do primeiro veiculo: ");
string[] inputVeiculo1Partes = InputUtility.DividirInput(inputVeiculo1);

int coordXVeiculo1, coordYVeiculo1;
char direcaoVeiculo1;
// ToDo implementar comportamento esperado em caso de posicao invalida
InputUtility.CapturarPosicaoVeiculo(inputVeiculo1Partes, out coordXVeiculo1, out coordYVeiculo1, out direcaoVeiculo1);

Veiculo veiculo1 = new Veiculo(coordXVeiculo1, coordYVeiculo1, direcaoVeiculo1);

string inputInstrucoesVeiculo1 = InputUtility.CapturarInput("Insira as instrucoes do primeiro veiculo: ");
// ToDo implementar comportamento esperado em caso de instrucoes invalidas
char[] instrucoesVeiculo1 = InputUtility.CapturarInstrucoes(inputInstrucoesVeiculo1);

// ToDo implementar comportamento esperado em caso de input invalido
string inputVeiculo2 = InputUtility.CapturarInput("Insira a posicao do segundo veiculo: ");
string[] inputVeiculo2Partes = InputUtility.DividirInput(inputVeiculo2);

int coordXVeiculo2, coordYVeiculo2;
char direcaoVeiculo2;
// ToDo implementar comportamento esperado em caso de posicao invalida
InputUtility.CapturarPosicaoVeiculo(inputVeiculo2Partes, out coordXVeiculo2, out coordYVeiculo2, out direcaoVeiculo2);

Veiculo veiculo2 = new Veiculo(coordXVeiculo2, coordYVeiculo2, direcaoVeiculo2);

string inputInstrucoesVeiculo2 = InputUtility.CapturarInput("Insira as instrucoes do segundo veiculo: ");
// ToDo implementar comportamento esperado em caso de instrucoes invalidas
char[] instrucoesVeiculo2 = InputUtility.CapturarInstrucoes(inputInstrucoesVeiculo2);

// ToDo implementar comportamento esperado caso as instrucoes levem o veiculo além dos limites do campo de pouso
veiculo1.ExecutarInstrucoes(instrucoesVeiculo1);
veiculo2.ExecutarInstrucoes(instrucoesVeiculo2);

Console.WriteLine("posicoes finais dos veiculos: ");
Console.WriteLine($"{veiculo1.CoordX} {veiculo1.CoordY} {veiculo1.Direcao}");
Console.WriteLine($"{veiculo2.CoordX} {veiculo2.CoordY} {veiculo2.Direcao}");