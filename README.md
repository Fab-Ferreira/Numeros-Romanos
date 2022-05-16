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

Após obter o valor de *tamanho*, o programa irá analisar cada algarismo do número que foi digitado. Dependendo do algarismo (2, 3, 7 e 8), haverão repetições de determinadas letras romanas. Segue a tabela abaixo para compreender a formação de cada número:

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

&nbsp;

## Atenção!
- Evite de clicar no botão com a TextBox sem texto, com letras ou com caracteres especiais;
- O programa só permite o uso de números **inteiros**, isto é, números negativos e positivos;
- Caso queira mudar os números da lista, apenas altere o texto dentro do arquivo txt "numeros", localizado na pasta *Bin\Debug*.

Este é o meu programa, espero que tenha gostado e que a explicação tenha sido eficiente. No próprio código, há alguns comentários explicando as linhas para caso queira entender melhor.
