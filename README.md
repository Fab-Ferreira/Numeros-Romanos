# Numeros-Romanos
## Introdução
Olá! Este é o meu conversor de números romanos, basta você inserir um número qualquer de 1 à 3999 e clicar em Converter. O programa a seguir foi feito no SharpDevelop utilizando o Windows Application.
&nbsp;

## Funcionalidade do Programa
O programa, primeiramente, identifica a quantidade de algarismos do número que você digitou, isto é, quantos caracteres (char) existem dentro do número (string). Se o número digitado pelo usuário possuir:
1. 4 algarismos (ou seja, um número entre 1000 e 3999), a variável *tamanho* receberá 3;
2. 3 algarismos (ou seja, um número entre 100 e 999), a variável *tamanho* receberá 2;
3. 2 algarismos (ou seja, um número entre 10 e 99), a variável *tamanho* receberá 1;
4. 1 algarismo (ou seja, um número entre 1 e 9), a variável *tamanho* receberá 0;

Após obter o valor de *tamanho*, o programa irá analisar cada algarismo do número que foi digitado. Dependendo do algarismo (2, 3, 7 e 8), haverão repetições de determinadas letras. Segue a tabela abaixo para compreender a formação de cada número:

Algarismo | Romano (na unidade de milhar) | Romano (na centena) | Romano (na dezena) | Romano (na unidade)
----- | ------ | ------ | ------ | ------ 
1 | M | C | X | I
2 | MM | CC | XX | II
3 | MMM | CCC | XXX | III
4 | inválido | CD | XL | IV
5 | inválido | D | L | V
6 | inválido | DC | LX | VI
7 | inválido | DCC | LXX | VII
8 | inválido | DCCC | LXXX | VIII
9 | inválido | CM | XC | IX

**Por exemplo:** O número 2659 em algarismos romanos.
- O número 2 está na 1ª posição (unidade de milhar), logo seu algarismo romano será o M repetido duas vezes (**MM**);
- O número 6 está na 2ª posição (centena), logo seu algarismo romano será o D unido com o C repetido uma única vez (**DC**);
- O número 5 está na 3ª posição (dezena), logo seu algarismo romano será o L (**L**);
- O número 9 está na 4ª posição (unidade), logo seu algarismo romano será o IX (**IX**);

Resultado: **MMDCLIX**
&nbsp;

### Como que o programa sabe qual letra aplicar para cada algarismo?
Através de vetores string. O programa possui 4 vetores string que armazenam as letras:
~~~c#
string[] romanos1 = {"I", "X", "C", "M"}, romanos5 = {"V", "L", "D"}, romanos4 = {"IV", "XL", "CD"}, romanos9 = {"IX", "XC", "CM"}
~~~
Seguindo o exemplo mostrado, em um número de 4 algarismos, o número 6 está na 2ª posição (centena). Como já explicado, um número com 4 algarismos fará com que *tamanho* receba 3. A partir disso, o programa fará a seguinte análise:
~~~c#
string numRomano += (romanos5[tamanho - (posicao - 1)] + romanos1[tamanho - (posicao - 1)]);
~~~
Ou seja:
~~~c#
string numRomano += (romanos5[4 - 2] + romanos1[4 - 2]);
~~~
Explicando o código acima, a variável *numRomano* (que seria o texto onde será guardado o número romano do número inserido) receberá a união da string **"D"** (já que romanos5[2] equivale à "D") com a string **"C"** (já que romanos1[2] equivale à **"C"**), resultando em **DC**.

#### Observação:
Lembre-se: em um vetor, a primeira posição é 0, ou seja, romanos5[0] equivale à "V", romanos5[1] equivale à "L", e assim por diante.

## Atenção!
- Evite de clicar no botão com a TextBox sem texto, com letras ou com caracteres especiais;
- O programa só permite o uso de números **naturais** entre 1 e 3999;

Este é o meu programa, espero que tenha gostado e que a explicação tenha sido eficiente. No próprio código, há alguns comentários explicando as linhas para caso queira entender melhor.
