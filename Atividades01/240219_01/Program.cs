//Exercicios:

string nomeDoUsuario = "lucas";
string emailDoUsuario = "lucas@gmail.com";
string dataDeNascimentoDoUsuario = "99/99";
string sexoDoUsuario = "Masculino";
string enderecoDoUsuario = "Nao sei";
string cepDoUsuario = "999.999.999-99";
string ruaDoUsuario = "Rua das palmeiras";
string numeroDoUsuario = "9999-9999";
string bairoDoUsuario = "Nao definido";
string cidadeDoUsuario = "Videira";
string unidadeFederativaDoUsuario = "Nao definido";
string countryDoUsuario = "Brasil";

string mensagem = $"Olá, {nomeDoUsuario}! Seu email {emailDoUsuario}" + " " +
"foi cadastrado, segue abaixo suas informações: \n" + 
$"data de nascimento: {dataDeNascimentoDoUsuario}\n" +
$"sexo: {sexoDoUsuario}\n" +
$"endereço: {enderecoDoUsuario}\n" +
$"CEP: {cepDoUsuario}\n" +
$"Rua: {ruaDoUsuario}\n" +
$"Número: {numeroDoUsuario}\n" +
$"Bairo: {bairoDoUsuario}\n" +
$"Cidade: {cidadeDoUsuario}\n" +
$"Unidade Federativa: {unidadeFederativaDoUsuario}\n" +
$"Pais: {countryDoUsuario}\n";

Console.WriteLine(mensagem);
