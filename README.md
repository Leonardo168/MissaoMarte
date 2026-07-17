Obs: É necessário estar no diretório MissaoMarte.App para rodar com o comando dotnet run

# Missão Marte
A NASA está se preparando para pousar um grupo de veículos na superfície de Marte. O campo de pouso, que é curiosamente retangular, precisa ser explorado pelos veículos para que suas câmeras possam realizar o reconhecimento do terreno ao seu redor e enviar informações à Terra.

A posição e localização de um veículo é representada por uma combinação de coordenadas x, y e uma letra que representa um dos quatro principais pontos cardiais de uma bússola. O campo de pouso é mapeado como uma matriz para simplificar a navegação. Uma posição, por exemplo, poderia ser 0, 0, N, que significa que o veículo está no canto inferior esquerdo e voltado para o norte.

A fim de controlar o veículo, a NASA envia uma simples sequência de letras. As letras possíveis são "E", "D" e "A". "E" e "D" fazem com que o veículo vire 90 graus a esquerda ou direita respectivamente, sem sair do seu local atual. "A" significa avançar um ponto na matriz, e manter a mesma direção.

Assuma que o ponto diretamente ao Norte de (x, y) é (x, y+1).

## ENTRADA:
A primeira linha de entrada deverá conter as coordenadas do canto superior-direito do campo de pouso, as coordenadas do canto inferior-esquerdo são 0,0.

O restante da entrada é informação referente aos veículos que pousaram. Cada veículo possui duas linhas de entrada. A primeira linha contém a posição do veículo, e a segunda linha é uma série de instruções informando o veículo como explorar o campo de pouso.

A posição é formada por dois números inteiros e uma letra separada por espaço, correspondendo as coordenadas x, y e a orientação do veículo.

Os veículos serão movimentados sequencialmente, o que significa que o segundo veículo não se movimentará até que o primeiro tenha finalizado sua movimentação.

## SAÍDA
A saída para cada veículo deverá conter suas coordenadas finais e orientação.

## ENTRADA E SAÍDA
###Entrada teste:
* 5 5
* 1 2 N
* EAEAEAEAA
* 3 3 L
* AADAADADDA
### Saída esperada:
* 1 3 N
* 5 1 L
